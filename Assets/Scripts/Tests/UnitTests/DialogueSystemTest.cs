using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Localization;
using Unreal.Dialogue;
/// <summary>
/// �쥻�Q����SetReference�A�����䴩�A�u�n�����b��������
/// </summary>
public class DialogueSystemTest
{
    private DialogueSystem m_DialogueSystem;
    private LocalizedTextAsset m_LocalizedTextAsset;
    private LocalizedSprite m_localizedSprite;
    private LocalizedTextAsset testStory;
    private LocalizedString localizedString;
    private TextAsset textAsset;


    [SetUp]
    public void SetUp()
    {
        m_DialogueSystem = new DialogueSystem();
        testStory = new LocalizedTextAsset();
        m_LocalizedTextAsset = new LocalizedTextAsset();
        m_localizedSprite = new LocalizedSprite();
        testStory.SetReference("Test", "Test");
        m_LocalizedTextAsset.SetReference("Test", "Test");
        m_localizedSprite.SetReference("Avater", "sister");
        Debug.Log(testStory.ToString());
        //m_DialogueSystem.Initialize();
    }

    [Test]
    public void SetString()
    {
        localizedString = new LocalizedString();

        localizedString.SetReference("Name", "Default");

        string expected = "����i";
        string actual = localizedString.GetLocalizedString();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetTextAsset()
    {
        Debug.Log(m_LocalizedTextAsset);
        Debug.Log(m_LocalizedTextAsset.LoadAsset());
        textAsset = m_LocalizedTextAsset.LoadAsset();
        Assert.NotNull(textAsset);
    }

    [Test]
    public void SetSprite()
    {
        Debug.Log(m_localizedSprite);
        Debug.Log(m_localizedSprite.LoadAsset());
        Assert.NotNull(m_localizedSprite.LoadAsset());
    }

}
