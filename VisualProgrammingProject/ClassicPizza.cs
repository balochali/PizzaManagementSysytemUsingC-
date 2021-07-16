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
using System.Configuration;

namespace VisualProgrammingProject
{
    public partial class ClassicPizza : Form
    {
        public ClassicPizza()
        {
            InitializeComponent();
            
        }
        PizzaDataContext piz = new PizzaDataContext();
               
        private void ClassicPizza_Load(object sender, EventArgs e)
        {
            //Pizza Flavours
            comboPizza.Items.Add("Chicken Tikka");
            comboPizza.Items.Add("Chicken Fajita");
            comboPizza.Items.Add("Bihari Tikka");
            comboPizza.Items.Add("Hot & Spicy");
            comboPizza.Items.Add("Afghani");
            comboPizza.Items.Add("Cheese Lover");
            comboPizza.Items.Add("Malai Boti");
            comboPizza.Items.Add("Vegi Lover");
            comboPizza.Items.Add("Chicken Supremo");

            //Starters
            comboStarters.Items.Add("Garlic Bread");
            comboStarters.Items.Add("Cheese Garlic Bread");
            comboStarters.Items.Add("French Fries");
            comboStarters.Items.Add("Pizza Fries");
            comboStarters.Items.Add("Wings 05 Pcs");
            comboStarters.Items.Add("Wings 10 Pcs");
            comboStarters.Items.Add("Nuggets 05 Pcs");
            comboStarters.Items.Add("Nuggets 10 Pcs");

            //Burger N Broast
            comboBurger.Items.Add("Chicken Burger");
            comboBurger.Items.Add("Zinger Burger");
            comboBurger.Items.Add("Zinger Cheese Burger");
            comboBurger.Items.Add("Swiss Burger");
            comboBurger.Items.Add("Beef Burger");
            comboBurger.Items.Add("Chicken Broast (Leg)");
            comboBurger.Items.Add("Chicken Broast (Chest)");

            //Roll N Sandwich
            comboRoll.Items.Add("Chicken Roll");
            comboRoll.Items.Add("Mayo Roll");
            comboRoll.Items.Add("Zinger Roll");
            comboRoll.Items.Add("Spring Roll");
            comboRoll.Items.Add("Chicken Cheese Roll");
            comboRoll.Items.Add("Club Sandwich");
            comboRoll.Items.Add("Grill Sandwich");
            comboRoll.Items.Add("Spicy Sandwich");

            //Salad N Pasta
            comboSalad.Items.Add("Russian Salad");
            comboSalad.Items.Add("Chicken Pasta");
            comboSalad.Items.Add("Spaghetti");
        }

        int totalprice = 0;
        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            int totalpizza = 0;
            int totalroll = 0;
            int totalsalad = 0;
            int totalburger = 0;
            int totalstarter = 0;
            
            
            //Price for Pizza
            for (int i = 0; i < countpizza; i++)
            {
                totalpizza += pitza[i].qty * pitza[i].price;
            }
            txtPizzaPrice.Text = Convert.ToString(totalpizza);


            //Price for Starter
            for (int i = 0; i < counstarter; i++)
            {
                totalstarter += start[i].qty * start[i].price;
            }
            txtStarterPrice.Text = Convert.ToString(totalstarter);

            //Price for Salad
            for (int i = 0; i < countsalad; i++)
            {
                totalsalad += salad[i].qty * salad[i].price;
            }
            txtSaladPrice.Text = Convert.ToString(totalsalad);


            //price for burger
            for (int i = 0; i < countburger; i++)
            {
                totalburger += burg[i].qty * burg[i].price;
            }
            txtBurgerPrice.Text = Convert.ToString(totalburger);


            //price for roll
            for (int i = 0; i < countroll; i++)
            {
                totalroll += roll[i].qty * roll[i].price;                    
            }
            txtRollPrice.Text = Convert.ToString(totalroll);
            totalprice = totalroll + totalsalad + totalpizza + totalburger + totalstarter;
            txtTotalPrice.Text = Convert.ToString(totalprice);
        }
        
        Pizza[] pitza = new Pizza[20];
        BurgerNBroast[] burg = new BurgerNBroast[20];
        Starterss[] start = new Starterss[20];
        RollNSandwichhhh[] roll = new RollNSandwichhhh[20];
        SaladNPastassss[] salad = new SaladNPastassss[20];
        
        
        int countsalad = 0;
        int countroll = 0;
        int counstarter = 0;
        int countburger = 0;
        int countpizza = 0;

        private void btnMorePizza_Click(object sender, EventArgs e)
        {

            pitza[countpizza] = new Pizza();
            pitza[countpizza].qty = Convert.ToInt32(txtPizza.Text);
            pitza[countpizza].itemname = comboPizza.SelectedItem.ToString();
            
            if (rbSmall.Checked == true)
            {
                
                pitza[countpizza].size = "Small";
                pitza[countpizza].price = 300;
            }

            else if (rbLarge.Checked == true)
            {
                pitza[countpizza].size = "Large";
                pitza[countpizza].price = 850;
            }

            else if (rbMedium.Checked == true)
            {
                pitza[countpizza].size = "Medium";
                pitza[countpizza].price = 600;
            }
            countpizza++;

        }

        
        private void btnStarter_Click(object sender, EventArgs e)
        {
            start[counstarter] = new Starterss();
            start[counstarter].qty = Convert.ToInt32(txtQTYStarters.Text);
            start[counstarter].name = comboStarters.SelectedItem.ToString();
            if (comboStarters.SelectedItem.ToString() == "Garlic Bread")
            {
                start[counstarter].price = 50;
            }

            else if (comboStarters.SelectedItem.ToString() == "Cheese Garlic Bread")
            {
                start[counstarter].price = 70;
            }

            else if (comboStarters.SelectedItem.ToString() == "French Fries")
            {
                start[counstarter].price = 100;
            }

            else if (comboStarters.SelectedItem.ToString() == "Pizza Fries")
            {
                start[counstarter].price = 170;
            }

            else if (comboStarters.SelectedItem.ToString() == "Wings 05 Pcs")
            {
                start[counstarter].price = 100;
            }

            else if (comboStarters.SelectedItem.ToString() == "Wings 15 Pcs")
            {
                start[counstarter].price = 180;
            }

            else if (comboStarters.SelectedItem.ToString() == "Nuggets 05 Pcs")
            {
                start[counstarter].price = 150;
            }

            else if (comboStarters.SelectedItem.ToString() == "Nuggets 10 Pcs")
            {
                start[counstarter].price = 250;
            }
            counstarter++;
        }

        private void btnRoast_Click(object sender, EventArgs e)
        {
            burg[countburger] = new BurgerNBroast();
            burg[countburger].qty = Convert.ToInt32(txtQtyBurger.Text);
            burg[countburger].name = comboBurger.SelectedItem.ToString();
            if (comboBurger.SelectedItem.ToString() == "Chicken Burger")
            {
                burg[countburger].price = 120;
            }

            else if (comboBurger.SelectedItem.ToString() == "Zinger Burger")
            {
                burg[countburger].price = 220;
            }

            else if (comboBurger.SelectedItem.ToString() == "Zinger Cheese Burger")
            {
                burg[countburger].price = 250;
            }

            else if (comboBurger.SelectedItem.ToString() == "Swiss Burger")
            {
                burg[countburger].price = 250;
            }

            else if (comboBurger.SelectedItem.ToString() == "Beef Burger")
            {
                burg[countburger].price = 300;
            }

            else if (comboBurger.SelectedItem.ToString() == "Chicken Broast (Leg)")
            {
                burg[countburger].price = 200;
            }

            else if (comboBurger.SelectedItem.ToString() == "Chicken Broast (Chest)")
            {
                burg[countburger].price = 220;
            }
            countburger++;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            roll[countroll] = new RollNSandwichhhh();
            roll[countroll].qty = Convert.ToInt32(txtRoll.Text);
            roll[countroll].name = comboRoll.SelectedItem.ToString();
            
            if (comboRoll.SelectedItem.ToString() == "Chicken Roll")
            {
                roll[countroll].price = 120;
            }

            else if (comboRoll.SelectedItem.ToString() == "Mayo Roll")
            {
                roll[countroll].price = 100;
            }

            else if (comboRoll.SelectedItem.ToString() == "Zinger Roll")
            {
                roll[countroll].price = 150;
            }

            else if (comboRoll.SelectedItem.ToString() == "Spring Roll")
            {
                roll[countroll].price = 110;
            }

            else if (comboRoll.SelectedItem.ToString() == "Chicken Cheese Roll")
            {
                roll[countroll].price = 150;
            }

            else if (comboRoll.SelectedItem.ToString() == "Club Sandwich")
            {
                roll[countroll].price = 120;
            }

            else if (comboRoll.SelectedItem.ToString() == "Grill Sandwich")
            {
                roll[countroll].price = 140;
            }

            else if (comboRoll.SelectedItem.ToString() == "Spicy Sandwich")
            {
                roll[countroll].price = 150;
            }
            countroll++;
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            salad[countsalad] = new SaladNPastassss();
            salad[countsalad].qty = Convert.ToInt32(txtSalad.Text);
            salad[countsalad].name = comboSalad.SelectedItem.ToString();

            if (comboSalad.SelectedItem.ToString() == "Russian Salad")
            {
                salad[countsalad].price = 300;
            }

            else if (comboSalad.SelectedItem.ToString() == "Chicken Pasta")
            {
                salad[countsalad].price = 200;
            }

            else if (comboSalad.SelectedItem.ToString() == "Spaghetti")
            {
                salad[countsalad].price = 200;
            }
            countsalad++;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPage home = new FirstPage();
            home.Show();
            this.Dispose();
        }

        
        public void ConfirmOrder_Click(object sender, EventArgs e)
        {
            //Confirm for Pizza
            for (int i = 0; i < countpizza; i++)
            {
                PizzaFlavour obj = new PizzaFlavour();
                obj.Quantity = pitza[i].qty;
                obj.Pizza_Flavour = pitza[i].itemname;
                obj.Size = pitza[i].size;
                obj.Price = pitza[i].price;

                piz.PizzaFlavours.InsertOnSubmit(obj);
                piz.SubmitChanges();
            }

            //Confirm for Burger
            for (int i = 0; i < countburger; i++)
            {
                BurgerNBrost obj = new BurgerNBrost();
                obj.Quantity = burg[i].qty;
                obj.Item_Name_ = burg[i].name;
                obj.Price = burg[i].price;
                
                piz.BurgerNBrosts.InsertOnSubmit(obj);
                piz.SubmitChanges();
            }

            //Confirm for Starters
            for (int i = 0; i < counstarter; i++)
            {
                Starter obj = new Starter();
                obj.Quantity = start[i].qty;
                obj.Starter_Name = start[i].name;
                obj.Price = start[i].price;

                piz.Starters.InsertOnSubmit(obj);
                piz.SubmitChanges();
            }

            //Confirm for Roll
            for (int i = 0; i < countroll; i++)
            {
                RollNSandwich obj = new RollNSandwich();
                obj.Quantity = roll[i].qty;
                obj.Item_No = roll[i].name;
                obj.Price = roll[i].price;

                piz.RollNSandwiches.InsertOnSubmit(obj);
                piz.SubmitChanges();
            }

            //Confirm for Salad N Pasta 
            for (int i = 0; i < countsalad; i++)
            {
                SaladNPasta obj = new SaladNPasta();
                obj.Quantity = salad[i].qty;
                obj.Item_Name = salad[i].name;
                obj.Price = salad[i].price;

                piz.SaladNPastas.InsertOnSubmit(obj);
                piz.SubmitChanges();
            }

            Reciept();
        }

        public void Reciept()
        {
            DateTime d = new DateTime();
            txtReciept.Text = "\t               " + DateTime.Now.Date.ToShortDateString() +
                "\n                                ";

            txtReciept.Text += "\n -----------------CLASSIC PIZZA AND -----------------\n" +
                "----------------- FAST FOOD TOWN -------------------" +
                "\n                                                                                 " +
                "\n ####### Computer Generated Reciept #######" +
                "\n                                                                                        " +
                "\n                                                                                        " +
                "\n Qty            Item Name                         Price" +
                "\n                                                                                           ";
            for (int i = 0; i < countpizza; i++)
            {
                txtReciept.Text += "         " + pitza[i].qty + "\t         " + pitza[i].itemname + "\t\t"+ pitza[i].price + "\n\t";
            }
            
            for (int i = 0; i < countburger; i++)
            {
                txtReciept.Text += "         " + burg[i].qty + "\t         " + burg[i].name + "\t\t" + burg[i].price + "\n\t";
            }

            for (int i = 0; i < countroll; i++)
            {
                txtReciept.Text += "         " + roll[i].qty + "\t         " + roll[i].name + "\t\t" + roll[i].price + "\n\t";
            }

            for (int i = 0; i < countsalad; i++)  
            {
                txtReciept.Text += "         " + salad[i].qty + "\t         " + salad[i].name + "\t\t" + salad[i].price + "\n\t";
            }

            for (int i = 0; i < counstarter; i++)
            {
                txtReciept.Text += "         " + start[i].qty + "\t         " + start[i].name + "\t\t" + start[i].price + "\n\t";
            }
            Deals dealss = new Deals();
            
            for (int i = 0; i < dealss.countdeal; i++)
            {
                txtReciept.Text += "         " + "1" + "\t         " + dealss.dealarr[i].name + "\t\t" + dealss.dealarr[i].price + "\n\t";
            }            
            txtReciept.Text += "\n " +
                "\n                                                                                        " +
                "\n                                                                                        " +
                "Total Price" + "\t\t       " + totalprice + "\n" +
                "\n                                                                                        " +
                "\n                                                                                        " +
                "\n                                                                                        " +
                "\t\t          Thank You";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBurgerPrice.Text = null;
            txtPizzaPrice.Text = null;
            txtRollPrice.Text = null;
            txtSaladPrice.Text = null;
            txtStarterPrice.Text = null;
            txtTotalPrice.Text = null;

            txtQtyBurger.Text = null;
            txtPizza.Text = null;
            txtQTYStarters.Text = null;
            txtRoll.Text = null;
            txtSalad.Text = null;

            comboBurger.Text = null;
            comboPizza.Text = null;
            comboRoll.Text = null;
            comboStarters.Text = null;
            comboSalad.Text = null;

            rbLarge.Checked = false;
            rbMedium.Checked = false;
            rbSmall.Checked = false;

            txtReciept.Text = null;

            pitza = null;
            start = null;
            salad = null;
            roll = null;
            burg = null;


        }
    }
}
