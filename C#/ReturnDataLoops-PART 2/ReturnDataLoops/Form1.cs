using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*UPDATE PART 2
 * 
 * 
 * Demo: 
 * 1.Tab Order with groupboxes
 * 2.Form Load
 * 3.Demo Click: see comments
 * 4.Ftn: CheckInput returning string (use stub first)
 * 5.Run Loop click: Switch to handle the returned string
 *   Put returned string in message label
 *   a) Error string returned: display messagebox, select textbox
 *   b) IF good string returned: 
 *    --> run For Loop jumping by radiobutton amount
 *    --> sum all numbers within loop
 *    --> display sum in label
 * */
namespace ReturnDataLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select top radiobutton
            radTwo.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset to default
            radTwo.Checked = true;
            txtStart.Text = "";
            lblSum.Text = "";
            lblMessage.Text = "";
            //clear the listbox
            lstNumbers.Items.Clear();
            txtStart.Focus();
        }

        private void btnRunLoop_Click(object sender, EventArgs e)
        {
            //call function capturing returned data in string
            //send a number in and get it back from ftn
            //pass by ref
            int number = 0;
            string data = CheckInput(ref number);

            //put returned string in label
            lblMessage.Text = data;

            //use switch to determine action
            switch (data)
            {
                case "GOOD":
                    //run loop from start to 12, jumping by 2 or 5
                    //sum the numbers and display
                    int sum = 0, jump = 2;
                    if (radFive.Checked)
                        jump = 5;

                    //call function within expression that uses an int
                    lblSum.Text = IterateLoop(number,jump,12).ToString();   

                    break;
                default:
                    MessageBox.Show("Input incorrect", data + " Error");
                    break;
            } // end switch

        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            //add up the numbers from 1 to 10 going forwards
            //display "Demo" in message label and sum in lblsum
            //for loop - no const
            int sum = 0; //accumulator
            lblMessage.Text = "Demo";

            //call ftn sending data and capture return value
            //assignment statement to call
            sum = IterateLoop(1,1,10);

            lblSum.Text = sum.ToString();
        }

        /*Function: IterateLoop - stub first
         * send start, stop, jump (int)
         * return sum */
        private int IterateLoop(int start, int jump, int stop)
        {
            int sum = 0;
            for (int i = start; i <= stop; i+= jump)
            {
                sum += i;
                //add value of i to lstbox
                lstNumbers.Items.Add(i);
            }
            return sum; 
        }
         

        /*Function: CheckInput - stub first
         * Sent: none
         * Return: string in uppercase
         * This function validates the txtbox data in this order:
         * a) check for int, if not --> set string to "Type"
         * b) range of data is between 1-10, if not --> set string to "Range"
         * If no errors, set string to "Good" */
        private string CheckInput(ref int number)
        {
            string msg = "";
            const int MIN = 1, MAX = 10;

            //not an int
            if (!int.TryParse(txtStart.Text, out number))
                msg = "Type";
            //outside of the range)
            else if (number < MIN || number > MAX)
                msg = "Range";
            else
                msg = "Good";

            return msg.ToUpper();
        } // end CheckInput

    }
}
