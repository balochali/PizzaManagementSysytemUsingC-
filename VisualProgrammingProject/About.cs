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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPage obj = new FirstPage();
            this.Hide();
            obj.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            this.Hide();
            obj.ShowDialog();
        }

        private void dealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deals obj = new Deals();
            this.Hide();
            obj.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Already in About Page");
        }
    }
}
