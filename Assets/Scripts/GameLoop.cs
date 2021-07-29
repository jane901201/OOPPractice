using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class GameLoop : MonoBehaviour
{
    SceneStateController sceneStateController = new SceneStateController();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        sceneStateController.SetState(new StartState(sceneStateController), "MainMenuScene");
    }

    private void Update()
    {
        sceneStateController.StateUpdate();
    }

}
