using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //declaring variables
        double num1, result;
        string operand;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")         //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text = "-";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtLCD.Text.Contains("."))
            {                               //keeps multiple "." from being entered
                txtLCD.Text += ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")          //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")         //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")         //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtLCD.Text == "0")         //clears the 0 holding place if present
            {
                txtLCD.Text = "";
            }
            txtLCD.Text += "9";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //store user input
            if (result == 0)
            //check to see if result has been generated
            {
                if (num1 == 0)
                //check to see if a value is assigned to num1
                {
                    num1 = Convert.ToDouble(txtLCD.Text);
                }               
                else
                {   
                    //takes more values into operation
                    num1 = num1 * Convert.ToDouble(txtLCD.Text);
                }
            }
            else
            {   
                //allows an operation if previous wasn't cleared out
                num1 = Convert.ToDouble(txtLCD.Text);
            }
            //clear the textbox
            txtLCD.Text = "";
            //store the operand
            operand = "*";
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            //store user input
            if (result == 0)
            //check to see if result has been generated
            {
                if (num1 == 0)
                //check to see if a value is assigned to num1
                {
                    num1 = Convert.ToDouble(txtLCD.Text);
                }
                else
                {   
                    //takes more values into operation
                    num1 = num1 / Convert.ToDouble(txtLCD.Text);
                }
            }
            else
            {   
                //allows for another operation after Equals event
                num1 = Convert.ToDouble(txtLCD.Text);
            }
            //clear the textbox
            txtLCD.Text = "";
            //store the operand
            operand = "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //store user input
            if (result == 0)
            //check to see if a result has been generated
            {
                if (num1 == 0)
                //check to see if a value is assigned to num1
                {
                    num1 = Convert.ToDouble(txtLCD.Text);
                }
                else
                {
                    //check to see if result has been generated
                    num1 = num1 + Convert.ToDouble(txtLCD.Text);
                }
            }
            else
            {   //allows for another operation after Equals event
                num1 = Convert.ToDouble(txtLCD.Text);
            }
            //clear the textbox
            txtLCD.Text = "";
            //store the operand
            operand = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //store user input
            if (result == 0)
            //check to see if a result has been generated
            {
                if (num1 == 0)
                //check to see if a value is assigned to num1
                {
                    num1 = Convert.ToDouble(txtLCD.Text);
                }
                else
                {                           
                    //check to see if result has been generated
                    num1 = num1 - Convert.ToDouble(txtLCD.Text);
                }
            }
            else
            {   //allows for another operation after Equals event
                num1 = Convert.ToDouble(txtLCD.Text);
            }
            //clear the textbox
            txtLCD.Text = "";
            //store the operand
            operand = "-";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
                //perform the math
                if (operand == "+")
                {
                    result = num1 + Convert.ToDouble(txtLCD.Text);
                }
                else if (operand == "-")
                {
                    result = num1 - Convert.ToDouble(txtLCD.Text);
                }
                else if (operand == "/")
                {
                    result = num1 / Convert.ToDouble(txtLCD.Text);
                }
                else if (operand == "*")
                {
                    result = num1 * Convert.ToDouble(txtLCD.Text);
                }
                
                //display the result
                {
                    txtLCD.Text = result.ToString();
                }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //have a "0" hold the space
            txtLCD.Text = "0";
            //reset variables
            result = 0;
            num1 = 0;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtLCD.Text);
            //basic squaring operation
            result = num1 * num1;
            //display results
            txtLCD.Text = result.ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtLCD.Text);
            //square root operation
            result = Math.Sqrt(num1);
            //display results
            txtLCD.Text = result.ToString();
        }

    }
}
