using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;
using UnityEngine.UI;

namespace Unreal
{
    public partial class UnrealGame
    {

        Button button;
        public void SetMainMenuScene()
        {
            MainMenuScene mainMenuScene = new MainMenuScene(m_SceneController);
            mainMenuScene.SceneBegin = delegate ()
            {
                GetMainMenuUI().GetComponent<MainMenuUI>().BeginBtn.onClick.AddListener(
                    () => SetSchoolScene()
                );

                //TODO:除理UI的呼叫問題
                /*GetMainMenuUI().GetComponent<MainMenuUI>().ContinureBtn.onClick.AddListener(
                        //呼叫UI
                    );*/

            };
            m_SceneController.SetScene(mainMenuScene, "MainMenuScene");
        }

        public void SetTempleScene()
        {
            m_SceneController.SetScene(new TempleScene(m_SceneController), "TempleScene");
        }

        public void SetSchoolScene()
        {
            m_SceneController.SetScene(new SchoolScene(m_SceneController), "SchoolScene");
        }

        public void SceneUpdate()
        {
            m_SceneController.SceneUpdate();
        }
    }
}