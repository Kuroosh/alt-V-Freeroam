using AltV.Net;
using AltV.Net.Elements.Entities;
using System;
using Freeroam.Globals;

namespace Freeroam.Lobby
{
    class Spawns : IScript
    {

        private static int PLAYER_SPAWNS_COUNT = Constants.PLAYER_SPAWNS.Count;

        public static void SpawnPlayer(IPlayer player)
        {
            try
            {
                int RandomNumberSpawns = Constants.GetRandomNumber(Constants.PLAYER_SPAWNS.Count);
                int RandomNumberModels = Constants.GetRandomNumber(Constants.PLAYER_SKIN_MODELS.Count);

                player.Spawn(Constants.PLAYER_SPAWNS[RandomNumberSpawns], 0);
                player.Model = Alt.Hash(Constants.PLAYER_SKIN_MODELS[RandomNumberModels]);

            }
            catch(Exception ex) { Core.Debug.CatchExceptions("SpawnPlayer", ex); }
        }
    }
}
