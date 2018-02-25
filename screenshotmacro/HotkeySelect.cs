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
    public partial class HotkeySelect : Form
    {
        public HotkeySelect()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public static bool spaceChecked;
        public static bool lShiftChecked;

        private void HotkeySelect_Load(object sender, EventArgs e)
        {

        }

        private bool space()
        {
            if (rbSpace.Checked)
                return true;
            return false;
        }

        private bool lShift()
        {
            if (rbLShift.Checked)
                return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spaceChecked = space();
            lShiftChecked = lShift();
            
        }
    }
}
