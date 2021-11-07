using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballPlayer;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Simple_REST_Service.Managers
{
    public class FootBallPlayersManager
    {
        private static int _nextId = 1;

        private static readonly List<FBPlayer> Data = new List<FBPlayer>()
        {
            new FBPlayer("john", 13, _nextId++, 13),
            new FBPlayer("jen", 31, _nextId++, 31)
        };

        public List<FBPlayer> GetAll()
        {
            return new List<FBPlayer>(Data);
        }

        public FBPlayer GetById(int id)
        {
            return Data.Find(Item => Item.Id == id);
        }

        public FBPlayer Add(FBPlayer newFBPlayer)
        {
            newFBPlayer.Id = _nextId++;
            Data.Add(newFBPlayer);
            return newFBPlayer;
        }

        public FBPlayer Delete(int id)
        {
            FBPlayer player = Data.Find(Player1 => Player1.Id == id);
            if (player == null) return null;
            Data.Remove(player);
            return player;
        }

        public FBPlayer Update(int id, FBPlayer update)
        {
            FBPlayer player = Data.Find(player => player.Id == id);
            if (player == null) return null;
            player.Name = update.Name;
            player.ShirtNumber = update.ShirtNumber;
            player.price = update.price;
            return player;
        }
    }
}
