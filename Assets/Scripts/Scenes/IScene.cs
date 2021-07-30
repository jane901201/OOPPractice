using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 將需要設定的物件設定好
/// </summary>
public class IScene
{
    private string m_SceneName = "IScene";

    private Action m_SceneBegin;
    private Action m_SceneUpdate;
    private Action m_SceneEnd;

    protected string SceneName
    {
        get { return m_SceneName; }
        set { m_SceneName = value; }
    }

    public Action SceneBegin { get => m_SceneBegin; set => m_SceneBegin = value; }
    public Action SceneUpdate { get => m_SceneUpdate; set => m_SceneUpdate = value; }
    public Action SceneEnd { get => m_SceneEnd; set => m_SceneEnd = value; }

    protected SceneController controller = null;

    public IScene(SceneController controller)
    {
        this.controller = controller;
    }

    public override string ToString() //Debug跟測試
    {
        return SceneName;
    }
}
