// Program 2
// CIS 200-01
// By: M9888
// Due: 10/21/2019

// File: Prog2Form.cs
// This is a Windows Form application designed to start applying an interface to our parcel hierarchy.
// This functionally allows us to use several basic commands in addition create new address and letters.
// We can also display all of these using the controls at the top of the application.

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
    public partial class MainForm : Form
    {
        public UserParcelView upv= new UserParcelView(); //creates a UserParcelView object
        public MainForm()
        {
            InitializeComponent();


            //pre-stored address values for quick testing
            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45", "Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101); // Test Address 4

            upv.AddAddress("Test name", "Test address_1", "Test address_2", "Test city", "Test state", 99999); //Test address 5
            upv.AddAddress("Joe", "123 The Street", "wut", "NYC", "NY", 12345); //Test address 6
            upv.AddAddress("Dr. Wright", "I dont know where you live", "Louisville", "KY", 40217); //Test address 7
            upv.AddAddress("'Ol McDonald", "had a farm", "               eee eye eee eye", "Farmville", "T E X A S", 5); //Test address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(2), 0.50M); // Test Letter 1
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(2), 1.20M); // Test Letter 2
            upv.AddLetter(upv.AddressAt(4), upv.AddressAt(0), 1.70M); // Test Letter 3

            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 5, 10, 1, 100); //Test Groundpackage 1
            upv.AddGroundPackage(upv.AddressAt(0), upv.AddressAt(6), 10, 10, 5, 25); //Test Groundpackage 2

            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(6), 5, 10, 1, 100, 150); //Test Next Day Air Package Heavy
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(6), 5, 10, 100, 49.9, 150); //Test Next Day Air Package Large
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(5), 5, 10, 100, 50, 150); //Test Next Day Air Package Large & Heavy

            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(3), 5, 10, 1, 150, TwoDayAirPackage.Delivery.Saver); //Test Two Day Air Package that is a Saver
            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(2), 5, 10, 1, 75, TwoDayAirPackage.Delivery.Early); //Test Two Day Air Package that is a Early
        }

        // Precondition:  None
        // Postcondition: Information about author and program are displayed
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            string title = "About Page";
            string message = $"Grading ID: M9888{NL}" +
                $"Program 2{NL}" +
                $"10/21/2019 11:59 PM{NL}" +
                $"CIS 200-01{NL}{NL}" +
                $"This is a GUI application that allows us to not only view our addresses and parcels, but also add new addresses and letters. ";
            MessageBox.Show(message, title);
        }

        // Precondition:  None
        // Postcondition: Application is closed
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  None
        // Postcondition: Insert address form is opened and values submited based on user input
        private void BtnInsertAddress_Click(object sender, EventArgs e)
        {
            string name, address1, address2, city, state; // representing the variables in Address
            int zip;                                      // zip in Address

            InsertAddressForm address = new InsertAddressForm(); // The dialog box form
            DialogResult result;                                // Result from dialog - OK/Cancel?
            result = address.ShowDialog();                       // Show dialog box form - modal, waits for OK/Cancel
                                                                 // Even after user dismisses, the form still exists
                                                                 // and can be interacted with using methods/properties

            // fills and submits user created information
            if (result == DialogResult.OK)  // Only update if user chose enter
            {
                name = address.NameInput;
                address1 = address.AddressOneInput;
                address2 = address.AddressTwoInput;
                city = address.CityInput;
                state = address.StateInput;
                zip = Int32.Parse(address.ZipInput);

                upv.AddAddress(name, address1, address2, city, state, zip);
            }

        }

        // Precondition:  None
        // Postcondition: Insert letter form is opened and values submited based on user input
        private void BtnInsertLetter_Click(object sender, EventArgs e)
        {
            Address originAddress, destinationAddress;  // representing the variables in Letter
            decimal cost;                               // cost in Address

            InsertLetterForm letter = new InsertLetterForm(upv.AddressList); // The dialog box form
            DialogResult result;    // Result from dialog - OK/Cancel?
            result = letter.ShowDialog(); // Show dialog box form - modal, waits for OK/Cancel
                                          // Even after user dismisses, the form still exists
                                          // and can be interacted with using methods/properties

            if (result == DialogResult.OK)  // Only update if user chose enter
            {
                originAddress = upv.AddressAt(letter.OriginAddressInput);
                destinationAddress = upv.AddressAt(letter.destinationAddressInput);
                cost = decimal.Parse(letter.CostInput);

                upv.AddLetter(originAddress, destinationAddress, cost);
            }

        }

        string NL = Environment.NewLine; // creates a new line for string interpolation 

        // Precondition:  None
        // Postcondition: Addresses are listed to the user using the txtResult box
        private void BtnListAddress_Click(object sender, EventArgs e)
        {
            txtResults.Text = String.Empty; // removes previous data

            foreach (Address a in upv.AddressList)
            {
                txtResults.Text += $"{a}{NL}{NL}";
            }
            
        }

        // Precondition:  None
        // Postcondition: Letters are listed to the user using the txtResult box
        private void BtnListParcels_Click(object sender, EventArgs e)
        {
            txtResults.Text = String.Empty; //removes previous data

            foreach (Parcel p in upv.ParcelList)
            {
                txtResults.Text += $"{p}{NL}{NL}";
            }

            txtResults.Text += $"{upv}\n\n";
        }

        
    }
}
