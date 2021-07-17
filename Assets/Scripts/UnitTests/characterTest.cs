using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
public class CharacterTest
{
    ICharacterAttr playerAttr;
    IAttrStrategy playerAttrStrategy;
    IAttrStrategy EnemeyAttrStrategy;

    [SetUp]
    public void Setup()
    {
        playerAttr = new PlayerAttr();
        playerAttrStrategy = new PlayerAttrStrategy();
        EnemeyAttrStrategy = new EnemyAttrStrategy();
    }

    [Test]
    public void GetHp()
    {
        playerAttr.Hp = 1;

        int expected = 1;
        int actual = playerAttr.Hp;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetMp()
    {
        playerAttr.Mp = 1;

        int expected = 1;
        int actual = playerAttr.Mp;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetPhyDamage()
    {
        int expected = 1;
        int actual = playerAttrStrategy.PhysicalDamage(2, 1);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetMagDamage()
    {
        int expected = 1;
        int actual = playerAttrStrategy.MagicalDamage(2, 1);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetMoveSpd()
    {
        int expected = 1;
        int actual = playerAttrStrategy.MoveSpd(1);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetAtkSpd()
    {
        int expected = 1;
        int actual = playerAttrStrategy.AtkSpd(1);
        Assert.AreEqual(expected, actual);
    }




}
