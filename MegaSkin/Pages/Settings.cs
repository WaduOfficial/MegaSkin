using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MegaSkin.Pages
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            if (File.Exists("Settings.MegaSkin")) Program.LoadSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (UserData.SaveNoSkins == true) SaveNoSkins.Checked = true;
            if (UserData.LogVbucksAmount != 0) { VBucksChecker.Checked = true; VBucksTXT.Text = UserData.LogVbucksAmount.ToString(); }
            else { VBucksChecker.Checked = false; VBucksTXT.Enabled = false; }
            if (UserData.LogSkinsAmount != 0) { SkinsChecker.Checked = true; SkinsTXT.Text = UserData.LogSkinsAmount.ToString(); }
            else { SkinsChecker.Checked = false; SkinsTXT.Enabled = false; }

            if (UserData.Rares.Count != 0)
            {
                UserAddSkinsChecker.Checked = true;

                foreach (string line in UserData.Rares)
                {
                    UserAddSkinsIDK.Text += line + Environment.NewLine;
                }
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (File.Exists("Settings.MegaSkin")) File.Delete("Settings.MegaSkin");

            List<string> Settings = new List<string>();

            if (SaveNoSkins.Checked == true) Settings.Add("SaveNoSkins:True");
            else Settings.Add("SaveNoSkins:False");

            if (VBucksTXT.Enabled == true) Settings.Add($"VBucks:True:{VBucksTXT.Text}");
            else Settings.Add("VBucks:False");

            if (SkinsChecker.Checked == true) Settings.Add($"Skins:True:{SkinsTXT.Text}");
            else Settings.Add("Skins:False");

            if (UserAddSkinsIDK.Enabled == true)
            {
                if (UserAddSkinsIDK.Text != "" || string.IsNullOrEmpty(UserAddSkinsIDK.Text))
                {
                    Settings.Add("UserRares:True");

                    if (File.Exists("Rares.MegaSkin")) File.Delete("Rares.MegaSkin");
                    File.AppendAllText("Rares.MegaSkin", UserAddSkinsIDK.Text.ToLower() + Environment.NewLine);
                }
                else Settings.Add("UserRares:False");
            }
            else Settings.Add("UserRares:False");

            Task.Run(() =>
            {
                using (StreamWriter write = new StreamWriter("Settings.MegaSkin"))
                {
                    foreach (string line in Settings)
                    {
                        try
                        {
                            write.WriteLineAsync(line);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            });

            MessageBox.Show("Saved!", "MegaSkin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VBucksChecker_CheckedChanged(object sender, bool isChecked)
        {
            if (VBucksChecker.Checked == true) VBucksTXT.Enabled = true;
            else VBucksTXT.Enabled = false;
        }

        private void SkinsChecker_CheckedChanged(object sender, bool isChecked)
        {
            if (SkinsChecker.Checked == true) SkinsTXT.Enabled = true;
            else SkinsTXT.Enabled = false;
        }

        private void UserAddSkinsChecker_CheckedChanged(object sender, bool isChecked)
        {
            if (UserAddSkinsChecker.Checked == true) UserAddSkinsIDK.Enabled = true;
            else UserAddSkinsIDK.Enabled = false;
        }

        private void GetIDSBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1gVDgnzNyMCafIWa-dBO3mgNUHmHzgA9O5sWbfQy2Yfg");
        }
    }
}
