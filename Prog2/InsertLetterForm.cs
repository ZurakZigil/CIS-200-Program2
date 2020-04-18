// Program 2
// CIS 200-01
// By: M9888
// Due: 10/21/2019

// File: InsertLetterForm.cs
// This Windows Form allows us to create new letters.

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class InsertLetterForm : Form
    {
        private List<Address> addressList; // lsit of address

        // Precondition:  None
        // Postcondition: form for letter creation is initialized as well as addresses
        public InsertLetterForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;
        }


        // Precondition:  None
        // Postcondition: Addresses are loaded into the comboboxes
        public void InsertLetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                comboBoxOriginAddress.Items.Add($"{a.Name}: {a.Address1}"); //adds items to origin drop down
                comboBoxDestAddress.Items.Add($"{a.Name}: {a.Address1}"); //adds items to destination drop down
            }
        }


        // Origin Address      -----------------------------------------------------------------     1

        internal int OriginAddressInput
        {
            // Precondition:  None
            // Postcondition: ZipInput is returned
            get => comboBoxOriginAddress.SelectedIndex;

            // Precondition:  None
            // Postcondition: ZipInput is set to specified value
            set => comboBoxOriginAddress.SelectedIndex = value;
        }

        private void comboBoxOriginAddress_Validating(object sender, CancelEventArgs e)
        {
            string origin;
            bool valid = true; // bool for testing

            if (comboBoxOriginAddress.SelectedIndex == -1) // if they have not selected an item
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                valid = false;
            }
            else if (comboBoxDestAddress.SelectedIndex == comboBoxOriginAddress.SelectedIndex) valid = false; // if the two addresses are matching
            else origin = comboBoxOriginAddress.Text;

            if (!valid)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                comboBoxOriginAddress.SelectAll(); // Select all text to ease correction
                ErrorLetter.SetError(comboBoxOriginAddress, "Invalid Origin Address");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void comboBoxOriginAddress_Validated(object sender, EventArgs e)
        {
            ErrorLetter.SetError(comboBoxOriginAddress, ""); // Clears error message
        }


        // Destination Address      -----------------------------------------------------------------     2

        internal int destinationAddressInput
        {
            // Precondition:  None
            // Postcondition: ZipInput is returned
            get => comboBoxDestAddress.SelectedIndex;

            // Precondition:  None
            // Postcondition: ZipInput is set to specified value
            set => comboBoxDestAddress.SelectedIndex = value;
        }

        private void comboBoxDestAddress_Validating(object sender, CancelEventArgs e)
        {
            string dest;
            bool valid = true; // bool for tesing

            if (comboBoxDestAddress.SelectedIndex == -1) // if they have not selected an item
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                valid = false;
            }
            else if (comboBoxDestAddress.SelectedIndex == comboBoxOriginAddress.SelectedIndex) valid = false; // if the two addresses are matching
            else dest = comboBoxDestAddress.Text;

            if (!valid)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                comboBoxDestAddress.SelectAll(); // Select all text to ease correction
                ErrorLetter.SetError(comboBoxDestAddress, "Invalid Destination Address");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void comboBoxDestAddress_Validated(object sender, EventArgs e)
        {
            ErrorLetter.SetError(comboBoxDestAddress, ""); // Clears error message
        }


        // Cost      ----------------------------------------------------------------------------------     3

        internal string CostInput
        {
            // Precondition:  None
            // Postcondition: ZipInput is returned
            get => txtCost.Text;

            // Precondition:  None
            // Postcondition: ZipInput is set to specified value
            set => txtCost.Text = value;
        }

        // Precondition:  cost will need to be greater than 0
        // Postcondition: cost has been checked to meet preconditions
        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            decimal cost;
            bool valid = true; // bool for testing

            int MIN_COST = 0; // minimum cost constant

            if (!decimal.TryParse(txtCost.Text, out cost)) valid = false;
            else if (cost < MIN_COST ) valid = false;

            if (!valid)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                txtCost.SelectAll(); // Select all text to ease correction
                ErrorLetter.SetError(txtCost, "Invalid Zip");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void txtCost_Validated(object sender, EventArgs e)
        {
            ErrorLetter.SetError(txtCost, ""); // Clears error message
        }

        // --------------------------------------------------------------------------------------------

        // Precondition:  User has initiated click on btnCancel
        // Postcondition: If left-click, InputBox is dismissed with Cancel result
        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User has initiated click on btnEnter
        // Postcondition: If all controls on form validate, InputBox is dismissed with OK result
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
