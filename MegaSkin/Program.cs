using System;
using MegaSkin.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace MegaSkin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            foreach (var process in Process.GetProcessesByName("DnSpy-x86"))
            {
                Environment.Exit(0);
            }

            if (File.Exists("Settings.MegaSkin")) LoadSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void LoadSettings()
        {
            List<string> Settings = File.ReadAllLines("Settings.MegaSkin").ToList();

            Task.Run(() =>
            {
                foreach (string line in Settings)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            if (line.Contains("SaveNoSkins"))
                            {
                                if (line.Contains("True"))
                                {
                                    UserData.SaveNoSkins = true;
                                }
                                else
                                {
                                    UserData.SaveNoSkins = false;
                                }
                            }
                            else if (line.Contains("VBucks"))
                            {
                                if (line.Contains("True"))
                                {
                                    try
                                    {
                                        UserData.LogVbucksAmount = int.Parse(line.Split(':')[2]);
                                    }
                                    catch
                                    {
                                        UserData.LogVbucksAmount = 0;
                                    }
                                }
                                else
                                {
                                    UserData.LogVbucksAmount = 0;
                                }
                            }
                            else if (line.Contains("Skins"))
                            {
                                if (line.Contains("True"))
                                {
                                    try
                                    {
                                        UserData.LogSkinsAmount = int.Parse(line.Split(':')[2]);
                                    }
                                    catch
                                    {
                                        UserData.LogSkinsAmount = 0;
                                    }
                                }
                                else
                                {
                                    UserData.LogSkinsAmount = 0;
                                }
                            }
                            else if (line.Contains("UserRares"))
                            {
                                if (line.Contains("True"))
                                {
                                    if (File.Exists("Rares.MegaSkin"))
                                    {
                                        List<string> Rares = File.ReadAllLines("Rares.MegaSkin").ToList();

                                        foreach (string text in Rares)
                                        {
                                            if (!string.IsNullOrEmpty(text) || text == "")
                                            {
                                                if (!UserData.Rares.Contains(text))
                                                {
                                                    UserData.Rares.Add(text);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {

                                }
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            });
        }

        public static void CheckDebugger()
        {
            string[] strArrays1 = new string[] { "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug", "fiddler", "wireshark", "proxifier", "mitmproxy" };
            Debugger.Log(0, null, "%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s");

            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];
                if (process != Process.GetCurrentProcess())
                {
                    for (int j = 0; j < strArrays1.Length; j++)
                    {
                        int id = Process.GetCurrentProcess().Id;
                        if (process.ProcessName.ToLower().Contains(strArrays1[j]))
                        {
                            object[] processName = new object[] { "START CMD /C \"ECHO Debugger program detected ! (HResult 0x04)", process.ProcessName, " : {", j, "} && PAUSE\" " };
                            MemberFilter(string.Concat(processName));
                            Process.GetCurrentProcess().Kill();
                        }
                        if (process.MainWindowTitle.ToLower().Contains(strArrays1[j]))
                        {
                            object[] objArray = new object[] { "START CMD /C \"ECHO Debugger program detected ! (HResult 0x04)", process.ProcessName, " : {", j, "} && PAUSE\" " };
                            MemberFilter(string.Concat(objArray));
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                }
            }
        }

        private static void MemberFilter(string A_0)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", string.Concat("/c ", A_0))
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(processStartInfo);
        }
    }
}
