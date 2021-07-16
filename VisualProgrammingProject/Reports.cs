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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            PizzaDataContext obj = new PizzaDataContext();
            this.Pizza.DataSource = from piz in obj.PizzaFlavours select piz;
            this.Starters.DataSource = from start in obj.Starters select start;
            this.Burger.DataSource = from burger in obj.BurgerNBrosts select burger;
            this.Roll.DataSource = from roll in obj.RollNSandwiches select roll;
            this.Salad.DataSource = from salad in obj.SaladNPastas select salad;
            this.deals.DataSource = from deal in obj.Deals select deal;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            FirstPage obj = new FirstPage();
            obj.Show();
            this.Dispose();           
        }
    }
}
