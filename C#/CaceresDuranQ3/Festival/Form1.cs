using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival
{
    /* Luis Caceres
     * Nov. 2nd 2023
     * multiplier is 13.8% and exponent is 1/7
     * This program takes in one number and calculates two mathematical formulas when the 'Calculate' button is pressed.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //hides the picture box
            picCollege.Hide();
        }

        //reset button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            //blanks out textbox and display labels
            txtStartingNumber.Text = "";
            lblFirstCalculation.Text = "";
            lblSecondCalculation.Text = "";

            //hides the picture box
            picCollege.Hide();

            //places the cursor at top textbox
            txtStartingNumber.Focus();
        }

        //exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        //picture is clicked
        private void picCollege_Click(object sender, EventArgs e)
        {
            if (txtStartingNumber.Text == "") 
            {
                //displays a message to user asking them to enter a number 
                MessageBox.Show("Enter a number!", "Luis Caceres");
            } else
            {
                //declaring college years so code can be easily modified
                int collegeYears = 50;

                //displays the "NBCC - 50 Years" message
                MessageBox.Show("NBCC - " + collegeYears + " Years", "Luis Caceres");
            } //end else
        }

        //calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //variables declaration
                int startingNumber = Convert.ToInt32(txtStartingNumber.Text);
                double firstCalculation, secondCalculation;
                const double MULTIPLIER = 0.138;

                //first calculation
                firstCalculation = MULTIPLIER * startingNumber;

                //displays to first calculation to 1 decimal only
                lblFirstCalculation.Text = Math.Round(firstCalculation, 1).ToString();

                //second calculation
                secondCalculation = Math.Pow( startingNumber, 1 / (double) 7);

                //displays to second calculations to 3 decimal places
                lblSecondCalculation.Text = Math.Round(secondCalculation, 3).ToString();

                //showS picture
                picCollege.Show();
            }
            catch (Exception ex)
            {
                //shows an error message if client inputs incorrect data
                MessageBox.Show(ex.Message, "Luis Caceres");
            }
        }
    }
}
