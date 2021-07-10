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

    protected SceneStateController controller = null;

    public ISceneState(SceneStateController controller)
    {
        this.controller = controller;
    }

    public virtual void StateBegin()
    {
        //�C����Ƹ��J�Ϊ�l
    }

    public virtual void StateUpdate()
    {

    }

    public virtual void StateEnd()
    {

    }

    public override string ToString() //Debug�����
    {
        return string.Format("[I_SceneState: StateName={0}]", StateName);
    }
}
