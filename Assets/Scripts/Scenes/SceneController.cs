using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unreal.BaseClass;

public class SceneController : IGameSystem
{
    private static IScene m_Scene;
    private bool m_RunBegin = false;
    List<AsyncOperation> m_ScenesToLoad = new List<AsyncOperation>();
    AsyncOperation operation;

    //TODO:要測試SetLoadingScene是不是真的能用，正確來說，用UnitTest測試
    public IEnumerator SetLoadingScene(IScene scene)
    {
        m_RunBegin = false;
        string loadingSceneName = scene.ToString();

        if (loadingSceneName == null || loadingSceneName.Length == 0)
            yield return null;


        operation = SceneManager.LoadSceneAsync(loadingSceneName, LoadSceneMode.Single);
        

        while (operation.progress < 0.89)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //TODO:把Loading的UI跟progress結合...在我除理掉LoadingUI的Bug後            
        }


        if (m_Scene != null)
        {
            m_Scene.SceneEnd();
        }
        m_Scene = scene;


        yield return null;
    }

   
     public void SceneUpdate()
    {
        if (m_Scene != null && m_RunBegin == false && operation.isDone)
        {
            
            m_Scene.SceneBegin();
            m_RunBegin = true;
        }

        if (m_Scene != null)
        {
            m_Scene.SceneUpdate();
        }

    }

    public string GetCurrectSceneName()
    {
        return m_Scene.ToString();
    }

    public override void SaveData()
    {
        base.SaveData();
    }

    public override void LoadData()
    {
        base.LoadData();
    }

}
