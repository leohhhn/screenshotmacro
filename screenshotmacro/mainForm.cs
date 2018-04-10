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
using System.Threading;

namespace screenshotmacro
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnStopClick.Enabled = false;
            timer1.Enabled = false;
        }

        #region Dll imports
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        #endregion

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

        Bitmap ss; // screenshot of the whole screen bitmap     
        Tuple<int, int> pos; // holds position of the pixel that has the needed color
        bool onlyApply = true;
        bool clickAll = false;
        timeInputForm ti;
        Process[] dashboard;
        Random r = new Random();

        Tuple<int, int> p1 = new Tuple<int, int>(704, 553);
        Tuple<int, int> p2 = new Tuple<int, int>(1053, 553);
        Tuple<int, int> p3 = new Tuple<int, int>(1292, 583);
        Tuple<int, int> p4 = new Tuple<int, int>(955, 264);
        Tuple<int, int> p5 = new Tuple<int, int>(706, 734);
        Tuple<int, int> p6 = new Tuple<int, int>(1244, 885);

        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            MessageBox.Show("Use this program at your own responsibility. \nI will not be responsible for anything that might happen.");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbBoth.Checked)
                onlyApply = false;

            if (cbAll.Checked)
                clickAll = true;


            if (loggerIsRunning())
            {
                //   Form1.RegisterHotKey(this.Handle, 1, 0x0000, 0x20);
                //                            handle, id, modifier key, key
                // id - your own numeber to differentiate between hotkeys
                // modifier - ctrl, shift, alt etc.

                // Ctrl + F12 is used as the hotkey stopper

                mainForm.RegisterHotKey(this.Handle, 0, 0x0002, 0x7B); // Ctrl + F12  
                mainForm.RegisterHotKey(this.Handle, 2, 0x0002, 0x46); // Ctrl + F

                // registering hotkeys depending on user input
                if (rbSpace.Checked)
                {
                    mainForm.RegisterHotKey(this.Handle, 1, 0x0000, 0x20); // Space
                    this.Visible = false;
                    MessageBox.Show("To pause/disable the hotkey, press Ctrl + F12." +
                             "\nHotkeys won't work unless the Logger is open and in fullscreen mode.");
                }
                else if (rbCtrlE.Checked)
                {
                    mainForm.RegisterHotKey(this.Handle, 1, 0x0002, 0x45); // Ctrl + E
                    this.Visible = false;
                    MessageBox.Show("To pause/disable the hotkey, press Ctrl + F12." +
                       "\nHotkeys won't work unless the Logger is open and in fullscreen mode.");
                }
                else if (rbBackSlash.Checked)
                {
                    mainForm.RegisterHotKey(this.Handle, 1, 0x0000, 0xDC); //  \ 
                    this.Visible = false;
                    MessageBox.Show("To pause/disable the hotkey, press Ctrl + F12." +
                                        "\nHotkeys won't work unless the Logger is open and in fullscreen mode.");
                }
                //else if (rbCtrlF.Checked)
                //{
                //    mainForm.RegisterHotKey(this.Handle, 1, 0x0002, 0x46); // Ctrl + F
                //    this.Visible = false;
                //    MessageBox.Show("To pause/disable the hotkey, press Ctrl + F12." +
                //        "\nHotkeys won't work unless the Logger is open and in fullscreen mode.");
                //}
                else
                    MessageBox.Show("Please select a hotkey.", "Error");
            }
            else
                MessageBox.Show("Please open the Logger first.", "Error");
        }

        public static bool isProcessFocused(int processId)
        {
            // checking if a process is in focus
            // don't really get this

            IntPtr fgWin = GetForegroundWindow();
            if (fgWin == IntPtr.Zero)
            {
                return false;
            }
            int fgProc;
            GetWindowThreadProcessId(fgWin, out fgProc);
            return processId == fgProc;
        }

        private bool loggerIsRunning()
        {
            // checking if the logger is running 
            Process[] logger = Process.GetProcessesByName("Synergy.BaseballLogger.WinApp");
            if (logger.Length == 0)
                return false;
            else
                return true;
        }

        private Tuple<int, int> GetPixels()
        {
            // makes a pair of x,y for where the color was found in the screenshot

            // green from the apply button
            Color c = Color.FromArgb(30, 165, 46);

            for (int y = 5 * Screen.PrimaryScreen.Bounds.Height / 6; y < ss.Height; y++)
                for (int x = 2 * Screen.PrimaryScreen.Bounds.Width / 5; x < ss.Width; x++)
                    if (ss.GetPixel(x, y) == c)
                    {
                        pos = Tuple.Create(x, y);
                        return pos;
                    }
            return null;
        }

        protected override void WndProc(ref Message m)
        {
            // processes windows messages

            Process[] logger = Process.GetProcessesByName("Synergy.BaseballLogger.WinApp");
            if (m.Msg == 0x0312) // detect a hotkey
            {
                IntPtr i = m.WParam; // id of the hotkey that was pressed
                if (logger.Length != 0) // isProcessFocused(logger[0].Id) breaks if array is empty
                {
                    if (isProcessFocused(logger[0].Id)) //if logger is focused
                    {
                        if ((int)i == 1) // look at hotkey IDs up
                        {
                            // taking a screenshot
                            Graphics g = Graphics.FromImage(ss);
                            Size s = new Size(ss.Width, ss.Height);
                            g.CopyFromScreen(0, 0, 0, 0, s);
                            GetPixels();
                            this.Cursor = new Cursor(Cursor.Current.Handle);
                            Point firstPos = Cursor.Position;  // current cursor position

                            if (pos != null)
                            {
                                if (onlyApply)
                                {
                                    // only clicks the apply button
                                    Cursor.Position = new Point(pos.Item1 + 22, pos.Item2 + 13);
                                    LeftClick();
                                    Cursor.Position = firstPos;
                                }
                                else
                                {
                                    // clicks both apply and next clip at once
                                    Cursor.Position = new Point(pos.Item1 + 22, pos.Item2 + 13);
                                    LeftClick();
                                    Cursor.Position = new Point(pos.Item1 + 253, pos.Item2 + 13);
                                    LeftClick();
                                    Cursor.Position = firstPos;


                                }
                            }
                        }
                        else if ((int)i == 2)
                        {
                            this.Cursor = new Cursor(Cursor.Current.Handle);
                            Point firstPos = Cursor.Position;  // current cursor position                 
                            Cursor.Position = new Point(p1.Item1, p1.Item2);
                            LeftClick();
                            Cursor.Position = new Point(p2.Item1, p2.Item2);
                            LeftClick();
                            Cursor.Position = new Point(p3.Item1, p3.Item2);
                            LeftClick();
                            Cursor.Position = new Point(p4.Item1, p4.Item2);
                            LeftClick();
                            Cursor.Position = new Point(p5.Item1, p5.Item2);
                            LeftClick();
                            Cursor.Position = new Point(p6.Item1, p6.Item2);
                            LeftClick();
                            Cursor.Position = firstPos;
                        }
                        else
                        {
                            // if Ctrl + F12 was pressed
                            this.Visible = true;
                            mainForm.UnregisterHotKey(this.Handle, 1);
                            mainForm.UnregisterHotKey(this.Handle, 0);
                        }
                    }
                    else
                    {
                        if ((int)i == 0)
                        {
                            // be able to unregister hotkeys even if the logger isn't focused
                            this.Visible = true;
                            mainForm.UnregisterHotKey(this.Handle, 1);
                            mainForm.UnregisterHotKey(this.Handle, 0);
                        }
                    }
                }
                if ((int)i == 0)
                {
                    // be able to unregister even if the logger isn't running
                    this.Visible = true;
                    mainForm.UnregisterHotKey(this.Handle, 1);
                    mainForm.UnregisterHotKey(this.Handle, 0);
                }
            }
            base.WndProc(ref m);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // opens the About (Help) form page
            fHelp h = new fHelp();
            h.Show();
        }

        private void btnStartClick_Click(object sender, EventArgs e)
        {
            dashboard = Process.GetProcessesByName("Synergy Logger Dashboard");

            if (dashboard.Length == 0)
                MessageBox.Show("Please open the Dashboard first.");
            else
            {
                ti = new timeInputForm(this);
                ti.Show();
            }
        }

        public void timerFormCallback(bool clicked)
        {
            // to be able to start the timer from timerInput
            if (clicked)
            {
                timer1.Start();
                btnStopClick.Enabled = true;
                btnStartClick.Enabled = false;
                lbClick.Text = "Clicking until " + ti.stopTime.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //dashboardss = new Bitmap();
            //   Graphics g = Graphics.FromImage(dashboardss);
            //   Size s = new Size(dashboardss.Width, dashboardss.Height);
            //  g.CopyFromScreen(0, 0, 0, 0, s);

            string currentTime = DateTime.Now.ToLongTimeString();
            if (currentTime == ti.stopTime)
            {
                timer1.Stop();
                btnStopClick.Enabled = false;
                btnStartClick.Enabled = true;
                MessageBox.Show("Done clicking, no game found.");
            }

            foreach (Process p in dashboard)
                if (isProcessFocused(p.Id))
                    LeftClick();

            // randomizes autoclicking
            int rand = r.Next(3);
            if (rand == 0 || rand == 1)
                timer1.Interval = r.Next(7, 15) * 1000;
            else
                timer1.Interval = r.Next(0, 5) * 1000 + 1;
        }

        private void btnStopClick_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStopClick.Enabled = false;
            btnStartClick.Enabled = true;
            lbClick.Text = "Autoclicking:";
        }


    }
}
