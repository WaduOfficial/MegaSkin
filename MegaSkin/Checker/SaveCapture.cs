using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MegaSkin.Checker
{
    class SaveCapture
    {
        public static void WriteToDisk(string combo, string id, string created, string username, string isFA, int vbucks, List<string> Skins, List<string> Backblings, List<string> Pickaxes, List<string> Gliders, List<string> Rares)
        {
            string SkinList = string.Join(Environment.NewLine, Skins.ToArray());
            string BackBlingsList = string.Join(Environment.NewLine, Backblings.ToArray());
            string PickaxesList = string.Join(Environment.NewLine, Pickaxes.ToArray());
            string GlidersList = string.Join(Environment.NewLine, Gliders.ToArray());
            string RareSkins = string.Join(Environment.NewLine, Rares.ToArray());

            string Format = string.Concat(new object[]
            {
                "|---------------| Account Information |---------------|",
                Environment.NewLine,
                $"-> Login: {combo}",
                Environment.NewLine,
                $"-> FA: {isFA}",
                Environment.NewLine,
                $"-> ID: {id}",
                Environment.NewLine,
                $"-> Created: {created}",
                Environment.NewLine,
                $"-> Display Name: {username}",
                Environment.NewLine,
                $"-> V-Bucks: {vbucks}",
                Environment.NewLine,
                $"-> Rares: {Rares.Count()}",
                Environment.NewLine,
                $"-> Skins: {Skins.Count()}",
                Environment.NewLine,
                $"-> Backblings: {Backblings.Count()}",
                Environment.NewLine,
                $"-> Pickaxes: {Pickaxes.Count()}",
                Environment.NewLine,
                $"-> Gliders: {Gliders.Count()}",
                Environment.NewLine,
                "|----------------------| Rares |----------------------|",
                Environment.NewLine,
                RareSkins,
                Environment.NewLine,
                "|----------------------| Skins |----------------------|",
                Environment.NewLine,
                SkinList,
                Environment.NewLine,
                "|--------------------| Backblings |-------------------|",
                Environment.NewLine,
                BackBlingsList,
                Environment.NewLine,
                "|---------------------| Pickaxes |--------------------|",
                Environment.NewLine,
                PickaxesList,
                Environment.NewLine,
                "|----------------------| Gliders |--------------------|",
                Environment.NewLine,
                GlidersList,
                Environment.NewLine,
                "|----------------------------------------------------|",
                Environment.NewLine
            });

            /*foreach (string text in UserData.Rares)
            {
                if (SkinList.Contains(text))
                {

                }
            }*/

            File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Capture.txt"), string.Concat(Format, Environment.NewLine));

            if (Skins.Count != 0)
            {
                if (Skins.Count >= 50) { File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Skins", "/50-100+.txt"), string.Concat($"{combo} - {Skins.Count()} Skins", Environment.NewLine)); Globals.Max100++; }
                else if (Skins.Count >= 25) { File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Skins", "/25-50.txt"), string.Concat($"{combo} - {Skins.Count()} Skins", Environment.NewLine)); Globals.Max50++; }
                else if (Skins.Count >= 10) { File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Skins", "/10-25.txt"), string.Concat($"{combo} - {Skins.Count()} Skins", Environment.NewLine)); Globals.Max25++; }
                else if (Skins.Count >= 1) { File.AppendAllText(string.Concat("Results/", Globals.ResultsFolder, "/Skins", "/1-10.txt"), string.Concat($"{combo} - {Skins.Count()} Skins", Environment.NewLine)); Globals.Max10++; }
            }
        }
    }
}
