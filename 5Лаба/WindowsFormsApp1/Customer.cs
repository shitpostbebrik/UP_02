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
    public partial class Customer : Form
    {
        DataBase dataBase = new DataBase();

        int SelectRow;
        public Customer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void CreateColumns()
        {
            dataGridView1.Columns.Add("[Код модели]", "Код модели");
            dataGridView1.Columns.Add("[Наименование модели]", "Наименование модели");
            dataGridView1.Columns.Add("Цвет", "Цвет");
            dataGridView1.Columns.Add("Обивка", "Обивка");
            dataGridView1.Columns.Add("[Мощность двигателя]", "Мощность двигателя");
            dataGridView1.Columns.Add("[Количество дверей]", "Количество дверей");
            dataGridView1.Columns.Add("[Коробка передач]", "Коробка передач");

            dataGridView1.Columns.Add("[Год выпуска]", "Год выпуска");
            dataGridView1.Columns.Add("[Цена]", "Цена");
            dataGridView1.Columns.Add("[Предпродажная подготовка]", "Предпродажная подготовка");
            dataGridView1.Columns.Add("[Транспортные издержки]", "Транспортные издержки");

            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6), record.GetInt32(7), record.GetInt32(8), record.GetInt32(9), record.GetInt32(10), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string stringQuery = $"SELECT МОДЕЛИ.[Код модели], МОДЕЛИ.[Наименование модели], МОДЕЛИ.[Цвет],МОДЕЛИ.[Обивка],МОДЕЛИ.[Мощность двигателя],МОДЕЛИ.[Количество дверей], МОДЕЛИ.[Коробка передач], [ПРЕЙСКУРАНТ ЦЕН].[Год выпуска], [ПРЕЙСКУРАНТ ЦЕН].Цена, [ПРЕЙСКУРАНТ ЦЕН].[Предпродажная подготовка], [ПРЕЙСКУРАНТ ЦЕН].[Транспортные издержки] FROM МОДЕЛИ JOIN [ПРЕЙСКУРАНТ ЦЕН] ON МОДЕЛИ.[Код модели]=[ПРЕЙСКУРАНТ ЦЕН].[Код модели];";

            SqlCommand cmd = new SqlCommand(stringQuery, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from МОДЕЛИ" +
                    $" where concat ([Код модели],[Наименование модели],[Цвет],[Обивка],[Мощность двигателя],[Количество дверей],[Коробка передач] ) like '%" + textBox_Search.Text + "%'";

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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectRow];


                textBox_Code.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Color.Text = row.Cells[2].Value.ToString();
                textBox_Upholstery.Text = row.Cells[3].Value.ToString();
                textBox_Engine.Text = row.Cells[4].Value.ToString();
                textBox_Doors.Text = row.Cells[5].Value.ToString();
                textBox_Gearbox.Text = row.Cells[6].Value.ToString();

                textBox_God.Text = row.Cells[7].Value.ToString();
                textBox_Cena.Text = row.Cells[8].Value.ToString();
                textBox_Podgot.Text = row.Cells[9].Value.ToString();
                textBox_Izderzch.Text = row.Cells[10].Value.ToString();



            }
        }
              

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автомобиль заказан!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
