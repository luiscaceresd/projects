using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BankPgm
{
    /* Comment header at top of program
     * Name: Luis Caceres
     * Date: November 18th, 2023
     * This program allows the user to performs 10 bank transactions (txn) they can be deposits or withdrawals. 
     * It allows the user to keep track of his bank account's balance, and displays a summary of each txn*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare class-level constants and variables
        const string MYNAME = "Luis";
        double balance = 1000.00; // starting balance in account
        int numOfTxn = 1;

        //form is loaded
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

        //cancel button is clicked
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

        //save button is clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            //const for total number of txns
            const int MAXTXN = 10;

            //validates if amount is valid
            if(ValidateAmount())
            {
                double amount = Convert.ToDouble(txtAmount.Text);
                //checks if there are txn left
                if (numOfTxn <= MAXTXN)
                {
                    //checks if it's a deposit
                    if (radDeposit.Checked)
                    {
                        //adds amount to balance
                        balance += amount;

                        //updates balance displayed on screen
                        lblBalance.Text = balance.ToString("C2");

                        //adds transaction to te statement
                        lblStatement.Text += "Txn " + numOfTxn + ": " + grpTxn.Text + "->" + amount.ToString("c2") + "\n";

                        //adds 1 to # of txns
                        numOfTxn++;
                    } //checks if it's a withdrawal
                    else if (radWithdraw.Checked)
                    { //checks if user has enough balance to withdraw
                        if (amount <= balance)
                        {
                            //subtract amount to balance
                            balance -= amount;

                            //updates balance displayed on screen
                            lblBalance.Text = balance.ToString("C2");

                            //adds transaction to te statement
                            lblStatement.Text += "Txn " + numOfTxn + ": " + grpTxn.Text + "->" + amount.ToString("c2") + "\n";

                            //adds 1 to # of txns
                            numOfTxn++;
                        } else
                        {
                            MessageBox.Show("Not enough in account to withdraw " + amount.ToString("c2") + ".", "Insufficient Funds");
                        }//end else
                    }//end else                 
                } //executes when there are no transactions left
                if(numOfTxn > MAXTXN)
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
                        lblStatement.Text += "Bank Fee appears on next statement.";
                    }//end if
                }//end if
            }

        }

        //deposit radio button checked is changed
        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            //calls SetTxnInfo function
            SetTxnInfo();
        }

        //withdraw radio button checked is changed
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
            //initialize constants and declare variables
            const double MIN = 5.0, MAX = 400.0;
            double amount;

            //declare boolean and call tryparse
            bool validAmount = double.TryParse(txtAmount.Text, out amount);

            //checks if amount entered is a boolean
            if (!validAmount)
            {
                //displays invalid data error
                MessageBox.Show("Amount entered is not numeric, try again.", "Amount - Numeric Error");

                //blanks out txtAmount
                txtAmount.Text = "";
            } //checks if amount is withing the established range
            else if (amount < MIN || amount > MAX)
            {
                //displays invalid range error
                MessageBox.Show("Amount must be between $" + MIN + "-$" + MAX + ".", "Amount - Range Error");

                //blanks out txtAmount
                txtAmount.Text = "";

                //sets valid amount to false because it's out of the established range
                validAmount = false;
            } //end else

            //returns true or false
            return validAmount;

        }

        //bank fee checkbox check changes
        private void chkBankFee_CheckedChanged(object sender, EventArgs e)
        {
            //checks if checkbox has been checked
            switch(chkBankFee.Checked) 
            {
                case true:
                    //displays message letting the user know the fee has been added
                    MessageBox.Show("Bank Fee will be added.", "Fee Confirmation");

                    //disables the checkbox
                    chkBankFee.Enabled = false;

                    //puts cursor on the textbox
                    txtAmount.Focus();
                    break;
            }//end switch
        }
    }
}
