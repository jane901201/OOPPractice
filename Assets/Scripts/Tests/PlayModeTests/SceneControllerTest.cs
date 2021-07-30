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

        //Assert
        Assert.AreEqual(controller.GetCurrectScene().ToString() , "MainMenuScene");
        //Assert.AreEqual("MainMenuScene", "MainMenuScene");

        yield return null;
    }

    [UnityTest]
    public IEnumerator SwitchToSchoolState()
    {
        scene = new SchoolScene(controller);

        controller.SetLoadingScene(scene);

        Assert.AreEqual(controller.GetCurrectScene().ToString(), "SchoolScene");

        yield return null;
    }    

}
