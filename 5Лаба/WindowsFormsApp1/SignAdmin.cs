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
    public partial class SignAdmin : Form
    {
        DataBase dataBase = new DataBase();
        public SignAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var pwd = textBox_pwd.Text;
            var fio = textBox_FIO.Text;
            var phone = textBox_phone.Text;
            var role = comboBox_Role.Text;

            string stringQuery = $"insert into register(fio, login, pwd, roles, phone) " +
                $"values('{fio}','{login}','{pwd}','{role}','{phone}')";

            SqlCommand command = new SqlCommand(stringQuery, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!!!", "@@@");
                Users workers = new Users();
                this.Hide();
                workers.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Аккаунт не создан!!!", "@@@");
            dataBase.closeConnection();
        }
    }
}
