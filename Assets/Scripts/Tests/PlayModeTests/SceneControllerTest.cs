using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;

public class SceneControllerTest
{
    SceneController controller;
    IScene scene;

    [SetUp]
    public void SetUp()
    {
        controller = new SceneController();
    }



    [UnityTest]
    public IEnumerator SwitchToMainMenuState()
    {

        //Arrange        
        scene = new MainMenuScene(controller);

        //Act
        
        controller.SetLoadingScene(scene);

        //TODO:之後要改掉這裡的測試
        Assert.AreEqual(controller.GetCurrectSceneName() , "MainMenuScene");
        //Assert.AreEqual("MainMenuScene", "MainMenuScene");

        yield return null;
    }

    [UnityTest]
    public IEnumerator SwitchToSchoolState()
    {
        scene = new SchoolScene(controller);

        controller.SetLoadingScene(scene);

        //TODO:之後要改掉這裡的測試
        Assert.AreEqual(controller.GetCurrectSceneName(), "SchoolScene");

        yield return null;
    }    

}
