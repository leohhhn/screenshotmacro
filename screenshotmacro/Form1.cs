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
using Microsoft.VisualBasic;

namespace screenshotmacro
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

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
        string loggerpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            + @"\AppData\Local\Apps\2.0\X9D5GX7E.HL7\L0D4VM4B.7RA\syne..tion_d724cb0a5b43bed
            c_0001.0000_f819044b4e996793\Synergy.BaseballLogger.WinApp.exe";

        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            MessageBox.Show("Hotkeys won't work unless the Logger is open.", "Warning!");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1.RegisterHotKey(this.Handle, 0, 0x0002, 0x7B); // Ctrl + F12

            if (loggerIsRunning())
            {
                if (rbSpace.Checked)
                {
                    Form1.RegisterHotKey(this.Handle, 1, 0x0000, 0x20); // Space
                    this.Visible = false;
                    MessageBox.Show("To stop the hotkey, press Ctrl + F12");
                }
                else if (rbCtrlE.Checked)
                {
                    Form1.RegisterHotKey(this.Handle, 1, 0x0002, 0x45); // Ctrl + E
                    this.Visible = false;
                    MessageBox.Show("To stop the hotkey, press Ctrl + F12");
                }
                else if (rbCtrlS.Checked)
                {
                    Form1.RegisterHotKey(this.Handle, 1, 0x0002, 0x53); // Ctrl + S
                    this.Visible = false;
                    MessageBox.Show("To stop the hotkey, press Ctrl + F12");
                }
                else if (rbCtrlF.Checked)
                {
                    Form1.RegisterHotKey(this.Handle, 1, 0x0002, 0x46); // Ctrl + F
                    this.Visible = false;
                    MessageBox.Show("To stop the hotkey, press Ctrl + F12");
                }
                else
                    MessageBox.Show("Please select hotkey to use", "Error");
            }
            else
            {
                MessageBox.Show("Logger isn't running, open it first.");
            }

        }

        private bool loggerIsRunning()
        {
            Process[] logger = Process.GetProcessesByName("Synergy.BaseballLogger.WinApp");

            if (logger.Length == 0)
                return false;
            else
                return true;
        }

        private Tuple<int, int> GetPixels()
        {
            // green from the apply button
            Color c = Color.FromArgb(30, 165, 46);

            for (int y = 0; y < ss.Height; y++)
            {
                for (int x = 0; x < ss.Width; x++)
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

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                IntPtr i = m.WParam;
                if ((int)i == 1)
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
                            Process.Start(loggerpath);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("k den bb");
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    this.Visible = true;
                    Form1.UnregisterHotKey(this.Handle, 1);
                    MessageBox.Show("unregistered hotkey");
                }
            }
            base.WndProc(ref m);
        }


    }
}
