using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
   public enum RowStat
    { Existed, New, Modified, ModifiedNew, Deleted }
    public partial class Users : Form
    {
        DataBase dataBase = new DataBase();
        int SelectRow;
        public Users()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("login", "Логин");
            dataGridView1.Columns.Add("pwd", "Пароль");                        
            dataGridView1.Columns.Add("roles", "Роль");
            dataGridView1.Columns.Add("fio", "ФИО");
            dataGridView1.Columns.Add("phone", "Номер");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string stringQuery = $"select * from register";

            SqlCommand cmd = new SqlCommand(stringQuery, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectRow];


                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_FIO.Text = row.Cells[1].Value.ToString();
                textBox_login.Text = row.Cells[2].Value.ToString();
                textBox_pwd.Text = row.Cells[3].Value.ToString();
                textBox_Role.Text = row.Cells[4].Value.ToString();
                textBox_phone.Text = row.Cells[5].Value.ToString();


            }
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            SignAdmin signAdmin = new SignAdmin();
            signAdmin.Show();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            Del();
            ClearFields();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Up();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from register" +
                $" where concat (id, fio, login, pwd, roles, phone) like '%" + textBox_Search.Text + "%'";

            SqlCommand cmd = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();

        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Del()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowStat.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowStat.Deleted;

        }
        private void Up()
        {
            dataBase.openConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowStat)dataGridView1.Rows[i].Cells[6].Value;

                if (rowState == RowStat.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    var deleteQuery = $"delete from register where id = {id}";


                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowStat.Modified)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var fio = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var login = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var pwd = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    var roles = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    var phone = dataGridView1.Rows[i].Cells[5].Value.ToString();


                    var query = $"update register set fio = '{fio}', login='{login}'," +
                        $"pwd='{pwd}', roles = '{roles}', phone = '{phone}' where id = '{id}'";


                    var command = new SqlCommand(query, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var Fio = textBox_FIO.Text;
            var login = textBox_login.Text;
            var pwd = textBox_pwd.Text;
            var role = textBox_Role.Text;
            var phone = textBox_phone.Text;
            
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, Fio, login, pwd, role, phone);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowStat.Modified;
            }
        }
        private void ClearFields()
        {
            textBox_ID.Text = "";
            textBox_FIO.Text = "";
            textBox_pwd.Text = "";
            textBox_Role.Text = "";
            textBox_login.Text = "";
            textBox_phone.Text = "";
        }
    }
}
