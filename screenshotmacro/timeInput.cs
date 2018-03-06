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
    public partial class timeInput : Form
    {
        public string stopTime;
        public bool clicked = false;
        public bool closed = false;
        public timeInput()
        {

            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2 - 100,
                                      Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicked = true;
            stopTime = timePicker.Value.ToShortTimeString();
            Dispose();
        }

        private void timeInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }
    }
}
