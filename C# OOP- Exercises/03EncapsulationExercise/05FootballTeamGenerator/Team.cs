using System;
using System.Collections.Generic;

namespace _05FootballTeamGenerator
{
    public class Team
    {
        private string name;

        public Team(string name)
        {
            Name = name;
            Players = new Dictionary<string, Player>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("A name should not be empty.");
                }

                name = value;
            }
        }

        public Dictionary<string, Player> Players { get; set; }

        public double GetRatingTeam()
        {
            double rating = 0;

            foreach (var player in Players.Values)
            {
                rating += player.GetRatingPlayer();
            }

            return Math.Round(rating);
        }
    }
}
