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
    public partial class NewModel : Form
    {
        DataBase dataBase = new DataBase();
        public NewModel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();           
            
            int doors;
            int engine;
            var name =  textBox_name.Text;
            var color = textBox_Color.Text;
            var upholstery = comboBox2.Text; 
            var gearbox = comboBox1.Text;

            if (int.TryParse(textBox_Engine.Text, out engine) | int.TryParse(textBox_Doors.Text, out doors))
            {
                var addQuery = $"insert into МОДЕЛИ_ПРЕДЛОЖЕНИЕ ([Наименование модели],[Цвет],[Обивка],[Мощность двигателя],[Количество дверей],[Коробка передач]) " +
                    $"values ('{name}','{color}','{upholstery}', '{engine}', '{doors}', '{gearbox}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();



                MessageBox.Show("Запись создана успешно!!!", "Успех!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Мощность введена не правильно");
            }
            dataBase.closeConnection();



        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewTovarcs_Load(object sender, EventArgs e)
        {

        }
    }
}
