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
    AsyncOperation operation;

    //TODO:�n����SetLoadingScene�O���O�u����ΡA���T�ӻ��A��UnitTest����
    //TODO:���D������m_Scene���Ȥ��|���ܪ���]
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
            //TODO:��Loading��UI��progress���X...�b�ڰ��z��LoadingUI��Bug��
            //Debug.Log(progress);
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
