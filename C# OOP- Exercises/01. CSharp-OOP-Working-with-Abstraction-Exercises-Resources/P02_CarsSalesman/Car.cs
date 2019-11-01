using System;
using System.Collections.Generic;

namespace P02_CarsSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight) 
            : this(model,engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight  { get; set; } 

        public string Color  { get; set; } = "n/a";

        public override string ToString()
        {
            string engineDisplacement = "n/a";

            if (Engine.Displacement != 0)
            {
                engineDisplacement = Engine.Displacement.ToString();
            }
            string weight = "n/a";

            if (Weight!= 0)
            {
                weight = Weight.ToString();
            }

            return $"{Model}:" + Environment.NewLine +
                   $"  {Engine.Model}:" + Environment.NewLine +
                   $"    Power: {Engine.Power}" + Environment.NewLine +
                   $"    Displacement: {engineDisplacement}" + Environment.NewLine +
                   $"    Efficiency: {Engine.Efficiency}" + Environment.NewLine +
                   $"  Weight: {weight}" + Environment.NewLine +
                   $"  Color: {Color}";
        }

        public static void AddCarToList(List<Engine> listEngines, List<Car> listCar, string[] infoCars)
        {
            foreach (var engine in listEngines)
            {
                if (engine.Model == infoCars[1])
                {
                    if (infoCars.Length == 2)
                    {
                        string model = infoCars[0];

                        listCar.Add(new Car(model, engine));
                    }
                    else if (infoCars.Length == 3)
                    {
                        string model = infoCars[0];

                        if (int.TryParse(infoCars[2], out int weight))
                        {
                            listCar.Add(new Car(model, engine, weight));
                        }
                        else
                        {
                            string color = infoCars[2];
                            listCar.Add(new Car(model, engine, color));
                        }
                    }
                    else if (infoCars.Length == 4)
                    {
                        string model = infoCars[0];
                        int weight = int.Parse(infoCars[2]);
                        string color = infoCars[3];

                        listCar.Add(new Car(model, engine, weight, color));
                    }
                }
            }
        }
    }
}
