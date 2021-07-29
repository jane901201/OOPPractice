using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuScene : IScene
{
    public MainMenuScene(SceneController controller): base(controller)
    {
        this.SceneName = "MainMenuState";
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
        controller.SetScene(new SchoolScene(controller), "SchoolScene");
    }

    private void OnSaveDataBtnClick(Button button)
    {
        //TODO:�����I�sSaveData��UI
    }

    private void OnLeaveGameBtnClick(Button button)
    {
        Application.Quit(); //���}���ε{��
    }

}
