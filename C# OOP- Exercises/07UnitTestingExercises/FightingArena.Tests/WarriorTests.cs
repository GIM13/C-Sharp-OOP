using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [TestCase("zaza", 4, 40)]
        public void CheckTheConstructorWarrior(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);

            Assert.AreEqual("zaza", warrior.Name);
            Assert.AreEqual(4, warrior.Damage);
            Assert.AreEqual(40, warrior.HP);
        }

        [Test]
        public void CheckTheExceptionForNameWhitespace()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("    ", 4, 40), "Name should not be empty or whitespace!");
        }

        [Test]
        public void CheckTheExceptionForDamage()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("zaza", 0, 40), "Damage value should be positive!");
        }

        [Test]
        public void CheckTheExceptionForHP()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("zaza", 4, -40), "HP should not be negative!");
        }

        [Test]
        public void CheckTheExceptionForAttackHpAttacker()
        {
            Warrior attacker = new Warrior("zaza", 4, 20);
            Warrior attacked = new Warrior("zaza", 4, 40);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked), "Your HP is too low in order to attack other warriors!");
        }

        [Test]
        public void CheckTheExceptionForAttackHpAttacked()
        {
            int MIN_ATTACK_HP = 30;
            Warrior attacker = new Warrior("zaza", 4, 40);
            Warrior attacked = new Warrior("zaza", 4, 20);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked), $"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!");
        }

        [Test]
        public void CheckTheExceptionForAttackStrongEnemy()
        {
            Warrior attacker = new Warrior("zaza", 4, 40);
            Warrior attacked = new Warrior("zaza", 44, 40);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked), "You are trying to attack too strong enemy");
        }

        [TestCase("zuzu", 10, 40)]
        public void CheckHPAttacker(string name, int damage, int hp)
        {
            Warrior attacker = new Warrior("zaza", 20, 40);
            Warrior attacked = new Warrior(name, damage, hp);
            attacker.Attack(attacked);

            Assert.AreEqual(30, attacker.HP);
        }

        [TestCase("zuzu", 10, 40)]
        [TestCase("zuzu", 10, 70)]
        public void CheckHPAttacked(string name, int damage, int hp)
        {
            Warrior attacker = new Warrior("zaza", 70, 40);
            Warrior attacked = new Warrior(name, damage, hp);
            attacker.Attack(attacked);

            Assert.AreEqual(0, attacked.HP);
        }
    }
}