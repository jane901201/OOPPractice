using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController
{
    private IScene m_Scene;
    private bool runBegin = false;

    public SceneController()
    {

    }
    public void SetScene(IScene scene, string loadSceneName)
    {
        runBegin = false;

        LoadScene(loadSceneName);

        if(scene != null)
        {
            scene.SceneEnd();
        }

        this.m_Scene = scene;

    }

    private void LoadScene(string loadSceneName)
    {
        if (loadSceneName == null || loadSceneName.Length == 0)
            return;
        SceneManager.LoadScene(loadSceneName);
    }

    public void SceneUpdate()
    {

        //這裡還要一個確認function是否有在載入

        if(m_Scene != null && runBegin == false)
        {
            m_Scene.SceneBegin();
            runBegin = true;
        }

        if(m_Scene != null)
        {
            m_Scene.SceneUpdate();
        }
    
    }

    public IScene GetCurrectScene()
    {
        return m_Scene;
    }

}
