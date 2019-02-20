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
    public partial class frmShopPhones : Form
    {
        // shop class contains the list of phones and current index
        Shop shop;
        public frmOrderPhone NewOrder;
        public frmShopPhones()
        {
            InitializeComponent();
        }

        // index for phone images
        private int imageNumber = 1;
        private void frmShopPhones_Load(object sender, EventArgs e)
        {
            // on load 
            shop = new Shop();
            // add the mobile phones here
            ApplePhone ApplePhone1 = new ApplePhone("iOS8", "Apple", "iPhone 4", new DateTime(2015, 5, 12), 50, MobilePhone.Condition.Mint, "Silver", "16GB");
            ApplePhone ApplePhone2 = new ApplePhone("iOS9", "Apple", "iPhone 5", new DateTime(2014, 9, 18), 100, MobilePhone.Condition.Fair, "Space Grey", "16GB");
            ApplePhone ApplePhone3 = new ApplePhone("iOS10", "Apple", "iPhone 7", new DateTime(2015, 7, 10), 700, MobilePhone.Condition.Mint, "Black", "64GB");
            ApplePhone ApplePhone4 = new ApplePhone("iOS8", "Apple", "iPhone 5C", new DateTime(2016, 2, 24), 75, MobilePhone.Condition.Poor, "Pink", "16GB");
            ApplePhone ApplePhone5 = new ApplePhone("iOS9", "Apple", "iPhone 6S", new DateTime(2015, 4, 22), 150, MobilePhone.Condition.Fair, "White", "32GB");
            AndroidPhone AndroidPhone1 = new AndroidPhone("Jelly Bean 4.1", "Motorola", "3rd Gen", new DateTime(2015, 10, 24), 100, MobilePhone.Condition.Good, "Lava Red", "16GB");
            AndroidPhone AndroidPhone2 = new AndroidPhone("KitKat 4.4", "Samsung", "Galaxy S7", new DateTime(2016, 4, 2), 400, MobilePhone.Condition.Good, "Deep Blue", "32GB");
            AndroidPhone AndroidPhone3 = new AndroidPhone("Jelly Bean 4.1", "Sony", "Xperia Z5", new DateTime(2015, 6, 14), 180, MobilePhone.Condition.Poor, "Black", "32GB");
            AndroidPhone AndroidPhone4 = new AndroidPhone("Donut 4.0", "HTC", "One X", new DateTime(2014, 1, 9), 69, MobilePhone.Condition.Fair, "Black", "16GB");
            AndroidPhone AndroidPhone5 = new AndroidPhone("KitKat 4.4", "Samsung", "J5", new DateTime(2016, 12, 22), 50, MobilePhone.Condition.Mint, "White", "16GB");
            shop.AddPhone(ApplePhone1);
            shop.AddPhone(ApplePhone2);
            shop.AddPhone(ApplePhone3);
            shop.AddPhone(ApplePhone4);
            shop.AddPhone(ApplePhone5);
            shop.AddPhone(AndroidPhone1);
            shop.AddPhone(AndroidPhone2);
            shop.AddPhone(AndroidPhone3);
            shop.AddPhone(AndroidPhone4);
            shop.AddPhone(AndroidPhone5);
            // display phone in the list
            DisplayPhone();
            // load first image
            FindImage();
        }

        // display the phone in the text box
        private void DisplayPhone()
        {
            // display label on the form
            labelSelectedPhone.Text = string.Format("Mobile Phone {0} of {1}", shop.CurrentlyViewedPhone + 1, shop.NumberofPhones);
            // show current phone in text box
            textBoxPhones.Text = shop.DescribeCurrentPhone();
        }

        // move to next phone
        private void btnNext_Click(object sender, EventArgs e)
        {
            // step to next phone
            shop.StepToNextPhone();
            // display the phone in the label
            DisplayPhone();
            // load the next image
            FindImage();
     
        }
        
        // move back to previous phone
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // step to previous phone 
            shop.StepToPreviousPhone();
            // display phone in the label
            DisplayPhone();
            // load the previous image
            FindImage();
        }
        
        // order a phone
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // now pass the selected phone's details to the order form
            frmOrderPhone NewOrder = new frmOrderPhone();
            NewOrder.textBoxOrderDetails.Text = shop.DescribeCurrentPhone();
            // show the selected phone in the order form
            NewOrder.Show();
        }

        // load phone images
        private void FindImage()
        {
            // display selected image
            imageNumber = shop.CurrentlyViewedPhone + 1;
            // display images from specified folder
            //imgPicture.ImageLocation = string.Format(@"E:\CTEC2902 Advanced Programming\Mobile Phone Assignment\Mobile Phone Assignment\MobilePhoneApplication\MobilePhoneApplication\Images\img{0}.jpg", imageNumber);
            imgPicture.ImageLocation = string.Format(@"..\..\Images\img{0}.jpg", imageNumber);
        }
    }
}
