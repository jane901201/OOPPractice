using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataState : ISceneState
{
    public SaveDataState(SceneStateController controller) : base(controller)
    {
        this.StateName = "SaveDataState";
    }

    public override void StateBegin()
    {

    }

    public override void StateUpdate()
    {

    }

    public override void StateEnd()
    {

    }

    public void OnLoadSaveDataBtn()
    {
        //之後用來Loading存檔的地方
    }
}
