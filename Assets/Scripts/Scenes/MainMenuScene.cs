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

    private void OnStartGameBtnClick(Button button)
    {
        controller.SetScene(new SchoolScene(controller), "SchoolScene");
    }

    private void OnSaveDataBtnClick(Button button)
    {
        //TODO:直接呼叫SaveData的UI
    }

    private void OnLeaveGameBtnClick(Button button)
    {
        Application.Quit(); //離開應用程式
    }

}
