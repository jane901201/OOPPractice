using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;

namespace Unreal
{
    /// <summary>
    /// 設置UI的路徑
    /// 設置UI的功能?
    /// </summary>
    public partial class UnrealGame
    {
        private GameObject m_UI = null;
        private GameObject m_MainMenuUI = null;
        private GameObject m_DialogueUI = null;
        private GameObject m_SaveDataUI = null;
        private GameObject m_GamePauseUI = null;
        private GameObject m_LoadingScreenUI = null;


        public void LoadMainMenuUI()
        {
            m_MainMenuUI = m_Resources.LoadUI("MainMenuUI"); 
        }

        public GameObject GetMainMenuUI()
        {
            return m_MainMenuUI;
        }

        public void LoadDialogueUI()
        {
            m_DialogueUI = m_Resources.LoadUI("DialogueUI"); 
        }

        public GameObject SetDialogeUI()
        {
            LoadDialogueUI();
            GameObject tmpDialogueUI = Instantiate(GetDialogueUI(), Vector3.zero, Quaternion.identity);

            

            return tmpDialogueUI;
        }

        public GameObject GetDialogueUI()
        {
            return m_DialogueUI;
        }

        public void LoadSaveDataUI()
        {
            m_SaveDataUI = m_Resources.LoadUI("SaveDataUI");
        }

        public GameObject GetSaveDataUI()
        {
            return m_SaveDataUI;
        }

        
        public void LoadGamePauseUI()
        {
            m_GamePauseUI = m_Resources.LoadUI("GamePauseUI"); 
        }

        public GameObject GetGamePauseUI()
        {
            return m_GamePauseUI;
        }   
        public void LoadLoadingUI()
        {
            m_UI = m_Resources.LoadUI("LoadingUI");
        }

        public GameObject GetLoadingScreenUI()
        {
            return m_LoadingScreenUI;
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