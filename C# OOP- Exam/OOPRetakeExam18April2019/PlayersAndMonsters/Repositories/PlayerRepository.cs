using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public int Count { get; }

        public IReadOnlyCollection<IPlayer> Players { get; }

        public void Add(IPlayer player)
        {
            throw new System.NotImplementedException();
        }

        public IPlayer Find(string username)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(IPlayer player)
        {
            throw new System.NotImplementedException();
        }
    }
}
