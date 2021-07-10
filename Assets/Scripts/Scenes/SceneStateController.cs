using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    private ISceneState state;
    private bool runBegin = false;

    public SceneStateController()
    {

    }
    public void setState(ISceneState state, string loadSceneName)
    {
        runBegin = false;

        LoadScene(loadSceneName);

        if(state != null)
        {
            state.StateEnd();
        }

        this.state = state;

    }

    private void LoadScene(string loadSceneName)
    {
        if (loadSceneName == null || loadSceneName.Length == 0)
            return;
        SceneManager.LoadScene(loadSceneName);
    }

    public void StateUpdate()
    {
        //���D���J�i��...����|����J�����F��@�_���A���Ȯɤ��z�|
    }
}
