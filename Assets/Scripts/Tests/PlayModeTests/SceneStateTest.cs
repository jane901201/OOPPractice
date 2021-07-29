using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;

public class SceneStateTest
{
    SceneController controller;
    IScene state;

    [SetUp]
    public void SetUp()
    {
        controller = new SceneController();
    }



    [UnityTest]
    public IEnumerator SwitchToMainMenuState()
    {

        //Arrange        
        state = new MainMenuScene(controller);

        //Act
        controller.SetScene(state, "MainMenuScene");

        //Assert
        Assert.AreEqual(controller.GetCurrectState().ToString() , "MainMenuScene");
        //Assert.AreEqual("MainMenuScene", "MainMenuScene");

        yield return null;
    }

    [UnityTest]
    public IEnumerator SwitchToSchoolState()
    {
        state = new SchoolScene(controller);

        controller.SetScene(state, "SchoolScene");

        Assert.AreEqual(controller.GetCurrectState().ToString(), "SchoolScene");

        yield return null;
    }

}
