using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        [Test]
        public void CheckTheExceptionForEnroll()
        {
            Arena warriors = new Arena();
            warriors.Enroll(new Warrior("zaza", 4, 40));

            Assert.Throws<InvalidOperationException>(() => warriors.Enroll(new Warrior("zaza", 5, 50)), "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void CheckTheForEnroll() 
        {
            Arena warriors = new Arena();
            warriors.Enroll(new Warrior("zaza", 4, 40));

            Assert.AreEqual(1,warriors.Warriors.Count);
            Assert.AreEqual(1,warriors.Count);
        }

        [Test]
        public void CheckTheExceptionForFight() 
        {
            Arena warriors = new Arena();
          
            Warrior warrior1 = new Warrior("zaza",10,40);
            Warrior warrior2 = new Warrior("zuzu", 10, 40);

            warriors.Enroll(warrior1);
            warriors.Enroll(warrior2);

            Assert.Throws<InvalidOperationException>(() => warriors.Fight("zaza", "zeze"));
        } 

        [Test]
        public void CheckTheForFight() 
        {
            Arena warriors = new Arena();
          
            Warrior attacker = new Warrior("zaza",10,40);
            Warrior defender = new Warrior("zuzu", 10, 40);

            warriors.Enroll(attacker);
            warriors.Enroll(defender);

            warriors.Fight("zaza", "zuzu");

            Assert.AreEqual(30, attacker.HP);
        } 
    }
}
