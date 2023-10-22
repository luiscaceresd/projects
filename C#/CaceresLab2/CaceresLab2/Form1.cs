using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaceresLab2
{
    /* Luis Caceres
     * Oct. 1st 2023
     * This app consists of two sections, the first section 'Math' lets you calculate the sum and product of two numbers. It also introduces you to the programmer by using a picture and a description in the 'About Me' section */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            Close();
        }


        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Shows picture
            picMe.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //Hides the picture and label beside it
            picMe.Hide();
            lblPicture.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clears number1 textbox
            txtNumber1.Text = "";

            //Clears number2 textbox
            txtNumber2.Text = "";

            //Clears sum label
            lblSum.Text = "";

            //Clears product label
            lblProduct.Text = "";

            //Focus on number1 textbox
            txtNumber1.Focus();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            // Initialize variables to use in lblPicture
            string name = "Luis Caceres.\n",
                   aboutMe = "I'm a Petroleum/Chemical Engineer from Colombia. "+"I currently work part-time as a Web Developer here in Miramichi for Salty DNA 🥰.\n" + "I brought my cat to Canada and his name is Kratos, maybe you will meet him in another lab 😁.";

            //Shows about me text
            lblPicture.Text = "My name is " + name + aboutMe;

            //Shows the label
            lblPicture.Visible = true;
        }

        private void picMe_Click(object sender, EventArgs e)
        {
            // Initialize variables to use in the MessageBox
            string name = "Luis Caceres",
                   information = "I phtoshopped this image just to use it as my linkedin picture 🤓.";

            // Show a message box to the user
            MessageBox.Show(information,name);
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            // Declare uninitialized variables
            int number1, number2, sum, product;

            // Convert textboxes inputs to int
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);

            // Add numbers
            sum = number1 + number2;

            // Multiply numbers
            product = number1 * number2;

            // Convert to string and display results
            lblSum.Text = sum.ToString();
            lblProduct.Text = product.ToString();
        }
    }
}
