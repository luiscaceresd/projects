using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Update program:
 * A. Remove Try/ Catch
 * B. Test the data using TryParse
 * C. Add checkbox for Bonus
 * D. Add event associated with checkbox */
namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declarations - block-level
            int grade; // do not initialize
            const int DEANMARK = 85, PASSMARK = 60, MINMARK = 0, MAXMARK = 100;
            const string PASS = "Pass", FAIL = "Fail";

            // declare boolean and call tryparse
            bool validGrade = int.TryParse(txtNumberGrade.Text, out grade);

            //if data is not an int
            if (!validGrade)
            {
                MessageBox.Show("Grade must be a whole number",
                    "Data Error");
                txtNumberGrade.Focus();
                txtNumberGrade.SelectAll();
            }
            //grade invalid outside of 0-100
            else if (grade < MINMARK || grade > MAXMARK)
            {
                MessageBox.Show("Grade must be between " + MINMARK + "-" + MAXMARK,
                    "Range Error");
                txtNumberGrade.Focus();
                txtNumberGrade.SelectAll();
            }
            else // data good, do the rest
            {
                //empty hidden label
                lblDean.Text = "";

                //1) hidden label on the form
                // - if number grade is 85 or higher, display Dean's List
                // - use constant for 85
                if (grade >= DEANMARK)
                    lblDean.Text = "Dean's List";

                //2) if number grade is 60 or above
                // - display Pass in outcome, otherwise Fail
                // - use constants for 60, Pass and Fail
                if (grade >= PASSMARK)
                    lblOutcome.Text = PASS;
                else
                    lblOutcome.Text = FAIL;

                //3) the letter grade is calculated as follows
                //assume integer entered
                // - 95-100: A+
                // - 90-94: A
                // - 80-89: B
                // - 70-79: C
                // - 60-69: D
                // - 0 -59: F
                // use numeric and string literals, no constants
                // add at top: test for valid grade before doing anything else
                string letter = "";

                if (grade >= 95)
                    letter = "A+";
                else if (grade >= 90)
                    letter = "A";
                else if (grade >= 80)
                    letter = "B";
                else if (grade >= 70)
                    letter = "C";
                else if (grade >= 60)
                    letter = "D";
                else
                    letter = "F";

                lblLetter.Text = letter;

                //Based on letter grade, display a message:
                // A, A+ or B: display Good work!
                // C or D: display Needs improvement!
                // F: display Sign up for tutorials!
                switch (letter.ToLower())
                {
                    case "a+":
                    case "a":
                    case "b":
                        MessageBox.Show("Good work");
                        break;
                    case "c":
                    case "d":
                        MessageBox.Show("Needs improvement");
                        break;
                    case "f":
                        MessageBox.Show("Sign up for tutorials");
                        break;
                } // end switch
            } // end else

        } //end Calculate event

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear textbox and labels
            txtNumberGrade.Text = "";
            lblDean.Text = "";
            lblLetter.Text = "";
            lblOutcome.Text = "";

            //uncheck bonus
            chkBonus.Checked = false;

            //focus
            txtNumberGrade.Focus();
        }

        private void chkBonus_CheckedChanged(object sender, EventArgs e)
        {
            //runs when the Checked property changes - default event
            if (chkBonus.Checked && lblLetter.Text != "")
            {
                if (int.TryParse(txtNumberGrade.Text, out int grade) && grade < 100)
                {   //add 1 and redisplay
                    grade++;
                    txtNumberGrade.Text = grade.ToString();
                    //get the Calculate event to run
                    btnCalculate.PerformClick();
                } // end if on tryparse and < 100
            } // end if checked and label has data
        } // end event
    }
}
