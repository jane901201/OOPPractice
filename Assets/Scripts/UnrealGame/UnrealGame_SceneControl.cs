using System;
using System.Collections;
using UnityEngine;

namespace Unreal
{
    public partial class UnrealGame
    {

        public void SetMainMenuScene()
        {
            m_SceneController.SetScene(new MainMenuScene(m_SceneController), "MainMenuScene");
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