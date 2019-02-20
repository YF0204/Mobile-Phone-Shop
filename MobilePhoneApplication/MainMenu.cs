using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneApplication
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            // jump to shop phones form
            frmShopPhones Shop = new frmShopPhones();
            Shop.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // display message box
            MessageBox.Show("If you have any questions or issues, please contact us on the following - 07589632145 or FulatPhones@hotmail.co.uk", "Help", MessageBoxButtons.OKCancel);
        }
    }
}
