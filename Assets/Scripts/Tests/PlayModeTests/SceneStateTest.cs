using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;

public class SceneStateTest
{
    SceneController controller;
    ISceneState state;

    [SetUp]
    public void SetUp()
    {
        controller = new SceneController();
    }



    [UnityTest]
    public IEnumerator SwitchToMainMenuState()
    {

        //Arrange        
        state = new MainMenuState(controller);

        //Act
        controller.SetState(state, "MainMenuScene");

        //Assert
        Assert.AreEqual(controller.GetCurrectState().ToString() , "MainMenuScene");
        //Assert.AreEqual("MainMenuScene", "MainMenuScene");

        yield return null;
    }

    [UnityTest]
    public IEnumerator SwitchToSaveDataState()
    {
        state = new SaveDataState(controller);

        controller.SetState(state, "SaveDataScene");

        Assert.AreEqual(controller.GetCurrectState().ToString(), "SaveDataScene");

        yield return null;
    }

    [UnityTest]
    public IEnumerator SwitchToSchoolState()
    {
        state = new SchoolState(controller);

        controller.SetState(state, "SchoolScene");

        Assert.AreEqual(controller.GetCurrectState().ToString(), "SchoolScene");

        yield return null;
    }

}
