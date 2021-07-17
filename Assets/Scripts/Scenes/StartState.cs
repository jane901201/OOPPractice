using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
* 遊戲初始介面
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
         * 設定按鈕，因為想配合InputSystem所以這裡之後會更改，還有UITool
        是書籍裡蒐集物件的方式，所以不管怎樣這裡都會先註解就是
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
