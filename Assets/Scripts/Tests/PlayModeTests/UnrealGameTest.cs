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
        m_UnrealGame.SetMainMenuUI();
        Assert.AreEqual("MainMenuUI (UnityEngine.GameObject)", m_UnrealGame.GetMainMenuUI().ToString());
    }

    [Test]
    public void SetUI_SaveDataUI()
    {
        m_UnrealGame.SetSaveDatatUI();
        Assert.AreEqual("SaveDataUI (UnityEngine.GameObject)", m_UnrealGame.GetSaveDataUI().ToString());
    }

    [Test]
    public void SetUI_GamePauseUI()
    {
        m_UnrealGame.SetGamePauseUI();
        Assert.AreEqual("GamePauseUI (UnityEngine.GameObject)", m_UnrealGame.GetGamePauseUI().ToString());
    }

    [Test]
    public void SetUI_DialogueUI()
    {
        m_UnrealGame.SetDialogueUI();
        Assert.AreEqual("DialogueUI (UnityEngine.GameObject)", m_UnrealGame.GetDialogueUI().ToString());
    }

}
