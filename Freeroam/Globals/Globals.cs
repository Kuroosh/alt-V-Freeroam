using AltV.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Freeroam.Globals
{
    public class Main
    {
        public static void OnResourceStart()
        {
            Timer timer = new Timer(Webview.Scoreboard.OnScoreboardUpdate, null, 7000, 7000);
        }
    }
}
