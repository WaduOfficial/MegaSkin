using System;
using System.Drawing;
using System.Windows.Forms;
using MegaSkin.Checker;
using MegaSkin.Pages;

namespace MegaSkin.Forms
{
    public partial class Main : Form
    {
        public static Main form = null;

        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        private const int WM_NCLBUTTONDBLCLK = 0x00A3;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - Left;
            MouseY = Cursor.Position.Y - Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Top = Cursor.Position.Y - MouseY;
                Left = Cursor.Position.X - MouseX;
            }
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(100, 100, 100), ButtonBorderStyle.Solid);
        }

        public Main()
        {
            form = this;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*MainMenuBTN.Text = "        Login";
            MainMenuBTN.Enabled = false;
            StatsMenuBTN.Enabled = false;
            SettingsMenuBTN.Enabled = false;
            AboutMenuBTN.Enabled = false;*/

            MenuHolderPanel.Controls.Add(new Home());
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.Threads = 0;
            Globals.isRunning = false;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MiniBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void ResetColors()
        {
            MainMenuBTN.BackColor = Color.FromArgb(34, 34, 33);
            StatsMenuBTN.BackColor = Color.FromArgb(34, 34, 33);
            SettingsMenuBTN.BackColor = Color.FromArgb(34, 34, 33);
            AboutMenuBTN.BackColor = Color.FromArgb(34, 34, 33);
        }

        private void MainMenuBTN_Click(object sender, EventArgs e)
        {
            ResetColors();
            MainMenuBTN.BackColor = Color.FromArgb(40, 40, 40);
            MenuSliderPanel.Height = MainMenuBTN.Height;
            MenuSliderPanel.Top = MainMenuBTN.Top;

            MenuHolderPanel.Controls.Clear();
            MenuHolderPanel.Controls.Add(new Home());
        }

        private void StatsMenuBTN_Click(object sender, EventArgs e)
        {
            ResetColors();
            StatsMenuBTN.BackColor = Color.FromArgb(40, 40, 40);
            MenuSliderPanel.Height = StatsMenuBTN.Height;
            MenuSliderPanel.Top = StatsMenuBTN.Top;

            MenuHolderPanel.Controls.Clear();
            MenuHolderPanel.Controls.Add(new Stats());
        }

        private void SettingsMenuBTN_Click(object sender, EventArgs e)
        {
            ResetColors();
            SettingsMenuBTN.BackColor = Color.FromArgb(40, 40, 40);
            MenuSliderPanel.Height = SettingsMenuBTN.Height;
            MenuSliderPanel.Top = SettingsMenuBTN.Top;

            MenuHolderPanel.Controls.Clear();
            MenuHolderPanel.Controls.Add(new Settings());
        }

        private void AboutMenuBTN_Click(object sender, EventArgs e)
        {
            ResetColors();
            AboutMenuBTN.BackColor = Color.FromArgb(40, 40, 40);
            MenuSliderPanel.Height = AboutMenuBTN.Height;
            MenuSliderPanel.Top = AboutMenuBTN.Top;

            MenuHolderPanel.Controls.Clear();
            MenuHolderPanel.Controls.Add(new About());
        }
    }
}
