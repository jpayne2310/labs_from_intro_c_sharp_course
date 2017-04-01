using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormLayout
{
    public partial class FormLayout : Form
    {
        public FormLayout()
        {
            InitializeComponent();
        }

        string sal;
        private void Form1_Load(object sender, EventArgs e)
        {
            //options for Relationship
            cmbRelationship.Items.Add("Choose Relationship...");
            cmbRelationship.Items.Add("Family");
            cmbRelationship.Items.Add("Friends");
            cmbRelationship.Items.Add("Co-Workers");
            cmbRelationship.Items.Add("Student Peers");

            cmbRelationship.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {    //looping to clear form items
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                else if (c is ListBox)
                    ((ListBox)c).Items.Clear();

            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {

            if (myValidate.HasBadWords(txtFName.Text))  //this statement is a work in progress
            {                                           //for the next assignment
                lblFeedback.Text = "Has bad words";
            }

            if (txtFName.Text.Length > 0 && txtLName.Text.Length > 0)
            {
                //output split into three lines for a more readable list box format

                lbContacts.Items.Add(sal + txtFName.Text + " " + txtLName.Text + " " +
                txtStreet1.Text + " " + txtStreet2.Text + " " + txtCity.Text + ", "
                + cmbState.SelectedItem + " " + txtZip.Text);

                lbContacts.Items.Add(txtEmail.Text + "  " + txtHomePhone.Text + " " 
                + txtWorkPhone.Text + " " + txtCellPhone.Text);

                lbContacts.Items.Add("DOB: " + dtpBirthday.Value.Date +
                "   Anniversary: " + dtbAnniversary.Value.Date + "  " + cmbRelationship.SelectedItem);
            }
        }

        //fully functional radio buttons
        private void radioMr_CheckedChanged(object sender, EventArgs e)
        {
            sal = "Mr.";
        }

        private void radioMrs_CheckedChanged(object sender, EventArgs e)
        {
            sal = "Mrs.";
        }

        private void radioMs_CheckedChanged(object sender, EventArgs e)
        {
            sal = "Ms.";
        }


    }
}
