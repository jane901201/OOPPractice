using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TestTools;

public class CharacterMoveTest : InputTestFixture
{
    IResources resources;
    GameObject playerPrefeb;
    Keyboard keyboard;
    

    [SetUp]
    public void SetUp()
    {
        resources = new ProjectResources();
        playerPrefeb = resources.LoadPlayer("Fox");
        keyboard = InputSystem.AddDevice<Keyboard>();
    }

    [UnityTest]
    public IEnumerator CharacterMoveRight()
    {
        Vector3 playerPos = new Vector3(-3.66f, -2.49f, 0);
        Vector3 initialPos = playerPos;
        Quaternion playerDir = Quaternion.identity;

        GameObject player = Object.Instantiate(playerPrefeb, playerPos, playerDir);
        Press(keyboard.dKey);
        yield return new WaitForSeconds(1f);
        Vector3 afterPos = player.transform.position;
        //Debug.Log(afterPos);
        Assert.Greater(afterPos.x, initialPos.x);
        

        
    }

    public IEnumerator GetInputSystemKeybroadW()
    {

        yield return null;
    }
}
