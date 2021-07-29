using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISceneState
{
    private string stateName = "ISceneState";

    public string StateName
    {
        get { return stateName; }
        set { stateName = value; }
    }

    protected SceneController controller = null;

    public ISceneState(SceneController controller)
    {
        this.controller = controller;
    }

    public virtual void StateBegin()
    {
        //遊戲資料載入及初始
    }

    public virtual void StateUpdate()
    {

    }

    public virtual void StateEnd()
    {

    }

    public override string ToString() //Debug跟測試
    {
        return StateName;
    }
}
