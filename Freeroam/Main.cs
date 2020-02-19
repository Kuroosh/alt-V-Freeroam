using System;
using AltV.Net;
using AltV.Net.Elements.Entities;
using Freeroam.Globals;

namespace Freeroam
{
    internal class MyResource : Resource
    {
        public override void OnStart()
        {
            Console.WriteLine("Freeroam Started");
        }

        public override void OnStop()
        {
            Console.WriteLine("Freeroam Stopped");
        }
    }
    public class Main : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void OnPlayerConnect(IPlayer player, string reason)
        {
            try { 
                Lobby.Spawns.SpawnPlayer(player);
                Core.Functions.SendChatMessageToAll(player.Name + " has " + Constants.COLOR_CONNECT + " joined " + Constants.COLOR_WHITE + " the Server!");
            }
            catch (Exception ex) { Core.Debug.CatchExceptions("OnPlayerConnect", ex); }
        }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public static void OnPlayerDisconnect(IPlayer player, string reason)
        {
            try {
                Core.Functions.SendChatMessageToAll(player.Name + " has " + Constants.COLOR_DISCONNECT + " left " + Constants.COLOR_CONNECT + " the Server! Reason : " + reason);
            }
            catch (Exception ex) { Core.Debug.CatchExceptions("OnPlayerConnect", ex); }
        }
    }
}

