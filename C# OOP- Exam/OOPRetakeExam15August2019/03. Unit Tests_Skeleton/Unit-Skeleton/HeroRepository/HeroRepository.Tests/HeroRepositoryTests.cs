using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    [Test]
    public void CheckCreateForNullException()
    {
        var heroRepository = new HeroRepository();

        Assert.Throws<ArgumentNullException>(() => heroRepository.Create(null));
    }

    [Test]
    public void CheckRemoveForNullException()
    {
        var heroRepository = new HeroRepository();

        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(null));
    }

    [Test]
    public void CheckCreateForAlreadyExistsException()
    {
        var heroRepository = new HeroRepository();
        Hero hero = new Hero("zaza",7);

        heroRepository.Create(hero);

        Assert.Throws<InvalidOperationException>(() => heroRepository.Create(hero));
    }

    [Test]
    public void CheckRemove()
    {
        var heroRepository = new HeroRepository();
        Hero hero = new Hero("zaza",7);

        heroRepository.Create(hero);
        var result = heroRepository.Remove("zaza");

        Assert.AreEqual(true, result);
    }

    [Test]
    public void CheckGetHeroWithHighestLevel()
    {
        var heroRepository = new HeroRepository();
        Hero hero1 = new Hero("zaza",4);
        Hero hero2 = new Hero("zeze",7);
        Hero hero4 = new Hero("zizi",13);

        heroRepository.Create(hero1);
        heroRepository.Create(hero2);
        heroRepository.Create(hero4);

        var result = heroRepository.GetHeroWithHighestLevel();

        Assert.AreEqual(hero4, result);
    }

    [Test]
    public void CheckGetHero()
    {
        var heroRepository = new HeroRepository();
        Hero hero1 = new Hero("zaza",4);
        Hero hero2 = new Hero("zeze",7);
        Hero hero4 = new Hero("zizi",13);

        heroRepository.Create(hero1);
        heroRepository.Create(hero2);
        heroRepository.Create(hero4);

        var result = heroRepository.GetHero("zaza");

        Assert.AreEqual(hero1, result);
    }

    [Test]
    public void CheckHeroes()
    {
        var heroRepository = new HeroRepository();
        Hero hero1 = new Hero("zaza",4);
        Hero hero2 = new Hero("zeze",7);
        Hero hero4 = new Hero("zizi",13);

        heroRepository.Create(hero1);
        heroRepository.Create(hero2);
        heroRepository.Create(hero4);

        var result = heroRepository.Heroes.Count;

        Assert.AreEqual(3, result);
    }
}