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
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    //enum RowState
    //{Existed, New, Modified, ModifiedNew, Deleted }
    public partial class Models : Form
    {
        DataBase dataBase = new DataBase();
        int SelectRow;
        public Models()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView2.Columns.Add("[Код модели]", "Код модели");
            dataGridView2.Columns.Add("[Наименование модели]", "Наименование модели");
            dataGridView2.Columns.Add("Цвет", "Цвет");
            dataGridView2.Columns.Add("Обивка", "Обивка");
            dataGridView2.Columns.Add("[Мощность двигателя]", "Мощность двигателя");
            dataGridView2.Columns.Add("[Количество дверей]", "Количество дверей");
            dataGridView2.Columns.Add("[Коробка передач]", "Коробка передач");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }


        private void ReadSingleRows2(DataGridView dgw2, IDataRecord record)
        {
            dgw2.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string stringQuery = $"select * from МОДЕЛИ";
            
            SqlCommand cmd = new SqlCommand(stringQuery, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows2(dgw, reader);
            }
            reader.Close();
        }

        private void Tovars_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        
        private void button_New_Click(object sender, EventArgs e)
        {
            NewModel newTovarcs = new NewModel();
            newTovarcs.Show();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from МОДЕЛИ_ПРЕДЛОЖЕНИЕ" +
                    $" where concat ([Код модели],[Наименование модели],[Цвет],[Обивка],[Мощность двигателя],[Количество дверей],[Коробка передач] ) like '%" + textBox_Search.Text + "%'";

            SqlCommand cmd = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows2(dgw, reader);
            }
            reader.Close();

        }


        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }


        private void Del()
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = true;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }


            dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;

        }

        private void Up()
        {
            dataBase.openConnection();



            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (dataGridView2.Rows[i].Cells[7].Value != null)

                {
                    var rowState = (RowState)dataGridView2.Rows[i].Cells[7].Value;
                    Debug.WriteLine($"Row {i}, RowState: {rowState}");

                    if (rowState == RowState.Existed)

                        continue;


                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);

                        var deleteQuery = $"delete from МОДЕЛИ where [Код модели] = {id}";

                        var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                        command.ExecuteNonQuery();
                    }

                    if (rowState == RowState.Modified)
                    {
                        var idd = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        var name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                        var color = dataGridView2.Rows[i].Cells[2].Value.ToString();
                        var upholstery = dataGridView2.Rows[i].Cells[3].Value.ToString();
                        var engine = dataGridView2.Rows[i].Cells[4].Value.ToString();
                        var doors = dataGridView2.Rows[i].Cells[5].Value.ToString();
                        var gearbox = dataGridView2.Rows[i].Cells[6].Value.ToString();



                        var query = $"update МОДЕЛИ set [Наименование модели] = '{name}', [Цвет]='{color}',[Обивка]='{upholstery}', [Мощность двигателя]='{engine}',[Количество дверей]='{doors}',[Коробка передач]='{gearbox}'" +
                            $" where [Код модели] = '{idd}'";


                        var command2 = new SqlCommand(query, dataBase.getConnection());
                        command2.ExecuteNonQuery();
                    }
                }
                else
                {
                    Debug.WriteLine($"Row {i}, Cell[7] is null");
                }


            }
            dataBase.closeConnection();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            Del();
           
        }



        private void Change()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            var id = textBox2_Code.Text;
            var name = textBox2_Name.Text;
            var color = textBox2_Color.Text;
            var upholstery = textBox2_Upholstery.Text;

            decimal engine;
            decimal doors;
            var gearbox = textBox2_Gearbox.Text;


            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value != null &&
                    dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)

            {
                if (decimal.TryParse(textBox2_Engine.Text, out engine) & decimal.TryParse(textBox2_Doors.Text, out doors))
                {
                    dataGridView2.Rows[selectedRowIndex].SetValues(id, name, color, upholstery, engine, doors, gearbox);
                    dataGridView2.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле указано не верно!!!");
                }
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            Change();
           
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Up();
        }

        

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[SelectRow];


                textBox2_Code.Text = row.Cells[0].Value.ToString();
                textBox2_Name.Text = row.Cells[1].Value.ToString();
                textBox2_Color.Text = row.Cells[2].Value.ToString();
                textBox2_Upholstery.Text = row.Cells[3].Value.ToString();
                textBox2_Engine.Text = row.Cells[4].Value.ToString();
                textBox2_Doors.Text = row.Cells[5].Value.ToString();
                textBox2_Gearbox.Text = row.Cells[6].Value.ToString();



            }
        }
    }
}
