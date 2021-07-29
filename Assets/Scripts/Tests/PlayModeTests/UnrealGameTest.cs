using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using Unreal;

public class UnrealGameTest : MonoBehaviour
{
    UnrealGame m_UnrealGame;

    [SetUp]
    public void SetUp()
    {
        m_UnrealGame = new UnrealGame();
        m_UnrealGame.Awake();
    }



    [Test]
    public void SetUI_MainMenuUI()
    {
        m_UnrealGame.SetUI("MainMenuUI");
        Assert.AreEqual("MainMenuUI (UnityEngine.GameObject)", m_UnrealGame.GetUI().ToString());
    }
}
