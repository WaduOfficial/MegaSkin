using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using MegaSkin.Checker;
using Leaf.xNet;
using System.IO;
using MegaSkin.Forms;

namespace MegaSkin.Pages
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Globals.RunningProxyless == true) ProxyTypeOption.SelectedIndex = ProxyTypeOption.FindString("proxyless");
            else ProxyTypeOption.SelectedIndex = ProxyTypeOption.FindString(Globals.proxyType.ToString());

            if (Globals.isRunning == true)
            {
                LoadCombosBTN.Text = $"Loaded {Globals.LoadedCombos} Combos";
                LoadProxiesBTN.Text = $"Loaded {Globals.LoadedProxies} Proxies";

                ThreadsTXT.Text = Globals.Threads.ToString();
                ProxyTImeoutTXT.Text = Globals.ProxyTimeout.ToString();

                StartBTN.Enabled = false;
                StopBTN.Enabled = true;

                LoadCombosBTN.Enabled = false;
                LoadProxiesBTN.Enabled = false;
                ThreadsTXT.Enabled = false;

                ProxyTImeoutTXT.Enabled = false;
                ProxyTypeOption.Enabled = false;

                DoSkinChecker.Enabled = false;
            }
            else
            {
                StopBTN.Enabled = false;
            }

            using (HttpRequest req = new HttpRequest())
            {
                try
                {
                    req.IgnoreProtocolErrors = false;
                    req.AllowAutoRedirect = false;
                    req.Proxy = null;

                    NewsTXT.Text = req.Get("https://pastebin.com/raw/6cXSaCmg", null).ToString();
                }
                catch (Exception)
                {
                    NewsTXT.Text = "ERR:SERVER_ERROR";
                }
            }
        }

        private void LoadCombosBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;
                ofd.RestoreDirectory = true;
                ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                ofd.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = @"Load combos";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                List<string> combos = File.ReadAllLines(ofd.FileName).ToList();

                if (Globals.Combo.Count() != 0 || Globals.Combo.IsEmpty != true)
                {
                    while (Globals.Combo.Count() != 0)
                    {
                        Globals.Combo.TryDequeue(out string combo);
                    }
                }

                foreach (string combo in combos)
                {
                    if (combo.Contains("@"))
                    {
                        if (combo.Contains(":") || combo.Contains(";") || combo.Contains("|"))
                        {
                            Globals.Combo.Enqueue(combo);
                        }
                    }
                }

                Globals.LoadedCombos = Globals.Combo.Count();

                LoadCombosBTN.Text = $"Loaded {Globals.LoadedCombos} Combos";
            }
        }

        private void LoadProxiesBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;
                ofd.RestoreDirectory = true;
                ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                ofd.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = @"Load proxies";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                List<string> proxies = File.ReadAllLines(ofd.FileName).ToList();

                if (Globals.Proxy.Count() != 0 || Globals.Proxy.IsEmpty != true)
                {
                    while (Globals.Proxy.Count() != 0)
                    {
                        Globals.Proxy.TryDequeue(out string proxy);
                    }
                }

                foreach (string proxy in proxies)
                {
                    if (proxy.Contains(":") || proxy.Contains(";") || proxy.Contains("|"))
                    {
                        Globals.Proxy.Enqueue(proxy);
                    }
                }

                Globals.LoadedProxies = Globals.Proxy.Count();

                LoadProxiesBTN.Text = $"Loaded: {Globals.LoadedProxies} Proxies";
            }
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            if (Globals.Combo.Count == 0 || Globals.Combo.IsEmpty == true) { MessageBox.Show("You did not load any combos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) != "Proxyless")
            {
                if (Globals.Proxy.Count == 0 || Globals.Proxy.IsEmpty == true) { MessageBox.Show("You did not load any proxies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }

            if (!Directory.Exists("Results")) Directory.CreateDirectory("Results");
            Directory.CreateDirectory($"Results/{Globals.ResultsFolder}");
            Directory.CreateDirectory($"Results/{Globals.ResultsFolder}/Rares");
            Directory.CreateDirectory($"Results/{Globals.ResultsFolder}/Skins");
            Directory.CreateDirectory($"Results/{Globals.ResultsFolder}/V-Bucks");

            LoadCombosBTN.Enabled = false;
            LoadProxiesBTN.Enabled = false;
            StartBTN.Enabled = false;
            StopBTN.Enabled = true;
            ThreadsTXT.Enabled = false;
            ProxyTImeoutTXT.Enabled = false;
            ProxyTypeOption.Enabled = false;
            DoSkinChecker.Enabled = false;

            StartWorker();
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            Globals.Threads = 0;
            Globals.isRunning = false;
            if (RunThreads.WorkerSupportsCancellation == true) RunThreads.CancelAsync();

            LoadCombosBTN.Enabled = true;
            LoadProxiesBTN.Enabled = true;
            StartBTN.Enabled = true;
            StopBTN.Enabled = false;
            ThreadsTXT.Enabled = true;
            ProxyTImeoutTXT.Enabled = true;
            ProxyTypeOption.Enabled = true;
            DoSkinChecker.Enabled = true;
        }

        private void ProxyTypeOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) == "Proxyless")
            {
                if (Globals.Combo.Count() != 0) LoadCombosBTN.Text = $"Loaded: {Globals.Combo.Count()} Combos";

                LoadProxiesBTN.Text = "Running Proxyless";
                LoadProxiesBTN.Enabled = false;
                ThreadsTXT.Text = "20";
                ProxyTImeoutTXT.Enabled = false;
            }
            else
            {
                if (Globals.Combo.Count() != 0) LoadCombosBTN.Text = $"Loaded: {Globals.Combo.Count()} Combos";
                if (Globals.Proxy.Count() != 0) LoadProxiesBTN.Text = $"Loaded: {Globals.Proxy.Count()} Proxies";

                ThreadsTXT.Enabled = true;
                LoadProxiesBTN.Enabled = true;
                ProxyTImeoutTXT.Enabled = true;
            }
        }

        private void StartWorker()
        {
            Globals.isRunning = true;
            Globals.Threads = int.Parse(ThreadsTXT.Text);
            Globals.ProxyTimeout = int.Parse(ProxyTImeoutTXT.Text);

            if (DoSkinChecker.Checked == true) Globals.DoSkinChecker = true;

            if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) == "HTTP/s") Globals.proxyType = ProxyType.HTTP;
            else if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) == "Socks-4") Globals.proxyType = ProxyType.Socks4;
            else if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) == "Socks-4a") Globals.proxyType = ProxyType.Socks4A;
            else if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) == "Socks-5") Globals.proxyType = ProxyType.Socks5;
            else if (ProxyTypeOption.GetItemText(ProxyTypeOption.SelectedItem) == "Proxyless") Globals.RunningProxyless = true;
            else return;

            if (RunThreads.IsBusy == false) RunThreads.RunWorkerAsync();

            Main.form.MenuHolderPanel.Controls.Clear();
            Main.form.MenuHolderPanel.Controls.Add(new Stats());
            Main.form.MenuHolderPanel.BringToFront();

            Main.form.ResetColors();
            Main.form.MenuHolderPanel.BringToFront();
            Main.form.StatsMenuBTN.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            Main.form.MenuSliderPanel.Height = Main.form.StatsMenuBTN.Height;
            Main.form.MenuSliderPanel.Top = Main.form.StatsMenuBTN.Top;
        }

        private void RunThreads_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Thread> ThreadList = new List<Thread>();

            for (int i = 0; i < Globals.Threads; i++)
            {
                ThreadList.Add(new Thread(new ThreadStart(Check.CallWorker))
                {
                    IsBackground = true
                });
                ThreadList[i].Start();
            }
        }
    }
}
