using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;
using Unreal.BaseClass;
using UnityEngine.SceneManagement;

namespace Unreal
{
    /// <summary>
    /// 設置UI的路徑
    /// 設置UI的功能?
    /// TODO:可能之後這裡會獨立出來，專門產生Instantiate物件
    /// TODO:UI跟UIInterfaceFactory的分工之後要認真想
    /// </summary>
    public partial class UnrealGame
    {
        private GameObject m_MainMenuUIObj = null;
        private GameObject m_DialogueUIObj = null;
        private GameObject m_SaveDataUIObj = null;
        private GameObject m_GamePauseUIObj = null;
        private GameObject m_LoadingScreenUIObj = null;
        private GameObject m_DataCheckInfoUIObj = null;

        private SaveDataUI m_SaveDataUI = null;


        public void LoadMainMenuUI()
        {
            m_MainMenuUIObj = m_Resources.LoadUI("MainMenuUI"); 
        }

        public GameObject GetMainMenuUI()
        {
            return m_MainMenuUIObj;
        }

        public GameObject InstantiateMainMenuUI()
        {
            LoadMainMenuUI();
            GameObject tmpMainMenuUI = Instantiate(GetMainMenuUI(), Vector3.zero, Quaternion.identity);

            return tmpMainMenuUI;
        }

        public void LoadDialogueUI()
        {
            m_DialogueUIObj = m_Resources.LoadUI("DialogueUI"); 
        }

        public GameObject GetDialogueUI()
        {
            return m_DialogueUIObj;
        }

        public GameObject InstantiateDialogeUI() //之後要改
        {
            LoadDialogueUI();
            GameObject tmpDialogueUI = Instantiate(GetDialogueUI(), Vector3.zero, Quaternion.identity);

            return tmpDialogueUI;
        }

      

        public void LoadSaveDataUI()
        {
            m_SaveDataUIObj = m_Resources.LoadUI("SaveDataUI");
        }

        public GameObject GetSaveDataUI()
        {
            return m_SaveDataUIObj;
        }

        public GameObject InstantiateSaveDataUI() //之後要改
        {
            LoadSaveDataUI();
            GameObject tmpUI = Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);

            return tmpUI;
        }


        public void LoadGamePauseUI()
        {
            m_GamePauseUIObj = m_Resources.LoadUI("GamePauseUI"); 
        }

        public GameObject GetGamePauseUI()
        {
            return m_GamePauseUIObj;
        }   
        public void LoadLoadingUI()
        {
            m_LoadingScreenUIObj = m_Resources.LoadUI("LoadingUI");
        }

        public GameObject GetLoadingScreenUI() //TODO:名子晚點改
        {
            return m_LoadingScreenUIObj;
        }

        public GameObject InstantiateLoadingUI()
        {
            LoadLoadingUI();
            GameObject tmpUI = Instantiate(GetLoadingScreenUI(), Vector3.zero, Quaternion.identity);

            return tmpUI;
        }

        private void CreateLoadingUI() //TODO:測試一下這樣能不能成功創造物件
        {
            GameObject tmpLoadingUIObj = SetObjIntoGame(InstantiateLoadingUI());
            DataCheckInfoUI tmpLoadingUI = tmpLoadingUIObj.GetComponent<DataCheckInfoUI>();
            tmpLoadingUI.Initialize();
        }

        public void LoadDataCheckInfoUI()
        {
            m_DataCheckInfoUIObj = m_Resources.LoadUI("DataCheckInfoUI");
        }

        public GameObject GetDataCheckInfoUI()
        {
            return m_DataCheckInfoUIObj;
        }

        public GameObject InstantiateDataCheckInfoUI() //TODO:之後要改
        {
            LoadDataCheckInfoUI();
            GameObject tmpUI = Instantiate(GetDataCheckInfoUI(), Vector3.zero, Quaternion.identity);

            return tmpUI;
        }

        private void CreateDataCheckInfoUI() //TODO:測試一下這樣能不能成功創造物件
        {
            GameObject tmpDataCheckInfoUIObj = SetObjIntoGame(InstantiateDataCheckInfoUI());
            DataCheckInfoUI tmpDataCheckInfoUI = tmpDataCheckInfoUIObj.GetComponent<DataCheckInfoUI>();
            tmpDataCheckInfoUI.Initialize();

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

        private GameObject SetObjIntoGame(GameObject instantiateObj, IScene scene)//TODO:之後要想好一點的名字，功能為一系列物件創造在遊戲裡的過程
        {
            //TODO:之後可能要有switch的工廠
            SceneManager.MoveGameObjectToScene(instantiateObj, SceneManager.GetSceneByName(scene.ToString()));
            instantiateObj = SetObjToCanvas(instantiateObj);
            instantiateObj = SetObjRectTransformToNormal(instantiateObj);

            return instantiateObj;
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
