using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaceresDuranLab3
{
    /* Luis Caceres
     * Oct. 29th 2023
     * This app's objective is to calculate your mothly mortgage based on an initial amount and a number of years.
     * The interest rate used is 2.99% but you can always change it below. It is a class level constant.
     * It validates the user's input to make sure invalid information isn't entered.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //class-level constant - runtime
        const double RATE = 0.0299;

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Places the RATE in the label formated as percentage
            lblRate.Text = RATE.ToString("P");

            //Hide the picturebox
            picHouse.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Calls reset input function
            ResetInput();
        }

        //function 
        private void ResetInput()
        {
            //Blank out the textboxes and display label
            txtPrincipal.Text = "";
            txtYears.Text = "";
            lblMortgage.Text = "";

            //Put the cursor on the top textbox
            txtPrincipal.Focus();

            //Hide the picturebox
            picHouse.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Read Valuyes entered by the user into variables
                double principal = Convert.ToDouble(txtPrincipal.Text);
                int years = Convert.ToInt32(txtYears.Text);

                //Declare constants
                const double MINPRINCIPAL = 5000.0;
                const int MAXYEARS = 30;

                //Declare formula variables
                double monthlyMortgage;
                double monthlyRate = RATE / 12;
                int numberOfMonths = years * 12;

                //start of if statement to validate input
                if (principal < MINPRINCIPAL)
                {
                    //Show error message
                    MessageBox.Show("Invalid principal amount, try again", "Error");

                    //Blank out principal textbox and put the cursor on it
                    txtPrincipal.Text = "";
                    txtPrincipal.Focus();
                } else if (years > MAXYEARS)  
                {
                    //Show error message
                    MessageBox.Show("Invalid years amount, try again", "Error");

                    //Blank out years textbox and put the cursor on it
                    txtYears.Text = "";
                    txtYears.Focus();
                } else
                {
                    //Monthly Mortgage calculation
                    monthlyMortgage = principal * monthlyRate * Math.Pow((1 + monthlyRate), numberOfMonths) / (double)(Math.Pow((1 + monthlyRate), numberOfMonths) - 1);

                    //Display Monthly mortgage
                    lblMortgage.Text = Convert.ToString(Math.Round(monthlyMortgage, 2));

                    //Display picturebox
                    picHouse.Show();
                }   //end else
            } // end try
            catch (Exception ex)
            {
                //Show error message
                MessageBox.Show("Incorrect input encountered", "Error");

                //Calls reset input function
                ResetInput();
            } // end catch
        }
    }
}
