// Program 2
// CIS 200-01
// By: M9888
// Due: 10/21/2019

// File: Prog2Form.cs
// This Windows Form allows us to create new addresses we can use with our Parcel objects.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class InsertAddressForm : Form
    {

        // Precondition:  None
        // Postcondition: form for address creation is initialized as well as the lsit of states
        public InsertAddressForm()
        {
            InitializeComponent();

            StateList();
        }

        // Name      -----------------------------------------------------------------     1
        internal string NameInput
        {
            // Precondition:  None
            // Postcondition: NameInput is returned
            get => txtName.Text;

            // Precondition:  None
            // Postcondition: NameInput is set to specified value
            set => txtName.Text = value; 
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string name; 
            bool valid = true; // bool for testing

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                valid = false;
            }
            else name = txtName.Text;

            if (!valid)
            {
                e.Cancel = true;
                txtName.SelectAll(); // Select all text to ease correction
                ErrorAddress.SetError(txtName, "Invalid Name");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void txtName_Validated(object sender, EventArgs e)
        {
            ErrorAddress.SetError(txtName, ""); // Clears error message
        }



        // Address1      -----------------------------------------------------------------     2
        internal string AddressOneInput
        {
            // Precondition:  None
            // Postcondition: AddressOneInput is returned
            get => txtAddress1.Text;

            // Precondition:  None
            // Postcondition: AddressOneInput is set to specified value
            set => txtAddress1.Text = value; 
        }

        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            string address;
            bool valid = true; // bool for testing

            if (string.IsNullOrWhiteSpace(txtAddress1.Text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                valid = false;
            }
            else address = txtAddress1.Text;

            if (!valid)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                txtAddress1.SelectAll();// Select all text to ease correction 
                ErrorAddress.SetError(txtAddress1, "Invalid Address 1");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void txtAddress1_Validated(object sender, EventArgs e)
        {
            ErrorAddress.SetError(txtAddress1, ""); // Clears error message
        }



        // Address2     -----------------------------------------------------------------     3
        internal string AddressTwoInput
        {
            // Precondition:  None
            // Postcondition: AddressTwoInput is returned
            get => txtAddress2.Text;

            // Precondition:  None
            // Postcondition: AddressTwoInput is set to specified value
            set => txtAddress2.Text = value; 
        }

        private void txtAddress2_Validating(object sender, CancelEventArgs e) { }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void txtAddress2_Validated(object sender, EventArgs e)
        {
            ErrorAddress.SetError(txtAddress2, ""); // Clears error message
        }



        // City     -----------------------------------------------------------------     4
        internal string CityInput
        {
            // Precondition:  None
            // Postcondition: CityInput is returned
            get => txtCity.Text;

            // Precondition:  None
            // Postcondition: CityInput is set to specified value
            set => txtCity.Text = value; 
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            string city;
            bool valid = true; // bool for testing

            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                valid = false;
            }
            else city = txtCity.Text;

            if (!valid) // error message if not valid
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                txtCity.SelectAll(); // Select all text to ease correction
                ErrorAddress.SetError(txtCity, "Invalid City");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void txtCity_Validated(object sender, EventArgs e)
        {
            ErrorAddress.SetError(txtCity, ""); // Clears error message
        }



        // State      -----------------------------------------------------------------     5

        public void StateList()
        {
            // an array of possible states to select from
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };

            // loop to list off the array of states
            foreach (string state in states)
            {
                comboBoxState.Items.Add(state);
            }
        }

        internal string StateInput
        {
            // Precondition:  None
            // Postcondition: ZipInput is returned
            get => comboBoxState.Text;

            // Precondition:  None
            // Postcondition: ZipInput is set to specified value
            set => comboBoxState.Text = value; 
        }

        private void comboBoxState_Validating(object sender, CancelEventArgs e)
        {
            string state;
            bool valid = true; // bool for testing

            if (comboBoxState.SelectedIndex == -1)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                valid = false;
            }
            else state = comboBoxState.Text;

            if (!valid) // error message if not valid
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                txtName.SelectAll(); // Select all text to ease correctionn
                ErrorAddress.SetError(comboBoxState, "Invalid State");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void comboBoxState_Validated(object sender, EventArgs e)
        {
            ErrorAddress.SetError(comboBoxState, ""); // Clears error message
        }

        // Zip      -----------------------------------------------------------------     6
        internal string ZipInput
        {
            // Precondition:  None
            // Postcondition: ZipInput is returned
            get => txtZip.Text;

            // Precondition:  None
            // Postcondition: ZipInput is set to specified value
            set => txtZip.Text = value; 
        }

        private void txtZip_Validating(object sender, CancelEventArgs e)
        {
            int zip;
            bool valid = true; // bool for testing

            int MIN_ZIP = 0; int MAX_ZIP = 99999; // limits for valid zipcodes

            if (!int.TryParse(txtZip.Text, out zip)) valid = false; // error if failed aprse
            else if (zip <= MIN_ZIP || zip > MAX_ZIP) valid = false; // error if out of bounds

            if (!valid) // error message if not valid
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event
                txtZip.SelectAll(); // Select all text to ease correction
                ErrorAddress.SetError(txtZip, "Invalid Zip");
            }
        }

        // Precondition:  Validating succeeded
        // Postcondition: Any error message set is cleared
        //                Focus is allowed to change
        private void txtZip_Validated(object sender, EventArgs e)
        {
            ErrorAddress.SetError(txtZip, ""); // Clears error message
        }

        // -----------------------------------------------------------------------------     6

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
