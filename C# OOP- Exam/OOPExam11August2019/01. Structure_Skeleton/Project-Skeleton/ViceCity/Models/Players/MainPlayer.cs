using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const string nameMainPlayer = "Tommy Vercetti";
        private const int lifePointsMainPlayer = 100;

        public MainPlayer()
            : base (nameMainPlayer, lifePointsMainPlayer)
        {

        }
    }
}
