using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Leaf.xNet;

namespace MegaSkin.Checker
{
    class Globals
    {
        public static ConcurrentQueue<string> Combo = new ConcurrentQueue<string>();
        public static ConcurrentQueue<string> Proxy = new ConcurrentQueue<string>();

        public static List<string> RareSkins = new List<string>();

        public static bool isRunning;
        public static bool DoSkinChecker;
        public static bool RunningProxyless;

        public static int Threads;
        public static int ProxyTimeout;
        public static int CPS;

        public static int LoadedCombos;
        public static int LoadedProxies;

        public static int Valid;
        public static int Rares;
        public static int Invalid;
        public static int NoSkins;
        public static int Skinned;
        public static int Errors;
        public static int NeedAuth;
        public static int Banned;

        public static ProxyType proxyType;

        public static string ResultsFolder = $@"\{DateTime.Now:MM-dd-yy HH;mm tt}";

        // Exclusives
        public static int Galaxy;
        public static int IKONIK;
        public static int Eon;
        public static int Rb;
        public static int Reflex;
        public static int Honor;
        public static int Wonder;

        // Rares
        public static int BK;
        public static int SS;
        public static int CodeName;
        public static int Heidi;
        public static int Mako;
        public static int AA1;
        public static int Other;

        // Ogs
        public static int RE;
        public static int GT;
        public static int OG_SKULL;
        public static int Aerial;
        public static int RR;
        public static int RR_AXE;

        // Skins
        public static int Max10;
        public static int Max25;
        public static int Max50;
        public static int Max100;
    }
}
