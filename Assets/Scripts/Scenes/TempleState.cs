using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ¹CÀ¸¦x¼qªº³õ´º
 */
public class TempleState: ISceneState
{

    public TempleState(SceneStateController controller): base(controller)
    {
        StateName = "TempleState";
    }
}
