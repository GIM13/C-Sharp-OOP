using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
     public class Pistol : Gun
    {
        private const int bulletsPerBarrel = 10;
        private const int totalBullets = 100;

        public Pistol(string name) 
            : base(name, bulletsPerBarrel, totalBullets)
        {
        }
    }
}
