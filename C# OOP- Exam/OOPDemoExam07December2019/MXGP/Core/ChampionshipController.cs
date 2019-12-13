using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Models.Races;
using MXGP.Models.Riders;
using MXGP.Repositories;
using System;
using System.Linq;

namespace MXGP.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private RiderRepository<Rider> riderRepository = new RiderRepository<Rider>();
        private MotorcycleRepository<Motorcycle> motorcycleRepository = new MotorcycleRepository<Motorcycle>();
        private RaceRepository<Race> raceRepository = new RaceRepository<Race>();

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            var rider = riderRepository.Models.FirstOrDefault(x => x.Name == riderName);

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            var motorcycle = motorcycleRepository.Models.FirstOrDefault(x => x.Model == motorcycleModel);

            if (motorcycle == null)
            {
                throw new InvalidOperationException($"Motorcycle {motorcycleModel} could not be found.");
            }

            riderRepository.Models.FirstOrDefault(x => x.Name == riderName).AddMotorcycle(motorcycle);

            return $"Rider {riderName} received motorcycle {motorcycleModel}.";
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            var rase = raceRepository.Models.FirstOrDefault(x => x.Name == raceName);

            if (rase == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            var rider = riderRepository.Models.FirstOrDefault(x => x.Name == riderName);

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            raceRepository.Models.FirstOrDefault(x => x.Name == raceName).AddRider(rider);

            return $"Rider {riderName} added in {raceName} race.";
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            Motorcycle motorcycle = null;

            if (type == "Speed")
            {
                if (horsePower < 50 && 69 < horsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {horsePower}.");
                }
                else
                {
                     motorcycle = new SpeedMotorcycle(model, horsePower);
                }
            }
            else if (type == "Power")
            {
                if (horsePower < 70 && 100 < horsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {horsePower}.");
                }
                else
                {
                     motorcycle = new PowerMotorcycle(model, horsePower);
                }
            }

            if (motorcycleRepository.Models != null && motorcycleRepository.Models.Any(x => x.Model == model))
            {
                throw new ArgumentException($"Motorcycle {model} is already created.");
            }

            if (motorcycle != null)
            {
                motorcycleRepository.Add(motorcycle);
            }
           
            return $"{motorcycle.GetType().Name} {model} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            var race = new Race(name, laps);

            if (raceRepository.Models != null && raceRepository.Models.Any(x => x.Name == name))
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }

            raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string CreateRider(string riderName)
        {
            var rider = new Rider(riderName);

            if (riderRepository.Models != null && riderRepository.Models.Any(x => x.Name == riderName))
            {
                throw new ArgumentException($"Rider {riderName} is already created.");
            }

            riderRepository.Add(rider);

            return $"Rider {riderName} is created.";
        }

        public string StartRace(string raceName)
        {
            var race = raceRepository.Models.FirstOrDefault(x => x.Name == raceName);

            if (!raceRepository.Models.Any(x => x.Name == raceName))
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            else if (race.Riders == null || race.Riders.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            //race.Riders.OrderByDescending(x => x.Motorcycle.CalculateRacePoints(race.Laps));

            var wins = new Rider(string.Empty);
            var second = new Rider(string.Empty);
            var third = new Rider(string.Empty);

            foreach (Rider rider in race.Riders)
            {
                if (rider.Motorcycle.CalculateRacePoints(race.Laps) > wins.Motorcycle.CalculateRacePoints(race.Laps))
                {
                    wins = rider;
                }
                else if (rider.Motorcycle.CalculateRacePoints(race.Laps) > second.Motorcycle.CalculateRacePoints(race.Laps))
                {
                    second = rider;
                }
                else if (rider.Motorcycle.CalculateRacePoints(race.Laps) > third.Motorcycle.CalculateRacePoints(race.Laps))
                {
                    third = rider;
                }
            }

            string result = $"Rider {wins.Name} wins {raceName} race." + Environment.NewLine
                 + $"Rider {second.Name} is second in {raceName} race." + Environment.NewLine
                 + $"Rider {third.Name} is third in {raceName} race.";

            raceRepository.Remove(race);

            return result;
        }
    }
}
