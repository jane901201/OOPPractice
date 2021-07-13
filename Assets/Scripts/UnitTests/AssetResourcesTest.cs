using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AssetResourcesTest : IPrebuildSetup
{
    IResources resources;

    [SetUp] 
    public void Setup()
    {
        resources = new ProjectResources();
    }

    [Test]
    public void GetPlayer()
    {
        //Arrange
        
        //Act
        GameObject player = resources.LoadPlayer("Fox");
        Debug.Log(player);
        //Assert
        Assert.NotNull(player);
    }

    public void GetEnemy()
    {

    }
    [Test]
    public void GetSprite()
    {
        //Arrange
        //Act
        Sprite sprite = resources.LoadSprite("Luigi");
        //Assert
        
        Assert.NotNull(sprite);
    }


    public void GetWeapon()
    {

    }
    [Test]
    public void GetAudioClip()
    {
        AudioClip audioClip = resources.LoadAudioClip("PathOfWuxia/01xiayinchuxin-yuanban");
        Assert.NotNull(audioClip);
    }

    public void GetEffect()
    {

    }

    public void GetSounds()
    {

    }



}
