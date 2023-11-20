using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Administrator : Form
    {


        public Administrator(string FIO)
        {
            
            InitializeComponent();
            label1.Text = FIO;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_sign_up_Click(object sender, EventArgs e)
        {
            Users workers = new Users();
            this.Hide();
            workers.ShowDialog();
            this.Show();

        }

        private void button_Tov_List_Click(object sender, EventArgs e)
        {
             Models tovars = new Models();
            this.Hide();
            tovars.ShowDialog();
            this.Show();
        }

        private void button_His_Click(object sender, EventArgs e)
        {
           History history = new History(); 
            history.ShowDialog();   
        }

        
    }
}
