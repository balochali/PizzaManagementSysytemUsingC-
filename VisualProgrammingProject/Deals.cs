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
    public partial class Deals : Form
    {
        public Deals()
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

        public int countdeal= 0;
        
        public DealsArray [] dealarr = new DealsArray[30];
        private void dealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in Deals Page");
        }

        private void Deal1_Click(object sender, EventArgs e)
        {
            dealarr[countdeal] = new DealsArray();
            dealarr[countdeal].name = "Deal 01";
            dealarr[countdeal].price = 300;
            countdeal++;
            MessageBox.Show("Added Succesfully....!");
        }

        private void Deal2_Click(object sender, EventArgs e)
        {
            dealarr[countdeal] = new DealsArray();
            dealarr[countdeal].name = "Deal 02";
            dealarr[countdeal].price = 220;
            countdeal++;
            MessageBox.Show("Added Succesfully....!");
        }

        private void Deal3_Click(object sender, EventArgs e)
        {
            dealarr[countdeal] = new DealsArray();
            dealarr[countdeal].name = "Deal 03";
            dealarr[countdeal].price = 750;
            countdeal++;
            MessageBox.Show("Added Succesfully....!");
        }

        private void Deal4_Click(object sender, EventArgs e)
        {
            dealarr[countdeal] = new DealsArray();
            dealarr[countdeal].name = "Deal 04";
            dealarr[countdeal].price = 1500;
            countdeal++;
            MessageBox.Show("Added Succesfully....!");
        }

        private void Deal5_Click(object sender, EventArgs e)
        {
            dealarr[countdeal] = new DealsArray();
            dealarr[countdeal].name = "Deal 05";
            dealarr[countdeal].price = 1250;
            countdeal++;
            MessageBox.Show("Added Succesfully....!");
        }

        private void Deal6_Click(object sender, EventArgs e)
        {
            dealarr[countdeal] = new DealsArray();
            dealarr[countdeal].name = "Deal 06";
            dealarr[countdeal].price = 2000;
            countdeal++;
            MessageBox.Show("Added Succesfully....!");
        }
        PizzaDataContext piz = new PizzaDataContext();
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Deal obj = new Deal();
            
            for (int i = 0; i < countdeal; i++)
            {
                obj.Quantity = 1;
                obj.Name_ = dealarr[i].name;
                obj.Price = dealarr[i].price;
            }
            piz.Deals.InsertOnSubmit(obj);
            piz.SubmitChanges();
            ClassicPizza show1 = new ClassicPizza();
            this.Hide();
            show1.ShowDialog();
        }
    }
}
