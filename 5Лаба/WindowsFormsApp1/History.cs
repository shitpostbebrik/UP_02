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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    
    
    public partial class History : Form
    {
        DataBase dataBase = new DataBase();
        //Dictionary<int, DateTime> list  = new Dictionary<int, DateTime>() { {1, DateTime.Now },{2, DateTime.Now } };
        public History()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //DataGrid dataGrid;

        private void CreateColumns()
        {
            
            dataGridView1.Columns.Add("id_user", "Номер работника");
            dataGridView1.Columns.Add("_time", "Время входа");
            dataGridView1.Columns.Add("succsesful", "1/0");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add( record.IsDBNull(1) ? -1 :record.GetInt32(1), record.GetDateTime(2), record.GetBoolean(3),RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string stringQuery = $"select * from History";

            SqlCommand cmd = new SqlCommand(stringQuery, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }


        private void History_Load(object sender, EventArgs e)
        {
            //List<int> list = new List<int>();
            //dataGridView1 = new DataGridView();
            //dataGridView1.ColumnCount = 2;
            //dataGridView1.DataSource = list;
            CreateColumns();
            RefreshDataGrid(dataGridView1);



        }             

        private void Del()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            dataGridView1.Rows[index].Cells[3].Value = RowStat.Deleted;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[3].Value;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    var deleteQuery = $"delete from History where id_user = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            Del();
        }
    }
}
