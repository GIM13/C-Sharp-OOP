using System;

namespace _05FootballTeamGenerator
{
    public class Player
    {
        private double rating;
        private int shooting = -1;
        private int passing = -1;
        private int dribble = -1;
        private int sprint= -1;
        private int endurance = -1;
        private string name;

        public Player(string name, int endurance,
                       int sprint, int dribble,
                       int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
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

        internal int Endurance
        {
            get => endurance;

            set
            {
                if (Validation(value, "Endurance"))
                {
                    endurance = value;
                }
            }
        }

        internal int Sprint
        {
            get => sprint;

            set
            {
                if (Validation(value, "Sprint"))
                {
                    sprint = value;
                }
            }
        }

        internal int Dribble
        {
            get => dribble;

            set
            {
                if (Validation(value, "Dribble"))
                {
                    dribble = value;
                }
            }
        }

        internal int Passing
        {
            get => passing;

            set
            {
                if (Validation(value, "Passing"))
                {
                    passing = value;
                }
            }
        }

        internal int Shooting
        {
            get => shooting;

            set
            {
                if (Validation(value, "Shooting"))
                {
                    shooting = value;
                } 
            }
        }

        public double GetRatingPlayer()
        {
            rating = (Endurance + Sprint + Dribble + Passing + Shooting) / 5d;

            return Math.Round(rating);
        }

        private static bool Validation(int value, string data)
        {
            if (value < 0 || 100 < value)
            {
                Console.WriteLine($"{data} should be between 0 and 100.");

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
