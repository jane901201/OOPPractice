using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using Unreal;

public class UnrealGameTest
{
    UnrealGame m_UnrealGame;

    [SetUp]
    public void SetUp()
    {
        m_UnrealGame = new UnrealGame(); //TODO:到時要研究一下Monobehavoir的測試辦法了
        m_UnrealGame.UnrealAwake();
    }



    [Test]
    public void SetUI_MainMenuUI()
    {
        m_UnrealGame.LoadMainMenuUI();
        Assert.AreEqual("MainMenuUI (UnityEngine.GameObject)", m_UnrealGame.GetMainMenuUI().ToString());
    }

    [Test]
    public void SetUI_SaveDataUI()
    {
        m_UnrealGame.LoadSaveDataUI();
        Assert.AreEqual("SaveDataUI (UnityEngine.GameObject)", m_UnrealGame.GetSaveDataUI().ToString());
    }

    [Test]
    public void SetUI_GamePauseUI()
    {
        m_UnrealGame.LoadGamePauseUI();
        Assert.AreEqual("GamePauseUI (UnityEngine.GameObject)", m_UnrealGame.GetGamePauseUI().ToString());
    }

    [Test]
    public void SetUI_DialogueUI()
    {
        m_UnrealGame.LoadDialogueUI();
        Assert.AreEqual("DialogueUI (UnityEngine.GameObject)", m_UnrealGame.GetDialogueUI().ToString());
    }

    [Test]
    public void SetUI_LoadingScreenUI()
    {
        m_UnrealGame.LoadLoadingUI();
        Assert.AreEqual("LoadingUI (UnityEngine.GameObject)", m_UnrealGame.GetLoadingScreenUI().ToString());
    }


}
