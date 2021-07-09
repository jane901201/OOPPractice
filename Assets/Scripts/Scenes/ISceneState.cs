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



}
