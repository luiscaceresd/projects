using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLab4
{
    //demonstrate adding try catch to one of the methods
    // demonstrate variable scope - move from local (method-level) to global (class-level)
    //      only for the operands
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare 2 class-level variables - ints
        int operand1, operand2;

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //declare answer as double - method-level, local
            double answer;

            try
            {
                //read from txtboxes, put into 2 ints - conversion required
                operand1 = Convert.ToInt32(txtNum1.Text);
                operand2 = Convert.ToInt32(txtNum2.Text);

                //put operator in the label
                lblOperation.Text = btnDivide.Text;

                //do the math - must cast one of the operands
                answer = operand1 / (double)operand2;

                //display the answers - conversion required - formatting
                // format string: 1st character letter, second number
                lblResult.Text = answer.ToString("f2");
            } //end try block
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Data entered");
            } // End Catch block
        }// End event

        private void btnMod_Click(object sender, EventArgs e)
        {
            operand1= Convert.ToInt32(txtNum1.Text);
            operand2= Convert.ToInt32(txtNum2.Text);

            //calc answer - declaration with init
            int answer = operand1 % operand2;

            //put operator in label
            lblOperation.Text = btnMod.Text;

            //display answer - conversion required
            lblResult.Text=answer.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToInt32(txtNum1.Text);
            operand2 = Convert.ToInt32(txtNum2.Text);

            //calc answer - declaration with init
            int answer = operand1 + operand2;

            //put operator in label
            lblOperation.Text = btnAdd.Text;

            //display answer - conversion required
            lblResult.Text = answer.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToInt32(txtNum1.Text);
            operand2 = Convert.ToInt32(txtNum2.Text);

            //calc answer - declaration with init
            int answer = operand1 - operand2;

            //put operator in label
            lblOperation.Text = btnSubtract.Text;

            //display answer - conversion required
            lblResult.Text = answer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToInt32(txtNum1.Text);
            operand2 = Convert.ToInt32(txtNum2.Text);

            //calc answer - declaration with init
            int answer = operand1 * operand2;

            //put operator in label
            lblOperation.Text = btnMultiply.Text;

            //display answer - conversion required
            lblResult.Text = answer.ToString();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToInt32(txtNum1.Text);
            operand2 = Convert.ToInt32(txtNum2.Text);

            //calc answer - declaration with init 
            // implicit cast of int parameters sent to method Pow
            double answer = Math.Pow(operand1,operand2);

            //put operator in label
            lblOperation.Text = btnPow.Text;

            //display answer - conversion required
            lblResult.Text = answer.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset to blanks
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblOperation.Text = "";
            lblResult.Text = "";
            //put cursor on top textbox
            txtNum1.Focus();
        }
    }
}
