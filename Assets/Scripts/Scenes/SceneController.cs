using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController
{
    private ISceneState state;
    private bool runBegin = false;

    public SceneController()
    {

    }
    public void SetState(ISceneState state, string loadSceneName)
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

        //�o���٭n�@�ӽT�{function�O�_���b���J

        if(state != null && runBegin == false)
        {
            state.StateBegin();
            runBegin = true;
        }

        if(state != null)
        {
            state.StateUpdate();
        }
    
    }

    public ISceneState GetCurrectState()
    {
        return state;
    }

}
