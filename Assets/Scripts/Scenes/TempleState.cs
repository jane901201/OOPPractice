using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * �C���x�q������
 */
public class TempleState: ISceneState
{

    public TempleState(SceneStateController controller): base(controller)
    {
        StateName = "TempleState";
    }
}
