using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BankPgm
{
    /* Comment header at top of program
     * Name: Luis Caceres
     * Date: November 18th, 2023
     * This program performs bank transactions (txn) */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare class-level constants and variables
        const string MYNAME = "Luis";
        double balance = 1000.00; // starting balance in account
        int numOfTxn = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // adds name to end of the current form title
            Text += " " + MYNAME;

            //adds name to end of greeting label
            lblGreeting.Text += " " + MYNAME;

            //puts the current balance in balance label formatted as currency
            lblBalance.Text = balance.ToString("c");

            //selects Deposit radiobutton
            radDeposit.Checked = true;

            //puts cursor on textbox amount
            txtAmount.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //blanks out txtbox, selects Deposit and sets the focus on txtAmount
            txtAmount.Text = "";
            radDeposit.Checked = true;
            txtAmount.Focus();
        }

        /*
         * Name: SetTxnInfo
         * Sent: none
         * Returned: none
         * Based on radio button selected, set title on groupbox. 
         * Always set the focus on the amount textbox */
        private void SetTxnInfo()
        {
            //checks if the deposit radio button is selected
            if (radDeposit.Checked)
            {
                //sets groupbox title to deposit
                grpTxn.Text = radDeposit.Text;

                //focus on the amount textbox
                txtAmount.Focus();
            } else
            {
                //sets groupbox title to deposit
                grpTxn.Text = radWithdraw.Text;

                //focus on the amount textbox
                txtAmount.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //const for total number of txns
            const int MAXTXN = 10;

            //validates if amount is valid
            if(ValidateAmount())
            {
                double amount = Convert.ToDouble(txtAmount.Text);
                //checks if there are txn left
                if (numOfTxn < MAXTXN)
                {
                    //checks if it's a deposit
                    if (radDeposit.Checked)
                    {
                        //adds amount to balance
                        balance += amount;

                        //adds 1 to # of txns
                        numOfTxn++;

                        //updates balance displayed on screen
                        lblBalance.Text = balance.ToString("C2");

                        //adds transaction to te statement
                        lblStatement.Text += "Txn " + numOfTxn + ": " + grpTxn.Text + "-> " + amount.ToString("c2") + "\n";
                    } //checks if it's a withdrawal
                    else if (radWithdraw.Checked)
                    {
                        if (amount <= balance)
                        {
                            //subtract amount to balance
                            balance -= amount;

                            //adds 1 to # of txns
                            numOfTxn++;

                            //updates balance displayed on screen
                            lblBalance.Text = balance.ToString("C2");

                            //adds transaction to te statement
                            lblStatement.Text += "Txn " + numOfTxn + ": " + grpTxn.Text + "-> " + amount.ToString("c2") + "\n";
                        } else
                        {
                            MessageBox.Show("Not enough in account to withdraw " + amount.ToString("c2"), "Insufficient Funds");
                        }
                    }





                     
                } //executes when there are no transactions left
                else
                {
                    //lets the user know there are no txn left
                    MessageBox.Show("No more transactions allowed at this time.", "Restart Program");

                    //disables select group
                    grpSelect.Enabled = false;

                    //hides txt group
                    grpTxn.Hide();

                    //check if bank fee is checked
                    if (chkBankFee.Checked)
                    {
                        //adds transaction to te statement
                        lblStatement.Text += "Bank Fee appears on next statement";
                    }
                }
            }

        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            //calls SetTxnInfo function
            SetTxnInfo();
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            //calls SetTxnInfo function
            SetTxnInfo();
        }

        /* Name: ValidateAmount
         * Sent: none
         * Returned: boolean
         * Validates for datatype first, then range.
         * Return true if pass all validation, otherwise return false*/
        private bool ValidateAmount() 
        {
            //initialize variables
            const double MIN = 5.0, MAX = 400.0;
            double amount;

            //declare boolean and call tryparse
            bool validAmount = double.TryParse(txtAmount.Text, out amount);

            //checks if amount entered is a boolean
            if (!validAmount)
            {
                //displays invalid data error
                MessageBox.Show("Amount entered is not numeric, try again", "Amount - Numeric Error");

                //blanks out txtAmount
                txtAmount.Text = "";
            } //checks if amount is withing the established range
            else if (amount < MIN || amount > MAX)
            {
                //displays invalid range error
                MessageBox.Show("Amount must be between $" + MIN + "-$" + MAX, "Amount - Range Error");

                //blanks out txtAmount
                txtAmount.Text = "";

                validAmount = false;
            } //end else

            return validAmount;

        }

        private void chkBankFee_CheckedChanged(object sender, EventArgs e)
        {
            //checks if checkbox has been checked
            switch(chkBankFee.Checked) 
            {
                case true:
                    //displays message letting the user know the fee has been added
                    MessageBox.Show("Bank Fee will be added", "Fee Confirmation");

                    //disables the checkbox
                    chkBankFee.Enabled = false;

                    //puts cursor on the textbox
                    txtAmount.Focus();
                    break;
            }//end switch
        }
    }
}
