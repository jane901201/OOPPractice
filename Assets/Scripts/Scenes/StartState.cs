using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
* �C����l����
*/
public class StartState : ISceneState
{
  public StartState(SceneStateController controller): base(controller)
    {
        this.StateName = "StartState";
    }

    public override void StateBegin()
    {
        /*
         * �]�w���s�A�]���Q�t�XInputSystem�ҥH�o�̤���|���A�٦�UITool
        �O���y�̻`�����󪺤覡�A�ҥH���ޫ�˳o�̳��|�����ѴN�O
        */
        /*Button btn = UITool.GetUIComponent<Button>("StartGameBtn");
         * if(btn != null)
         * btn.onClick.AddListener(()=>OnStartGameBtnClick(btn));
        */
    }

    public override void StateUpdate()
    {
        controller.SetState(new MainMenuState(controller), "MainMenuState");
    }
}
