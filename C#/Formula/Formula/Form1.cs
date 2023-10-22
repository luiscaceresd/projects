using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Add to program:
 * 1. Class-level constant for years (10)
 * 2. Form Load: 
 *      a) place class-level constant in years label on form
 *      b) hide picturebox
 *      c) blank out textboxes and interest rate
 *      d) put cursor on top textbox
 * 3. Reset Click: copy code from Form Load
 * 4. Create function: ResetForm, move code and call
 * 5. Calculate: 
 *      a) add formula
 *      b) show picbox
 *      c) format output as percent
 *      d) exception handling: add try catch block
 * 6. Change backcolor of groupbox; add Form Properties: Cancel and Accept buttons 
 * 7. Add breakpoint and run line for line
 * 8. Add check that present value is less than future value
 *      a) if and else (covered next class)
 * */
namespace Formula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //class-level constant - runtime
        const int YEARS = 10;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //get data from textboxes
                double futureValue = Convert.ToDouble(txtFutureValue.Text);
                double presentValue = Convert.ToDouble(txtPresentValue.Text);
                double interestRate = 0.0;

                if (presentValue < futureValue)
                {
                    //create formula - using class-level const for years
                    interestRate = Math.Pow(futureValue / presentValue, 1 / (double)YEARS) - 1;

                    //display answer and picbox
                    picFormula.Show();
                    lblInterestRate.Text = interestRate.ToString("p1"); 
                } else
                {
                    MessageBox.Show(futureValue.ToString("c0") + " must be equal to more or than " + presentValue.ToString("c0"), "Invalid Data");
                } // end else
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datatype Error");
            } //end catch
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // put years into the label
            lblYears.Text = YEARS.ToString();
            ResetForm();
        }

        private void ResetForm()
        {
            // hide pic
            picFormula.Hide();
            //blank
            txtFutureValue.Text = "";
            txtPresentValue.Text = "";
            lblInterestRate.Text = "";
            // focus on top
            txtFutureValue.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // call reset ftn
            ResetForm();
        }
    }
}
