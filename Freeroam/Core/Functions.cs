using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Freeroam.Core
{
    class Functions : IScript
    {
        public static void SendChatMessageToAll(string text)
        {
            foreach(IPlayer player in Alt.GetAllPlayers())
            {
                player?.SendChatMessage(text);
            }
        }

        public static string GetHexColorcode(int r, int g, int b)
        {
            Color myColor = Color.FromArgb(r, g, b);
            return "{" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2") + "}";
        }


    }
}
