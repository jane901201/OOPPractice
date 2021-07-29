using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController
{
    private IScene state;
    private bool runBegin = false;

    public SceneController()
    {

    }
    public void SetScene(IScene state, string loadSceneName)
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

    public void SceneUpdate()
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

    public IScene GetCurrectState()
    {
        return state;
    }

}
