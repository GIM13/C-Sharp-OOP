using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;

        public Player(string name, int lifePoints)
        {
            Name = name;
            LifePoints = lifePoints;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }

                name = value;
            }
        }
        public bool IsAlive { get; private set; } = true;

        public IRepository<IGun> GunRepository { get; }

        public int LifePoints 
        {
            get => lifePoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }

                lifePoints = value;
            }
        }

        public void TakeLifePoints(int points)
        {
            lifePoints -= points;

            if (lifePoints < 0)
            {
                lifePoints = 0;
            }

            if (lifePoints == 0)
            {
                IsAlive = false;
            }
        }
    }
}
