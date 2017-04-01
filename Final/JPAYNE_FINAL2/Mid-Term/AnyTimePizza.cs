using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mid_Term
{
    public partial class AnyTimePizza : Form
    {
        //list strings declared for later functions
        List<string> ord_typ = new List<string>();
        List<string> pz_sz = new List<string>();
        List<string> pep = new List<string>();
        List<string> sau = new List<string>();
        List<string> mtb = new List<string>();
        List<string> ham = new List<string>();
        List<string> ppr = new List<string>();
        List<string> oni = new List<string>();
        List<string> olv = new List<string>();
        List<string> spg = new List<string>();
        List<string> pin = new List<string>();
        List<string> bbq = new List<string>();
        List<string> xch = new List<string>();
        List<string> slp = new List<string>();
        List<string> fname = new List<string>();
        List<string> lname = new List<string>();
        int Index;

        public AnyTimePizza()
        {
            InitializeComponent();
            Index = 0;
            FillList("orders.csv", ord_typ, pz_sz, pep, sau, mtb, ham, ppr,
                oni, olv, spg, pin, bbq, xch, slp, fname, lname);
        }
        //Variables Declared
        string order_type, pizza_size, pizza_topping, my_orders;
        double pizza_cost, topping_cost;
        int order_number = 1; 
        string Roni, Sauage, Meatball, Ham, Peppers, Onions, Olives, Spinach,
            Pineapple, BBQ, Xcheese, Split;
        string savelocate = "orders.csv";
        string[] stuff = new string[20];

        //Order Types
        private void radioPickup_CheckedChanged(object sender, EventArgs e)
        {
            order_type = "Pickup  ";
        }

        private void radioDelivery_CheckedChanged(object sender, EventArgs e)
        {
            order_type = "Delivery";
        }

        private void radioWalkIn_CheckedChanged(object sender, EventArgs e)
        {
            order_type = "Walk In";
        }


        //Pizza Sizes Assigned
        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            pizza_size = "Small";
            pizza_cost = 7;
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            pizza_size = "Medium";
            pizza_cost = 10;
        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            pizza_size = "Large";
            pizza_cost = 12;
        }


        //Pizza Topping Assigned
        private void cbRoni_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Roni != "")
            {
                Roni = "";
            }
            else
            {
                Roni = " Pepperoni";
            }
        }

        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Sauage != "")
            {
                Sauage = "";
            }
            else
            {
                Sauage = " Sauage";
            }
        }

        private void cbMeatball_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Meatball != "") Meatball = "";
            else Meatball = " Meatball";
        }
        private void cbHam_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Ham != "")
            {
                Ham = "";
            }
            else
            {
                Ham = " Ham";
            }
        }

        private void cbPeppers_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Peppers != "")
            {
                Peppers = "";
            }
            else
            {
                Peppers = " Peppers";
            }
        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Onions != "")
            {
                Onions = "";
            }
            else
            {
                Onions = " Onions";
            }
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Olives != "")
            {
                Olives = "";
            }
            else
            {
                Olives = " Olives";
            }
        }

        private void cbSpinach_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Spinach != "")
            {
                Spinach = "";
            }
            else
            {
                Spinach = " Spinach";
            }
        }

        private void cbPineapple_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Pineapple != "")
            {
                Pineapple = "";
            }
            else
            {
                Pineapple = " Pineapple";
            }
        }

        private void cbBBQ_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (BBQ != "")
            {
                BBQ = "";
            }
            else
            {
                BBQ = " BBQ Sauce";
            }
        }

        private void cbXCheese_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Xcheese != "")
            {
                Xcheese = "";
            }
            else
            {
                Xcheese = " Xtra Cheese";
            }
        }

        private void cbSplit_CheckedChanged(object sender, EventArgs e)
        {
            topping_cost += .5;
            if (Split != "")
            {
                Split = "";
            }
            else
            {
                Split = " Spinach";
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            txtFeedback.Text = "";
            bool Isvalid = true;

            //Make Sure That One of the Name Fields is Filled In
            if (!MidCheck.FilledIn(txtFname.Text) && !MidCheck.FilledIn(txtLname.Text))
            {
                txtFeedback.Text += "At least one of the Name Fields is required\t\t";
                Isvalid = false;
            }


            //Output Format For Order Type Pickup
            if (order_type == "Pickup  ")
            {
                if (!MidCheck.FilledIn(txtPhone.Text))
                {
                    txtFeedback.Text += "Phone Number is required\t\t";
                    Isvalid = false;
                }
                //Check Phone Number Format if Needed
                if (!MidCheck.MinRequirement(txtPhone.Text, 7))
                {
                    txtFeedback.Text += "Phone Number must have at least 7 characters\t\t\t";
                    Isvalid = false;
                }
                //Check Email Format if Entered
                if (!MidCheck.IsEmailValid(txtEmail.Text))
                {
                    txtFeedback.Text += "Email format incorrect.  Please re-enter\n";
                    Isvalid = false;
                }
            }

            //Output Format For Order Type Delivery
            if (order_type == "Delivery")
            {
                if (!MidCheck.FilledIn(txtStreet1.Text))
                {
                    txtFeedback.Text += "Street is required\t\t";
                    Isvalid = false;
                }
                if (!MidCheck.FilledIn(txtPhone.Text))
                {
                    txtFeedback.Text += "Phone Number is required\t\t";
                    Isvalid = false;
                }
                //Check Phone Number Format if Needed
                if (!MidCheck.MinRequirement(txtPhone.Text, 7))
                {
                    txtFeedback.Text += "Phone Number must have at least 7 characters\t\t\t";
                    Isvalid = false;
                }
                //Check Email Format if Entered
                if (!MidCheck.IsEmailValid(txtEmail.Text))
                {
                    txtFeedback.Text += "Email format incorrect.  Please re-enter\n";
                    Isvalid = false;
                }
            }
            
            //Format List Box Start
            lstbTotalCost.Items.Add("");

            //Output Order If All Requirements Were Met
                if (Isvalid)
                {
                    lstbTotalCost.Items.Add(dtpPizza.Value);

                    lstbTotalCost.Items.Add("Order Type: " + order_type + "\tOrder Number: " + order_number);

                    lstbTotalCost.Items.Add(pizza_size + " Pizza " + Roni + Sauage + Meatball + Ham + Peppers +
                        Onions + Olives + Spinach + Pineapple + BBQ + Xcheese + Split);

                    lstbTotalCost.Items.Add("Total Cost of Pizza " + (pizza_cost + topping_cost).ToString("c"));

                    lstbTotalCost.Items.Add("Customer Name: " + txtFname.Text + " " + txtLname.Text);

                    order_number++;

                        if (order_type == "Delivery")
                        {
                                lstbTotalCost.Items.Add("Deliver to: " + txtStreet1.Text + " " + txtStreet2.Text + ", " +
                                    cmbCity.SelectedItem + " ," + cmbState.SelectedItem);

                                lstbTotalCost.Items.Add("Contact Number: " + txtPhone.Text + " E-Mail: " + txtEmail.Text);
                        
                        }
                        
                        else if (order_type == "Pickup  ")
                        {
                            if(txtEmail.Text == "")
                            {
                                txtEmail.Text = "N/A";
                            }
                            
                            
                              lstbTotalCost.Items.Add("Contact Number: " + txtPhone.Text + " E-Mail: " + txtEmail.Text);
                            
                        }
                        // format for output to coincide with delete order event
                        else
                        {
                            lstbTotalCost.Items.Add("  ");
                            lstbTotalCost.Items.Add("  ");
                        }
                        my_orders = order_type + "," + pizza_size + "," + Roni + "," + Sauage + "," + Meatball + "," +
                            Ham + "," + Peppers + "," + Onions + "," + Olives + "," + Spinach + "," + Pineapple + "," +
                            BBQ + "," + Xcheese + "," + Split + "," + txtFname.Text + "," + txtLname.Text;
                        //write order to data file
                        fileIO.writeFile(savelocate, my_orders);

                }


        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        { 
            //clears all text boxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }

            //resets all radio buttons for Order Type
            foreach (Control c in gbOrderType.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }

            //resets all radio buttons for Order Type
            foreach (Control c in gbPizzaSize.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }

            //resets all checkboxes for Pizza Toppings
            foreach (Control c in gbTopping.Controls)
            {
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
            }

            //clears previous toppings
            Roni = ""; 
            Sauage = ""; 
            Meatball = "";                
            Ham = ""; 
            Peppers = ""; 
            Onions = ""; 
            Olives = ""; 
            Spinach = ""; 
            Pineapple = "";                
            BBQ = ""; 
            Xcheese = "";
            Split = "";  
            
            //reset pizza_cost
            pizza_cost = 0;

            //reset topping_cost
            topping_cost = 0;

            //reset the date/time
             dtpPizza.Value = DateTime.Now;

        }

        private void AnyTimePizza_Load(object sender, EventArgs e)
        {
            //list city options
            cmbCity.Items.Add("Cumberland");
            cmbCity.Items.Add("Lincoln");
            cmbCity.Items.Add("Smithfield");

            //default city
            cmbCity.SelectedIndex = 1;

            //list state options
            cmbState.Items.Add("CT");
            cmbState.Items.Add("MA");
            cmbState.Items.Add("RI");

            //default city
            cmbState.SelectedIndex = 2;

            //desired starting form view

            //clears all text boxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }

            //resets all radio buttons for Order Type
            foreach (Control c in gbOrderType.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }

            //resets all radio buttons for Order Type
            foreach (Control c in gbPizzaSize.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }

            //resets all checkboxes for Pizza Toppings
            foreach (Control c in gbTopping.Controls)
            {
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
            }
        }



        //Remove Oldest Order
        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; ++i)
            {
                //Add a Empty String If Needed
                //To Keep an Exception From Occuring
                while (lstbTotalCost.Items.Count < 9)
                {
                    lstbTotalCost.Items.Add("  ");
                }

                lstbTotalCost.Items.RemoveAt(1);
            }
        }



        //Add a Pizza to Current Customer
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            //resets all radio buttons for Order Type
            foreach (Control c in gbPizzaSize.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }

            //resets all checkboxes for Pizza Toppings
            foreach (Control c in gbTopping.Controls)
            {
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
            }

            //clears previous toppings
            pizza_topping = "";

            //reset pizza_cost
            pizza_cost = 0;

            //reset topping_cost
            topping_cost = 0;

            //reset the date/time
            dtpPizza.Value = DateTime.Now;

            if (txtEmail.Text == "N/A")
            {
                txtEmail.Text = "";
            }
        }


        //Clear All Orders In List Box
        private void btnClearOrders_Click(object sender, EventArgs e)

        {
            lstbTotalCost.Items.Clear();
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            //create a string for holding data
            string[] stuff = new string[20];
            //get the data from the file
            stuff = fileIO.readFile(savelocate);
            //display error if one occurs
            if (stuff[0].Contains("ERROR:"))
            {
                txtFeedback.Text = stuff[0];
            }
            else
            {
                int index = 0;
                while (index < fname.Count)
                {
                    lstbTotalCost.Items.Add(stuff[index]);
                    index++;
                }
            }

        }

        public void FillMyForm(int index)
        {
            
            //resets all checkboxes for Pizza Toppings
            foreach (Control c in gbTopping.Controls)
            {
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
            }
            //clears previous toppings
            Roni = "";
            Sauage = "";
            Meatball = "";
            Ham = "";
            Peppers = "";
            Onions = "";
            Olives = "";
            Spinach = "";
            Pineapple = "";
            BBQ = "";
            Xcheese = "";
            Split = ""; 
            
            //set radio buttons for form output
           if (ord_typ[index] == "Pickup  ")
            {
                radioPickup.Checked = true;
            }
            else if (ord_typ[index] == "Delivery")
            {
                radioDelivery.Checked = true;
            }
            else if (ord_typ[index] == "Walk In")
            {
                radioWalkIn.Checked = true;
            }
           if (pz_sz[index] == "Small")
           {
               radioSmall.Checked = true;
           }
           else if (pz_sz[index] == "Medium")
           {
               radioMedium.Checked = true;
           }
           else if (pz_sz[index] == "Large")
           {
               radioLarge.Checked = true;
           }

           //include any and all checkboxes for form output
           if (pep[index] == " Pepproni" )
           {
               cbRoni.Checked = true;
           }
           if (sau[index] == " Sauage")
           {
               cbSausage.Checked = true;
           }
           if (mtb[index] == " Meatball")
           {
               cbMeatball.Checked = true;
           }
           if (ham[index] == " Ham")
           {
               cbHam.Checked = true;
           }
            if (ppr[index] == " Peppers")
           {
               cbPeppers.Checked = true;
           }
            if (oni[index] == " Onions")
           {
               cbOnions.Checked = true;
           }
           if (olv[index] == " Olives")
           {
               cbOlives.Checked = true;
            }
            if (spg[index] == " Spinach")
           {
               cbSpinach.Checked = true;
           }
            if (pin[index] == " Pineapple")
           {
               cbPineapple.Checked = true;
           }
            if (bbq[index] == " BBQ Sauce")
           {
               cbBBQ.Checked = true;
           }
            if (xch[index] == " Xtra Cheese")
           {
               cbXCheese.Checked = true;
           }
            if (slp[index] == " Slpit")
           {
               cbSplit.Checked = true;
           }

            //fill in name fields
            txtFname.Text = fname[index];
            txtLname.Text = lname[index];

            //reset pizza topping variable

        }

        public void FillList(string myfilename, List<string> order_type, List<string> pizza_size, 
            List<string> pep, List<string> sau, List<string> mtb, List<string> ham, List<string> ppr, 
            List<string> oni, List<string> olv, List<string> spg, List<string> pin, List<string> bbq, 
            List<string> xch, List<string> slp, List<string> fname, List<string> lname)
        {
            //clear fields
            order_type.Clear();
            pizza_size.Clear();
            pep.Clear();
            sau.Clear();
            mtb.Clear();
            ham.Clear();
            ppr.Clear();
            oni.Clear();
            olv.Clear();
            spg.Clear();
            pin.Clear();
            bbq.Clear();
            xch.Clear();
            slp.Clear();
            fname.Clear();
            lname.Clear();

            //declare steamreader object
            StreamReader sr;
            try
            {
                //create object and set file and how file is to be handled
                sr = new StreamReader(File.Open(myfilename, FileMode.Open));

                try
                {
                    while (sr.Peek() != -1)
                    {
                        //read file from top to bottom and store it in a string variable
                        string row = sr.ReadLine();
                        string[] stuff = row.Split(',');
                        //load delimited strings into individual arrays
                        order_type.Add(stuff[0]);
                        pizza_size.Add(stuff[1]);
                        pep.Add(stuff[2]);
                        sau.Add(stuff[3]);
                        mtb.Add(stuff[4]);
                        ham.Add(stuff[5]);
                        ppr.Add(stuff[6]);
                        oni.Add(stuff[7]);
                        olv.Add(stuff[8]);
                        spg.Add(stuff[9]);
                        pin.Add(stuff[10]);
                        bbq.Add(stuff[11]);
                        xch.Add(stuff[12]);
                        slp.Add(stuff[13]);
                        fname.Add(stuff[14]);
                        lname.Add(stuff[15]);
                    }
                }

                catch (Exception exc)
                {
                    stuff[0] = "ERROR: " + exc.Message;  //store error message
                }

                finally
                {
                    sr.Close(); //close the text file with or without errors
                }
            }
            catch (Exception exc)
            {
                stuff[0] = "ERROR: " + exc.Message;  //store error message
            }
            FillMyForm(Index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //access next order
            Index++;

            //keep from overextending
            if (Index >= fname.Count)
            {
                Index = fname.Count - 1;
            }
            FillMyForm(Index);

            //clear list box
            lstbTotalCost.Items.Clear();

            //display earlier sale
            lstbTotalCost.Items.Add("Order Type: " + order_type);
            lstbTotalCost.Items.Add(pizza_size + " Pizza " + Roni + Sauage + Meatball + Ham +
                Peppers + Onions + Olives + Spinach + Pineapple + BBQ + Xcheese + Split);
            lstbTotalCost.Items.Add("Customer Name: " + txtFname.Text + " " + txtLname.Text);

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //previous next order
            Index--;
            //keep from overextending
            if (Index < 0 )
            {
                Index = 0;
            }
            FillMyForm(Index);

            //clear listbox
            lstbTotalCost.Items.Clear();

            //display earlier sale
            lstbTotalCost.Items.Add("Order Type: " + order_type);
            lstbTotalCost.Items.Add(pizza_size + " Pizza " + Roni + Sauage + Meatball + Ham +
                Peppers + Onions + Olives + Spinach + Pineapple + BBQ + Xcheese + Split);
            lstbTotalCost.Items.Add("Customer Name: " + txtFname.Text + " " + txtLname.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update current variables
            ord_typ[Index] = order_type;
            pz_sz[Index] = pizza_size;
            pep[Index] = Roni;
            sau[Index] = Sauage;
            mtb[Index] = Meatball;
            ham[Index] = Ham;
            ppr[Index] = Peppers;
            oni[Index] = Onions;
            olv[Index] = Olives;
            spg[Index] = Spinach;
            pin[Index] = Pineapple;
            bbq[Index] = BBQ;
            xch[Index] = Xcheese;
            slp[Index] = Split;
            fname[Index] = txtFname.Text;
            lname[Index] = txtLname.Text;

            //call function to overwrite variables
            txtFeedback.Text = fileIO.UpdateFile(savelocate, ord_typ, pz_sz, pep, sau, mtb, ham, 
                ppr, oni, olv, spg, pin, bbq, xch, slp, fname, lname);
        }

        private void lstbTotalCost_MouseDoubleClick(object sender, MouseEventArgs e)
        {  
            //choose oeder from list box

            //get index number for double-clicked order
            int index = this.lstbTotalCost.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //fill the for with doouble-clicked selection
                FillMyForm(index);
            }
        }


    }
   
}
