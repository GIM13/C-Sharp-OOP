using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (civilPlayers.Any(x => x.IsAlive)
                && mainPlayer.GunRepository.Models.Any(x => x.CanFire))
            {
              var damage =  mainPlayer
                    .GunRepository.Models
                    .FirstOrDefault(x => x.CanFire)
                    .Fire();

                civilPlayers.FirstOrDefault(x => x.IsAlive)
                    .TakeLifePoints(damage);
            }

            while (civilPlayers.Any(x => x.IsAlive) 
                && mainPlayer.IsAlive
                && civilPlayers.FirstOrDefault(x => x.IsAlive)
                     .GunRepository.Models.Any(x => x.CanFire))
            {
                var damage = civilPlayers
                    .FirstOrDefault(x => x.IsAlive)
                    .GunRepository.Models
                    .FirstOrDefault(x => x.CanFire)
                    .Fire();

                mainPlayer.TakeLifePoints(damage);
            }
        }
    }
}
