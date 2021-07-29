using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuState : ISceneState
{
    public MainMenuState(SceneController controller): base(controller)
    {
        this.StateName = "MainMenuState";
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

    private void OnStartGameBtnClick(Button button)
    {
        controller.SetState(new SchoolState(controller), "SchoolScene");
    }

    private void OnSaveDataBtnClick(Button button)
    {
        controller.SetState(new SaveDataState(controller), "SaveDataScene");
    }

    private void OnLeaveGameBtnClick(Button button)
    {
        Application.Quit(); //離開應用程式
    }

}
