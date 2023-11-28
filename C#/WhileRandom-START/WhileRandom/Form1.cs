using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Demo Nov. 28
 * 1. Set properties of nud: min=5, max =25, increment = 5, text-align: center
 * 2. Create ValueChanged event of nud:
 *  --> call each function listed below and put some data in label
 *  --> work on one function at time, call and test
 * 3. Create Function GenerateNumbers, see function header
 * 4. Create function TopBottom, see function header
 * 5. Create function CountRange, see function header
 */
namespace WhileRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nudHowMany_ValueChanged(object sender, EventArgs e)
        {
            //store the nud value in an int
            int number = (int)nudHowMany.Value;

            //clear label and listbox
            lblInfo.Text = "";
            lstNumbers.Items.Clear();

            //call GenerateNumbers capturing the return in variable
            double sum = GenerateNumbers(number);

            //write info into label
            lblInfo.Text += "Sum is " + sum + "\n";

            //call topBottom
            TopBottom();

            lblInfo.Text += "\nNumbers 20-80 = " + CountRange(20, 80);
        }

        //Name: GenerateNumbers
        //Send: how many to generate (found in nud)
        //Return: sum of all numbers
        //Use a do while loop to generate doubles between 1 and 100
        //Demo with and without seed values
        private double GenerateNumbers(int howMany)
        {
            double total = 0;
            int count = 0; //counter for do while loop
            Random rad = new Random();

            do
            {
                //generate a random double 1-100
                double randomNumber = rad.NextDouble() * 99 + 1;
                //write to lstbox
                lstNumbers.Items.Add(randomNumber.ToString("f2"));
                //add number to the sum
                total += randomNumber;
                //increment count
                //count++;
            } while (++count < howMany);

            return total;
        }

        //Name: TopBottom
        //Send: none
        //Return: none
        //Use the count property of the listbox
        //Display the top and bottom number from the listbox to the label
        private void TopBottom()
        {
            //declare count - using count property of lstbox
            int count = lstNumbers.Items.Count;

            if (count > 0)
            {
                //write to label
                double top = Convert.ToDouble(lstNumbers.Items[0]);

                lblInfo.Text += "Count is " + count + "\n" +
                    "Top number is " + top + "\n" +
                    "Bottom is " + lstNumbers.Items[count - 1];
            }
        }

        //Name: CountRange
        //Send: 2 doubles (min and max)
        //Return: count (int)
        //Use a while loop to access each number in the listbox using the index
        //Count how many numbers appear between the min and max
        private int CountRange(double min, double max) 
        {
            int countRange = 0, index = 0;
            while (index < lstNumbers.Items.Count)
            {
                //get the number from the lstbox
                double number = Convert.ToDouble(lstNumbers.Items[index++]);
                if ( number >= min && number <= max)
                {
                    countRange++;
                }
            }

            return countRange;
        }


    }
}
