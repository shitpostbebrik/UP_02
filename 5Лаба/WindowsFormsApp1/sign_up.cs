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
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_sign_up_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var pwd = textBox_pwd.Text;
            var fio = textBox_FIO.Text;
            var phone = textBox_Phone.Text;
            var role = textBox_role.Text;

            string stringQuery = $"insert into register(FIO, login, pwd, roles, phone) " +
                $"values('{fio}','{login}','{pwd}','{role}','{phone}')";

            SqlCommand command = new SqlCommand(stringQuery, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!!!", "@@@");
                log_in log_In = new log_in();
                this.Hide();
                log_In.ShowDialog();   
                this.Show();
            }
            else
                MessageBox.Show("Аккаунт не создан!!!", "@@@");
            dataBase.closeConnection();

        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
