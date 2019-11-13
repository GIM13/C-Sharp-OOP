using System;

namespace _04PizzaCalories
{
    public class Dough
    {
        private const double white = 1.5;
        private const double wholegrain = 1.0;

        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;

        private double modifierFlour;
        private double modifierBaking;
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private double calories;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;

            private set
            {
                string copy = value.ToLower();

                if (copy == "white")
                {
                    modifierFlour = white;
                }
                else if (copy == "wholegrain")
                {
                    modifierFlour = wholegrain;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;

            private set
            {
                string copy = value.ToLower();

                if (copy == "crispy")
                {
                    modifierBaking = crispy;
                }
                else if (copy == "chewy")
                {
                    modifierBaking = chewy;
                }
                else if (copy == "homemade")
                {
                    modifierBaking = homemade;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => weight;

            private set
            {
                if (value < 1 || 200 < value)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }

        public double GetCalories()
        {
            calories = 2 * weight * modifierFlour * modifierBaking;

            return calories;
        }
    }
}
