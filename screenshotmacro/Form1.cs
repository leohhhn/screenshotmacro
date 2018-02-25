using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace screenshotmacro
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        #region Mouse Click
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;    

        public static void move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }

        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
        #endregion

        Bitmap ss;
        Tuple<int, int> pos;

        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromImage(ss);
            Size s = new Size(ss.Width, ss.Height);
            g.CopyFromScreen(0, 0, 0, 0, s);
            //ss.Save(@"C:\Users\Leon\Desktop\ss.png");

            if (loggerIsRunning())
            {
                GetPixels();
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Point firstPos = Cursor.Position;
                Cursor.Position = new Point(pos.Item1 + 22, pos.Item2 + 13);
                LeftClick();
                Cursor.Position = firstPos;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to open the Logger?", "Logger not running", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start(@"C:\Users\Leon\AppData\Local\Apps\2.0\X9D5GX7E.HL7\L0D4VM4B.7RA\syne..tion_d724cb0a5b43bedc_0001.0000_f819044b4e996793\Synergy.BaseballLogger.WinApp.exe");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("k den bb");
                    Application.Exit();
                }
            }
        }

        private bool loggerIsRunning()
        {
            Process[] pname = Process.GetProcessesByName("Synergy.BaseballLogger.WinApp");
            if (pname.Length == 0)
                return false;
            else
                return true;
        }

        private Tuple<int, int> GetPixels()
        {
            // green from the apply button
            Color c = Color.FromArgb(30, 165, 46);

            for (int y = Screen.PrimaryScreen.Bounds.Height / 2; y < ss.Height; y++)
            {
                for (int x = Screen.PrimaryScreen.Bounds.Width / 2; x < ss.Width; x++)
                {
                    if (ss.GetPixel(x, y) == c)
                    {
                        pos = Tuple.Create(x, y);
                        return pos;
                    }
                }
            }
            return null;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}