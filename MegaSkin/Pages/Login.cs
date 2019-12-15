using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Leaf.xNet;
using System.IO;
using Microsoft.Win32;
using MegaSkin.Forms;

namespace MegaSkin.Pages
{
    public partial class Login : UserControl
    {
        public static bool isValid;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            StatusLB.Text = null;

            if (File.Exists("info.MegaSkin"))
            {
                try
                {
                    string Line = File.ReadAllText("info.MegaSkin");

                    if (Line.Contains(":"))
                    {
                        string username = Line.Split(':')[0].ToString().Replace(" ", "");
                        string password = Line.Split(':')[1].ToString().Replace(" ", "");

                        UsernameTXT.Text = username;
                        PasswordTXT.Text = password;
                    }
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            StatusLB.Text = "Please Wait...";
            Program.CheckDebugger();
            DoLogin();
        }

        private void DoLogin()
        {
            using (HttpRequest req = new HttpRequest())
            {
                try
                {
                    req.Proxy = null;
                    string data = req.Get("https://pastebin.com/raw/s3V6Wuwj", null).ToString();

                    if (data.Contains($"{UsernameTXT.Text}:{PasswordTXT.Text}:{HWID()}"))
                    {
                        if (SaveLoginInfo.Checked == true)
                        {
                            if (File.Exists("info.MegaSkin")) File.Delete("info.MegaSkin");
                            File.AppendAllText(string.Concat("info.MegaSkin"), string.Concat($"{UsernameTXT.Text}:{PasswordTXT.Text}"));
                        }

                        Main.form.MainMenuBTN.Text = "        Main";
                        Main.form.MainMenuBTN.Enabled = true;
                        Main.form.StatsMenuBTN.Enabled = true;
                        Main.form.SettingsMenuBTN.Enabled = true;
                        Main.form.AboutMenuBTN.Enabled = true;

                        Main.form.MenuHolderPanel.Controls.Clear();
                        Main.form.MenuHolderPanel.Controls.Add(new Home());
                        Main.form.MenuHolderPanel.BringToFront();
                    }
                    else if (data.Contains($"{UsernameTXT.Text}:{PasswordTXT.Text}"))
                    {
                        Clipboard.SetText(HWID());
                        StatusLB.Text = "Invalid HWID. Your HWID is copied to your clipboard.";
                    }
                    else
                    {
                        StatusLB.Text = "Invalid login credentials";
                    }
                }
                catch (Exception)
                {
                    StatusLB.Text = "An error occurred.";
                }
            }
        }

        private string HWID()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null) throw new KeyNotFoundException(string.Format("Key Not Found: {0}", location));

                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null) throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", name));

                    return machineGuid.ToString();
                }
            }
        }
    }
}
