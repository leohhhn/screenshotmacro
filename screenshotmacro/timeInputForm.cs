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
    public partial class timeInputForm : Form
    {
        public string stopTime;
        public bool clicked = false;
        private mainForm f;
        DateTime defaultTime = DateTime.Now;

        public timeInputForm(mainForm f)
        {
            this.f = f;
            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2 - 100,
                                      Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            defaultTime.AddHours(2);
            timePicker.Value = defaultTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicked = true;
            stopTime = timePicker.Value.ToLongTimeString();
            Close();
        }

        private void timeInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.timerFormCallback(clicked);
        }
    }
}
