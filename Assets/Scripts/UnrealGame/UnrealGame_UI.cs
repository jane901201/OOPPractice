using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;
using Unreal.BaseClass;

namespace Unreal
{
    /// <summary>
    /// 設置UI的路徑
    /// 設置UI的功能?
    /// TODO:可能之後這裡會獨立出來，專門產生Instantiate物件
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

        public GameObject InstantiateMainMenuUI()
        {
            LoadMainMenuUI();
            GameObject tmpMainMenuUI = Instantiate(GetMainMenuUI(), Vector3.zero, Quaternion.identity);

            return tmpMainMenuUI;
        }

        public void LoadDialogueUI()
        {
            m_DialogueUI = m_Resources.LoadUI("DialogueUI"); 
        }

        public GameObject GetDialogueUI()
        {
            return m_DialogueUI;
        }

        public GameObject InstantiateDialogeUI() //之後要改
        {
            LoadDialogueUI();
            GameObject tmpDialogueUI = Instantiate(GetDialogueUI(), Vector3.zero, Quaternion.identity);

            return tmpDialogueUI;
        }

      

        public void LoadSaveDataUI()
        {
            m_SaveDataUI = m_Resources.LoadUI("SaveDataUI");
        }

        public GameObject GetSaveDataUI()
        {
            return m_SaveDataUI;
        }

        public GameObject InstantiateSaveDataUI() //之後要改
        {
            LoadSaveDataUI();
            GameObject tmpUI = Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);

            return tmpUI;
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
            m_LoadingScreenUI = m_Resources.LoadUI("LoadingUI");
        }

        public GameObject GetLoadingScreenUI()
        {
            return m_LoadingScreenUI;
        }

        private Transform GetCanvasTransform()
        {
            GameObject m_RootUI = UITool.FindUIGameObject("Canvas");

            return m_RootUI.transform;
        }

        private GameObject SetObjRectTransformToNormal(GameObject tmpObj)
        {
            RectTransform tmpRt = tmpObj.GetComponent<RectTransform>();
            tmpRt.offsetMin = tmpRt.offsetMax = Vector2.zero;

            return tmpObj;
        }

        private GameObject SetObjToCanvas(GameObject tmpObj)
        {
            tmpObj.transform.SetParent(GetCanvasTransform());

            return tmpObj;
        }

        private GameObject SetObjIntoGame(GameObject instantiateObj)//TODO:之後要想好一點的名字，功能為一系列物件創造在遊戲裡的過程
        {
            //TODO:之後可能要有switch的工廠
            instantiateObj = SetObjToCanvas(instantiateObj);
            instantiateObj = SetObjRectTransformToNormal(instantiateObj);

            return instantiateObj;
        }
    }
}
