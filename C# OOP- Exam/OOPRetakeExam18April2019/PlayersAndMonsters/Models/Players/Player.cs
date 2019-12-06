using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        protected Player(ICardRepository cardRepository, string username, int health)
        {
            CardRepository = cardRepository;
            Username = username;
            Health = health;
        }

        public ICardRepository CardRepository { get; }

        public string Username { get;  }

        public int Health { get ; set ; }

        public bool IsDead { get; }

        public void TakeDamage(int damagePoints)
        {
            throw new NotImplementedException();
        }
    }
}
