using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablewithConversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            //declare variable for age
            int age;

            //get number from textbox - put in var (conversion required)
            age = Convert.ToInt32(txtAge.Text);

            //add one to age variable
            age = age + 1;

            //display in new age label (conversion required)
            lblNewAge.Text = age.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear data
            txtAge.Text = "";
            lblNewAge.Text = "";

            //put cursor on top textbox
            txtAge.Focus();
        }
    }
}
