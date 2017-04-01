 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace FormLayout
{
    public partial class FormLayout : Form
    {
        public FormLayout()
        {
            InitializeComponent();
        }

        string salutation, myContacts;

        //set default save location
        string saveLocate = "Contacts.csv"; 

        private void Form1_Load(object sender, EventArgs e)
        {
            //options for Relationship
            cmbRelationship.Items.Add("Choose Relationship...");
            cmbRelationship.Items.Add("Family");
            cmbRelationship.Items.Add("Friends");
            cmbRelationship.Items.Add("Co-Workers");
            cmbRelationship.Items.Add("Student Peers");

            //defaults for combo boxes set
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
            txtFeedBack.Text = "";                      //Clears out feedback field
            bool IsValid = true;

            //checks name requirement
            if (!myValidate.FilledIn(txtFName.Text) && !myValidate.FilledIn(txtLName.Text))
            {
                txtFeedBack.Text += "At least one of the name fields required\n";
                IsValid = false;
            }

            //check to see if a state was selected
            if (myValidate.IsItemSeleced(cmbState.SelectedIndex))
            {
                txtFeedBack.Text += "State selection is required\n";
                IsValid = false;
            }
           
            //check for valid zip code
            if (!myValidate.LengthRequirement(txtZip.Text, 5))
            {
                txtFeedBack.Text += "Zip code has to be five numbers\n";
                IsValid = false;
            }

            //check for valid email format        
            if (!myValidate.IsEmailValid(txtEmail.Text))
            {
                txtFeedBack.Text += "Email format incorrect. Please re-enter.\n";
                IsValid = false;
            }
            //fill in blank email field
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "N/A";
            }

            //check minimum length of contact numbers
            if (!myValidate.MinRequirement(txtHomePhone.Text, 7) || !myValidate.MinRequirement(txtWorkPhone.Text, 7) || !myValidate.MinRequirement(txtCellPhone.Text, 7))
            {
                txtFeedBack.Text += "Must Phone Number must have at least seven characters\n";
                IsValid = false;
            }
                    //fills in blank contact number fields
                    if (txtHomePhone.Text == "")
                    {
                        txtHomePhone.Text = "N/A";
                    }
                    if (txtWorkPhone.Text == "")
                    {
                        txtWorkPhone.Text = "N/A";
                    }
                    if (txtCellPhone.Text == "")
                    {
                        txtCellPhone.Text = "N/A";
                    }


            /*this code was just used to shou the value of having a validation library
            //check to see if a relationship was selected
                    if (myValidate.IsItemSeleced(cmbRelationship.SelectedIndex))
            {
                txtFeedBack.Text += "You must select a relationship\n.";
                IsValid = false;
            }
            */
                        if (IsValid)
                        {
                            //output split into three lines for a more readable list box format
                            lbContacts.Items.Add(salutation + txtFName.Text + " " + txtLName.Text + " " +
                            txtStreet1.Text + " " + txtStreet2.Text + " " + txtCity.Text + ", "
                            + cmbState.SelectedItem + " " + txtZip.Text);

                            lbContacts.Items.Add("Email: " + txtEmail.Text + "   Home:" + txtHomePhone.Text + "   Work:"
                            + txtWorkPhone.Text + "   Cell:" + txtCellPhone.Text);

                            lbContacts.Items.Add("DOB: " + dtpBirthday.Text +
                            "   Anniversary: " + dtbAnniversary.Text + "  Relationship: " + cmbRelationship.SelectedItem);

                            //remove field place holders for a more compatible data format
                            if (txtEmail.Text == "N/A")
                            {
                                txtEmail.Text = "";
                            }
                            if (txtHomePhone.Text == "N/A")
                            {
                                txtHomePhone.Text = "";
                            }
                            if (txtWorkPhone.Text == "N/A")
                            {
                                txtWorkPhone.Text = "";
                            }
                            if (txtCellPhone.Text == "N/A")
                            {
                                txtCellPhone.Text = "";
                            }
                            //prepare data for external file
                            myContacts =  salutation + "," + txtFName.Text + "," + txtLName.Text + "," + txtStreet1.Text + "," + 
                            txtStreet2.Text + "," + txtCity.Text + ", " + cmbState.SelectedItem + "," + txtZip.Text + "," + 
                            txtEmail.Text + "," + txtHomePhone.Text + "," + txtWorkPhone.Text + "," + txtCellPhone.Text + "," +
                            dtpBirthday.Text + "," + dtbAnniversary.Text + "," + cmbRelationship.SelectedItem;

                            //send data to external file
                            fileIO.writeFile(saveLocate, myContacts);
                        }

        }

        //fully functional radio buttons
        private void radioMr_CheckedChanged(object sender, EventArgs e)
        {
            salutation = "Mr.";
        }

        private void radioMrs_CheckedChanged(object sender, EventArgs e)
        {
            salutation = "Mrs.";
        }

        private void radioMs_CheckedChanged(object sender, EventArgs e)
        {
            salutation = "Ms.";
        }

        //allow user to select save location
        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"c:\";
            saveFileDialog1.Title = "Save Text Files";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            //store value of select location if used
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveLocate = saveFileDialog1.FileName;
            }
        }

        //output contacts listed in individual lines
        private void btnReadLine_Click(object sender, EventArgs e)
        {
            //Creating a string for holding data/feedback
            string[] stuff = new string[20];
            //Get the data from the file
            stuff = fileIO.readFile(saveLocate);
            //If an error occurs....display in Label
            if (stuff[0].Contains("ERROR:"))
            {
                txtFeedBack.Text = stuff[0];
            }
            else  //else....display data in textbox
            {
                int index = 0;
                while (index < 4)
                {
                    lbContacts.Items.Add(stuff[index]);
                    index++;
                }
            }

        }

        //output specified fields
        private void btnReadField_Click(object sender, EventArgs e)
        {
            //Creating a string for holding data/feedback
            string[] stuff = new string[20];
            //Get the data from the file
            stuff = fileIO.readFile(saveLocate);
            //If an error occurs....display in Label
            if (stuff[0].Contains("ERROR:"))
            {
                txtFeedBack.Text = stuff[0];
            }
            else  //else....display data in textbox
            {
                int index = 0;
                while (index < 4)
                {
                    //set values of field separaters
                    int atlocation = (stuff[index].IndexOf(",")) + 1;
                    int atlocation2 = ((stuff[index].IndexOf(",", atlocation))-atlocation);
                    int atlocation3 = (stuff[index].IndexOf(",", (atlocation + atlocation2)));
                    int atlocation4 = (stuff[index].IndexOf(",", (atlocation + atlocation3)));
                    int atlocation5 = (stuff[index].IndexOf(",", (atlocation + atlocation4)));
                    int atlocation6 = (stuff[index].IndexOf(",", (atlocation + atlocation5)));
                    int atlocation7 = (stuff[index].IndexOf(",", (atlocation + atlocation6)));
                    int atlocation8 = (stuff[index].IndexOf(",", (atlocation + atlocation7)));
                    int atlocation9 = (stuff[index].IndexOf(",", (atlocation + atlocation8)));
                    
                    
                    lbContacts.Items.Add(stuff[index].Substring(atlocation, atlocation2) + " " +
                        stuff[index].Substring((atlocation3 + 1),(atlocation4 - (atlocation3+1))) +
                        " " + stuff[index].Substring((atlocation8 + 1),(atlocation9 - (atlocation8 + 1))));
                    index++;
                }
            }

        }

        //output specified fields...simplified
        private void btnsplitIt_Click(object sender, EventArgs e)
        {
            //Creating a string for holding data/feedback
            string[] stuff = new string[20];
            //Get the data from the file
            stuff = fileIO.readFile(saveLocate);
            //If an error occurs....display in Label
            if (stuff[0].Contains("ERROR:"))
            {
                txtFeedBack.Text = stuff[0];
            }
            else  //else....display data in textbox
            {
                
                int index = 0;
                while (index < 4)
                {
                    string[] slice = (stuff[index].Split(','));
                    lbContacts.Items.Add(slice[1] + " " + slice[2] + " " + slice[8]);
                    index++;
                }
            }
        }





    }

}
