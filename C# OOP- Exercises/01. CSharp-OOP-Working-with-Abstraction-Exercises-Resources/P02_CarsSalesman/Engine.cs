
using System.Collections.Generic;

namespace P02_CarsSalesman
{
    public class Engine
    {
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, string power, int displacement)
            : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, string power, string color)
            : this(model, power)
        {
            Efficiency = color;
        }

        public Engine(string model, string power, int displacement, string efficiency)
            : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }

        public string Power { get; set; }

        public int Displacement { get; set; } 

        public string Efficiency { get; set; } = "n/a";

        public static void AddEnginToList(List<Engine> listEngines, string[] infoEngine)
        {
            if (infoEngine.Length == 2)
            {
                string model = infoEngine[0];
                string power = infoEngine[1];

                listEngines.Add(new Engine(model, power));
            }
            else if (infoEngine.Length == 3)
            {
                string model = infoEngine[0];
                string power = infoEngine[1];

                if (int.TryParse(infoEngine[2], out int displacement))
                {
                    listEngines.Add(new Engine(model, power, displacement));
                }
                else
                {
                    string efficiency = infoEngine[2];

                    listEngines.Add(new Engine(model, power, efficiency));
                }
            }
            else if (infoEngine.Length == 4)
            {
                string model = infoEngine[0];
                string power = infoEngine[1];
                int displacement = int.Parse(infoEngine[2]);
                string efficiency = infoEngine[3];

                listEngines.Add(new Engine(model, power, displacement, efficiency));
            }
        }
    }
}
