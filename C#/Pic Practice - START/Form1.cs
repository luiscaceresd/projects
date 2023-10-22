using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 1 - download, copy to folder, extract, open
 * 2 - buttons - Text: &Reset, name all
 * 3 - button alignment: same size, align, equal space between
 * 4 - Run - fix tab order (labels and picbox don't get cursor)
 * 5 - Form Properties - font (done), StartPosition, CancelButton
 * 6 - Label Properties: AutoSize, BorderStyle, Text
 * 7 - Add Picturebox: Image, SizeMode
 * 8 - Selecting controls: Properties window, right-click (Send to Back)
 * 9 - Design time: change Visible property
 * 10 - Reset button code: hide both, set label empty
 * 11 - Text button: add text, show label
 * 12 - Picture button: show
 * 13 - did we forget anything?
 * */
namespace Pic_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //hide label and picbox
            lblText.Visible = false;
            picCat.Hide();
            //reset label to blank
            lblText.ResetText();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //show picturebox
            picCat.Show();
            lblText.Hide();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            //change text
            lblText.Text = "This is new!\n\n" + 
                "Another line";

            //show text
            lblText.Show();
            picCat.Hide();
        }
    }
}
