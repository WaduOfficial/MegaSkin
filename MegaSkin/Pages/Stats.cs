using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MegaSkin.Checker;

namespace MegaSkin.Pages
{
    public partial class Stats : UserControl
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            RefreshUI();
            if (Globals.isRunning == true) { UpdateUI.Enabled = true; CPMCounter.Enabled = true; }
        }

        private void UpdateUI_Tick(object sender, EventArgs e)
        {
            RefreshUI();

            if (Globals.isRunning == false) UpdateUI.Enabled = false;
        }

        private void RefreshUI()
        {
            int Checked = Globals.Invalid + Globals.Valid + Globals.Banned + Globals.NeedAuth;

            ValidLB.Text = Globals.Valid.ToString();
            InvalidLB.Text = Globals.Invalid.ToString();
            NeedAuthLB.Text = Globals.NeedAuth.ToString();
            BannedLB.Text = Globals.Banned.ToString();
            NoSkinLB.Text = Globals.NoSkins.ToString();
            HasSkinsLB.Text = Globals.Skinned.ToString();
            RareLB.Text = Globals.Rares.ToString();
            CheckedLB.Text = Checked.ToString();
            RemainingLB.Text = (Globals.LoadedCombos - Checked).ToString();
            RetriesLB.Text = Globals.Errors.ToString();

            GalaxyLB.Text = Globals.Galaxy.ToString();
            s10LB.Text = Globals.IKONIK.ToString();
            EonLB.Text = Globals.Eon.ToString();
            RbLB.Text = Globals.Rb.ToString();
            ReflexLB.Text = Globals.Reflex.ToString();
            HonorLB.Text = Globals.Honor.ToString();
            HonorGirlLB.Text = Globals.Wonder.ToString();

            BkLB.Text = Globals.BK.ToString();
            SparkSLB.Text = Globals.SS.ToString();
            CodenameLB.Text = Globals.CodeName.ToString();
            HeidiLB.Text = Globals.Heidi.ToString();
            MakoLB.Text = Globals.Mako.ToString();
            AAOneLB.Text = Globals.AA1.ToString();
            OtherRaresLB.Text = Globals.Other.ToString();

            ReconELB.Text = Globals.RE.ToString();
            RenegadeLB.Text = Globals.RR.ToString();
            GhoulLB.Text = Globals.GT.ToString();
            OGSkullLB.Text = Globals.OG_SKULL.ToString();
            AerialATLB.Text = Globals.Aerial.ToString();
            RrAxeLB.Text = Globals.RR_AXE.ToString();

            Skins1.Text = Globals.Max10.ToString();
            Skins10.Text = Globals.Max25.ToString();
            Skins25.Text = Globals.Max50.ToString();
            Skins50.Text = Globals.Max100.ToString();
        }

        private void CPMCounter_Tick(object sender, EventArgs e)
        {
            CpmLB.Text = (Globals.CPS * 60).ToString();
            Globals.CPS = 0;
            if (Globals.isRunning == false) CPMCounter.Enabled = false;
        }
    }
}
