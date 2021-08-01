using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController
{
    private IScene m_Scene;
    private bool m_RunBegin = false;
    AsyncOperation operation;


    public SceneController()
    {

    }

    //TODO:要測試SetLoadingScene是不是真的能用，正確來說，用UnitTest測試
    public IEnumerator SetLoadingScene(IScene scene)
    {
        m_RunBegin = false;
        String loadingSceneName = scene.ToString();

        if (loadingSceneName == null || loadingSceneName.Length == 0)
            yield return null;
        operation = SceneManager.LoadSceneAsync(loadingSceneName);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //TODO:把Loading的UI跟progress結合...在我除理掉LoadingUI的Bug後
            Debug.Log(progress);
            yield return null;
        }
        
        if (m_Scene != null)
        {
            m_Scene.SceneEnd();
        }
        m_Scene = scene;
    }

   
     public void SceneUpdate()
    {
        if (m_Scene != null && m_RunBegin == false)
        {
            m_Scene.SceneBegin();
            m_RunBegin = true;
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
