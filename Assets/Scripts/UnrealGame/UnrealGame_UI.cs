using System.Collections;
using UnityEngine;
using Unreal.UI;

namespace Unreal
{
    public partial class UnrealGame
    {
        private GameObject m_UI = null;
        private GameObject m_MainMenuUI = null;
        private GameObject m_DialogueUI = null;
        private GameObject m_SaveDataUI = null;
        private GameObject m_GamePauseUI = null;


        public void SetMainMenuUI()
        {
            m_MainMenuUI = m_Resources.LoadUI("MainMenuUI"); 
        }

        public GameObject GetMainMenuUI()
        {
            return m_MainMenuUI;
        }

        public void SetDialogueUI()
        {
            m_DialogueUI = m_Resources.LoadUI("DialogueUI"); 
        }

        public GameObject GetDialogueUI()
        {
            return m_DialogueUI;
        }

        public void SetSaveDatatUI()
        {
            m_SaveDataUI = m_Resources.LoadUI("SaveDataUI");
        }

        public GameObject GetSaveDataUI()
        {
            return m_SaveDataUI;
        }

        
        public void SetGamePauseUI()
        {
            m_GamePauseUI = m_Resources.LoadUI("GamePauseUI"); 
        }

        public GameObject GetGamePauseUI()
        {
            return m_GamePauseUI;
        }   
        public void SetUI(string uiName)
        {
            m_UI = m_Resources.LoadUI(uiName);
        }

        public GameObject GetUI()
        {
            return m_UI;
        }
    }
}