using PlayersAndMonsters.Models.Cards;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        public int Count { get; }

        public IReadOnlyCollection<ICard> Cards { get; }

        public void Add(ICard card)
        {
            throw new NotImplementedException();
        }

        public ICard Find(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ICard card)
        {
            return true;
        }
    }
}
