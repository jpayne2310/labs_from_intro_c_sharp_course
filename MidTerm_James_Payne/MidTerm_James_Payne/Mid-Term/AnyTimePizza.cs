using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mid_Term
{
    public partial class AnyTimePizza : Form
    {
        public AnyTimePizza()
        {
            InitializeComponent();
        }
        //Variables Declared
        string order_type, pizza_size, pizza_topping;
        double pizza_cost, topping_cost;
        int order_number = 1;

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
            pizza_topping += " Pepperoni";
            topping_cost += .5;
        }

        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Sausage";
            topping_cost += .5;
        }

        private void cbMeatball_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Meatball";
            topping_cost += .5;
        }

        private void cbHam_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Ham";
            topping_cost += .5;
        }

        private void cbPeppers_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Peppers";
            topping_cost += .5;
        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Onions";
            topping_cost += .5;
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Olives";
            topping_cost += .5;
        }

        private void cbSpinach_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Spinach";
            topping_cost += .5;
        }

        private void cbPineapple_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Pineapple";
            topping_cost += .5;
        }

        private void cbBBQ_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " BBQ Sauce";
            topping_cost += .5;
        }

        private void cbXCheese_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Xtra Cheese";
            topping_cost += .5;
        }

        private void cbSplit_CheckedChanged(object sender, EventArgs e)
        {
            pizza_topping += " Split";
            topping_cost += .5;
        }



        //Output Order
        //Validate Required Information
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

                    lstbTotalCost.Items.Add(pizza_size + " Pizza " + pizza_topping);

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
            //ClearCheckBoxes(); -a work in progress

            //clears previous toppings
            pizza_topping = "";
            
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

    }
   
}
