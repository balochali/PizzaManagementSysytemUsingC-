using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        Reports report = new Reports();
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.Show();
            this.Hide();
        }

        
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in Home Page");
        }


        
        private void OrderNow_Click(object sender, EventArgs e)
        {
           ClassicPizza obj = new ClassicPizza();
           this.Hide();
           obj.ShowDialog();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deals obj = new Deals();
            this.Hide();
            obj.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About obj = new About();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
