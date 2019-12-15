using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MegaSkin.Pages
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void CopyDiscordOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(CopyDiscordOwner.Text);
            MessageBox.Show("Copied to clipboard!", "MegaSkin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyDiscordServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/MJp6u4z");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://megashops.selly.store/");
        }

        private void CopyDiscordCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(CopyDiscordCreator.Text);
            MessageBox.Show("Copied to clipboard!", "MegaSkin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
