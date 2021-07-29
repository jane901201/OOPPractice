using System;
using System.Collections;
using UnityEngine;

namespace Unreal
{
    public partial class UnrealGame
    {
        private GameObject m_UI;

        public void SetUI(string uiName)
        {
            m_UI = m_Resources.LoadUI(uiName);
        }

        public GameObject GetUI()
        {
            return m_UI;
        }

        public void SetScene(string sceneName)
        {
            m_SceneController.SetState(new MainMenuState(m_SceneController), sceneName);

        }

        public void SceneUpdate()
        {
            m_SceneController.StateUpdate();
        }
    }
}