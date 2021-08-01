using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Localization;
using Unreal.Dialogue;
public class DialogueSystemTest
{
    private DialogueSystem dialogueSystem;
    private LocalizedObject testStory;


    [SetUp]
    public void SetUp()
    {
        dialogueSystem = new DialogueSystem();
        testStory.SetReference("Test", "Test");
        dialogueSystem.SetStoryLocal(testStory);
        dialogueSystem.Initialize();
    }


    [Test]
    public void SetName_NormalNPC()
    {

    }

    [Test]
    public void SetName_Player()
    {

    }

    [Test]
    public void CreateContentView()
    {

    }

    [Test]
    public void RefreshView()
    {

    }



}
