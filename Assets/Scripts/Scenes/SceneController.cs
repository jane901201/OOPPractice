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
    private float m_Progress;
    private Action m_GetLoadingUI;
    List<AsyncOperation> m_ScenesToLoad = new List<AsyncOperation>();
    AsyncOperation operation;


    public override void Initialize()
    {
        base.Initialize();
    }


    //TODO:�n����SetLoadingScene�O���O�u����ΡA���T�ӻ��A��UnitTest����
    public IEnumerator SetLoadingScene(IScene scene)
    {
        m_RunBegin = false;
        string loadingSceneName = scene.ToString();

        if (loadingSceneName == null || loadingSceneName.Length == 0)
            yield return null;


        operation = SceneManager.LoadSceneAsync(loadingSceneName, LoadSceneMode.Single);
        //TODO:m_GetLoadingUI();

        while (operation.progress < 0.89)
        {
             m_Progress = Mathf.Clamp01(operation.progress / 0.9f);
            //TODO:��Loading��UI��progress���X...�b�ڰ��z��LoadingUI��Bug��            
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
            //TODO:���ݭn����LoadingUI��?
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

    public void SetLoadingUI(Action getLoadingUI)
    {
        m_GetLoadingUI = getLoadingUI;
    }

    public float GetCurrectProgress()
    {
        return m_Progress;
    }

    public override void SaveData() //TODO:�i��n�A�ݬ�SaveData������n���n��bSceneController�A���T�ӻ��O���n�աA�έn�˦�Observer�Ҧ��~��
    {
        base.SaveData();
    }

    public override void LoadData()
    {
        base.LoadData();
    }

}
