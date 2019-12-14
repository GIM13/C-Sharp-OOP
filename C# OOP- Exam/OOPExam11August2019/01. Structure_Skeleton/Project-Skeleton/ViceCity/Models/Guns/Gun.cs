using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int capacityBarrel;
        private int totalBullets;
        private int shot;

        protected Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            Name = name;
            BulletsPerBarrel = bulletsPerBarrel;
            capacityBarrel = bulletsPerBarrel;
            TotalBullets = totalBullets;
            shot = bulletsPerBarrel / 10;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or a white space!");
                }

                name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get => bulletsPerBarrel;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }

                bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get => totalBullets;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }

                totalBullets = value;
            }
        }

        public bool CanFire { get; private set; } = true;

        public int Fire()
        {
            if (totalBullets > 0 || bulletsPerBarrel > 0)
            {
                if (bulletsPerBarrel == 0)
                {
                    bulletsPerBarrel = capacityBarrel;

                    totalBullets -= capacityBarrel;
                }

                bulletsPerBarrel -= shot;
            }
            else
            {
                CanFire = false;
            }

            return shot;
        }
    }
}
