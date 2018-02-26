using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screenshotmacro
{
    public partial class fHelp : Form
    {
        public fHelp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        string about =
            "This is a hotkey program made for Synergy Baseball Loggers\n that allows them to click the \"Apply\" button with ease.";
        string howto =
            "First, select a hotkey you want to use.\nSecond, make sure the Logger is running.\nLast, click start.";
        string cr = "© 2018 OutOfBounds";
        string bug = "If you find any bugs, please e-mail me at";
        string email = "outofbounds@protonmail.com";

        private void fHelp_Load(object sender, EventArgs e)
        {
            labout.Text = about;
            lInsrt.Text = howto;
            lCr.Text = cr;
            lBug.Text = bug;

            tbEmail.Text = email;
            tbEmail.ReadOnly = true;
            tbEmail.BorderStyle = 0;
            tbEmail.BackColor = this.BackColor;
            tbEmail.TabStop = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
  
        }
    }
}
