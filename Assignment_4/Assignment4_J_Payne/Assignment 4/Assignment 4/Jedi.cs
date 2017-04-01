using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Jedi : Form
    {
        public Jedi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get first three characters of txtLName
            string firstThreeLName = txtLName.Text.Substring(0, 3);

            //Assign the lenth of txtFName to a variable
            int NumberofLetters = txtFName.Text.Length;
            //Use length variable to extract last two characters of FName
            string lastThreeFName = txtFName.Text.Substring((NumberofLetters - 2), 2);

            //Get first two characters of txtMother
            string motherFirstTwo = txtMother.Text.Substring(0, 2);

            //Assign the lenth of txtBirthPlace to a variable
            int birthNumberOfLetters = txtBirthPlace.Text.Length;
            //Use length variable to extract last three characters of txtBirthPlace
            string lastThreeBirth = txtBirthPlace.Text.Substring((birthNumberOfLetters - 3), 3);
            //output Jedi Name using cancatination
            lbJediName.Items.Add("Your Jedi Name is:\n" + firstThreeLName + lastThreeFName 
                + "-" + motherFirstTwo + lastThreeBirth);

            //Inspirational message
            tbNotes.Text = "The Force is Strong in this one!!!";

            //clear out Feedback
            txtFeedBack.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //looping to clear form items
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                else if (c is ListBox)
                    ((ListBox)c).Items.Clear();

                //family crisis intervention 
                tbNotes.Text = "Luke...I am Your Father!!!";
            }
        }


        private void btnXCredit_Click(object sender, EventArgs e)
        {
            tbNotes.Text = "'Luke, \t\t\tI never told you about your mother.  She voted for Trump!!'";
            //check for bad words
            if (myValidate.HasBadWords(tbNotes.Text))
            {
                txtFeedBack.Text += "Now your journey to\n";
                txtFeedBack.Text += "the dark side is complete!";
            }
            //replace bad words if found
            tbNotes.Text = myValidate.Censor(tbNotes.Text);
        }

    }
}
