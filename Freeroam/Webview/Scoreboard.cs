using AltV.Net;
using AltV.Net.Elements.Entities;
using Freeroam.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freeroam.Webview
{
    public class Scoreboard
    {
        public static List<ScoreboardModel> _Playerlist;
        public static void Update()
        {
            _Playerlist = new List<ScoreboardModel>();
            foreach (IPlayer player in Alt.GetAllPlayers())
            {
                ScoreboardModel Client = new ScoreboardModel
                {
                    SpielerName = player?.Name,
                    Ping = player?.Ping.ToString()
                };
                _Playerlist.Add(Client);
            }
        }

        public static void OnScoreboardUpdate(Object unused)
        {
            Update();
            Alt.EmitAllClients("Scoreboard:Update", JsonConvert.SerializeObject(_Playerlist));
            Core.Debug.OutputDebugString("Scoreboard Updatet. [Player Count " + Alt.GetAllPlayers().Count + "]");
        }


    }
}
