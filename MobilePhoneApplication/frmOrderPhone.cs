using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MobilePhoneApplication
{
    public partial class frmOrderPhone : Form
    {
        public frmOrderPhone()
        {
            InitializeComponent();
        }

        private void frmOrderPhone_Load(object sender, EventArgs e)
        {
            // load event
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            // declare a boolean variable
            Boolean Ok = true;
            // check for blank strings
            if (textBoxFirstName.Text == "")
            {
                // display the following error message
                MessageBox.Show("Please enter your first name.", "First Name Error", MessageBoxButtons.OK);
                Ok = false;
            }
            if (textBoxLastName.Text == "")
            {
                // display the following error message
                MessageBox.Show("Please enter your last name.", "Last Name Error", MessageBoxButtons.OK);
                Ok = false;
            }
            if (textBoxContactNo.Text == "")
            {
                // display the following error message
                MessageBox.Show("Please enter you contact number.", "Contact Number Error", MessageBoxButtons.OK);
                Ok = false;
            }
            if (textBoxEmailAddress.Text == "")
            {
                // display the following error message
                MessageBox.Show("Please enter you email address.", "Email Address Error", MessageBoxButtons.OK);
                Ok = false;
            }

            // if everything is ok, then add the order details to the txt file
            if (Ok == true)

            {
                using (StreamWriter file = new StreamWriter(@"../../orders.txt", true))
                {
                    // add the following information to the text file
                    file.WriteLine("Order Details:" + textBoxOrderDetails.Text);
                    file.WriteLine("First Name:" + textBoxFirstName.Text);
                    file.WriteLine("Last Name:" + textBoxLastName.Text);
                    file.WriteLine("Contact No:" + textBoxContactNo.Text);
                    file.WriteLine("Email Address:" + textBoxEmailAddress.Text);
                }
                // display dialog box to confirm order with user
                MessageBox.Show("Your order has been successfully processed, we will notify you when your item is ready for collection, thank you.", "Order Confirmation", MessageBoxButtons.OK);
            }

            // display this message to the user
            else
            {
                MessageBox.Show("Please fill in all the details to complete your order.", "Order Error", MessageBoxButtons.OK);
            }
        }
    }
}

