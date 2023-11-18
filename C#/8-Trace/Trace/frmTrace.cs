using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trace
{
    public partial class frmTrace : Form
    {
        public frmTrace()
        {
            InitializeComponent();
        }
        private void HiThere()
        {
            lblOutput.Text = Message;
            if (txtInput.Text == "") chkFlip.Checked = true;
            else chkFlip.Checked = false;
        }      
        const string Message = "What's up?";
        private void btnGo_Click(object sender, EventArgs e)
        {
            HiThere();
            if (lblOutput.Text == Message)
                count += 5;
            else
                lblOutput.Text = Message;
                lblDisplay.Text += count.ToString() + "\n";
        }
        int count = 100;
        private void frmTrace_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            lblOutput.Text = "";
            txtInput.Text = "";
            while (count != 100) MessageBox.Show(count++.ToString());
            HiThere(); count -= 10;
        }
        private void btnHuh_Click(object sender, EventArgs e)
        {
            count++; lblOutput.Text = "";
            switch (txtInput.Text.ToUpper())
            {
                case "":
                    lblDisplay.Text += "Message\n";
                    count++;
                    break;
                case "HI":
                case "BYE":
                    lblDisplay.Text += Message;
                    count--;
                    break;
                default:
                    lblOutput.Text = count.ToString();
                    count = count / 2;
                    break;
            }
            lblDisplay.Text += count.ToString() + "\n";
        }
    }
}

