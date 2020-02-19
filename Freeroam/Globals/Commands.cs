using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using System;

namespace Freeroam.Globals
{
    public class Commands : IScript
    {
        [Command(Constants.COMMAND_POS)]
        public static void SendPlayerLocalPosition(IPlayer player)
        {
            Position pos = player.Position;
            player.SendChatMessage(Constants.COLOR_GREEN + "Your Position is : X: " + pos.X + " | Y: " + pos.Y + " | Z: " + pos.Z);
            Console.WriteLine(pos.X + "f," + pos.Y + "f," + pos.Z + "f");
            Console.WriteLine(player.Rotation);
        }

        [Command(Constants.COMMAND_GOTO)]
        public static void GotoTargetPlayer(IPlayer player, IPlayer target)
        {
            if(target == null) { player.SendChatMessage("Error 404 : Player not Found!"); return; }
            player.SendChatMessage(Constants.COLOR_GREEN + "You have teleported yourself to " + target?.Name);
            target.SendChatMessage(Constants.COLOR_GREEN + player.Name + " teleported his self to you!");
            player.Position = target.Position;
        }

        [Command(Constants.COMMAND_VEHICLE)]
        public static void CreateVehicle(IPlayer player, string VehicleName, int R = 0, int G = 0, int B = 0){
            IVehicle veh = Alt.CreateVehicle(Alt.Hash(VehicleName), new Position(player.Position.X, player.Position.Y + 1.5f, player.Position.Z), player.Rotation);
            if (veh != null) { player.SendChatMessage(Constants.COLOR_GREEN + "You just Created a " + VehicleName); }
        }
    }
}
