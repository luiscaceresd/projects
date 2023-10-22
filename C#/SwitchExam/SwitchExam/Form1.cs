using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count, number;
            string letter = "a";

            switch (count)
            {
                case 0:
                    MessageBox.Show("Error");
                    break;
                default:
                    count *= 2;
                    break;
            }

            if (number >= 1 && number <= 10)
            {
                switch (number)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                        MessageBox.Show("Odd");
                        break;

                    default:
                        MessageBox.Show("Even");
                        break;
                }
            }

            //test for even or odd - any integer
            if (number % 2 == 0)
                MessageBox.Show("Even");
            else
                MessageBox.Show("Odd");

            //Asume one letter is entered into a string. Display whether is a vowel or not
            switch(letter.ToLower())
            {
                case "a": case "e": case "i": case "o": case "u":
                    MessageBox.Show("Vowel");
                break;
                default:
                    MessageBox.Show("not a vowel");
                break;
            }

        }
    }
}
