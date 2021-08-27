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
    /// TODO:重複的程式碼是真的多到爆炸了，要好好研究Factory的做法了
    /// </summary>
    public partial class UnrealGame
    {
        //TODO:要用掉所有UI的Field的Obj
        private GameObject m_MainMenuUIObj = null;
        private GameObject m_DialogueUIObj = null;
        private GameObject m_SaveDataUIObj = null;
        private GameObject m_GamePauseUIObj = null;
        private GameObject m_LoadingScreenUIObj = null;
        private GameObject m_DataCheckInfoUIObj = null;
        private GameObject m_FightUIObj = null;

        private MainMenuUI m_MainMenuUI = null;
        private DialogueUI m_DialogueUI = null;
        private SaveDataUI m_SaveDataUI = null;
        private GamePauseUI m_GamePauseUI = null;
        private FightUI m_FightUI = null;
        private DataCheckInfoUI m_DataCheckInfoUI = null;

        #region UI創建(未來會用Factory模式代替)

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

        private void CreateMainMenuUI()
        {
            GameObject tmpMainMenuUIObj = SetObjIntoGame(InstantiateMainMenuUI());
            m_MainMenuUI = tmpMainMenuUIObj.GetComponent<MainMenuUI>();
            AddUI(m_MainMenuUI);

        }

        public void CreateAndInitinalMainMenuUI()
        {
            CreateMainMenuUI();
            SetMainMenuUIDelegateInitialize();
        }

        public void LoadDialogueUI()
        {
            m_DialogueUIObj = m_Resources.LoadUI("DialogueUI"); 
        }

        public GameObject GetDialogueUI()
        {
            return m_DialogueUIObj;
        }

        public GameObject InstantiateDialogueUI() //TODO:之後要讓每個Instinate不依賴field variable
        {
            LoadDialogueUI();
            GameObject tmpDialogueUI = Instantiate(GetDialogueUI(), Vector3.zero, Quaternion.identity);

            return tmpDialogueUI;
        }

        private void CreateDialgoueUI()
        {
            GameObject tmpDialogueUIObj = SetObjIntoGame(InstantiateDialogueUI());
            m_DialogueUI = tmpDialogueUIObj.GetComponent<DialogueUI>();
            AddUI(m_DialogueUI);
        }

        private void CreateAndInitinalDialogueUI()
        {
            CreateDialgoueUI();
            SetDialogueUIDelegatInitialize();
        }

        public void LoadSaveDataUI()
        {
            m_SaveDataUIObj = m_Resources.LoadUI("SaveDataUI");
        }

        public GameObject GetSaveDataUI()
        {
            return m_SaveDataUIObj;
        }

        public GameObject InstantiateSaveDataUI()
        {
            LoadSaveDataUI();
            GameObject tmpSaveDataUI = Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);

            return tmpSaveDataUI;
        }

        private void CreateSaveDataUI()
        {
            GameObject tmpSaveDataUIObj = SetObjIntoGame(InstantiateSaveDataUI());
            m_SaveDataUI = tmpSaveDataUIObj.GetComponent<SaveDataUI>();
            AddUI(m_SaveDataUI);
        }


        private void CreateAndInitinalSaveDataUI()
        {
            CreateSaveDataUI();
            SetSaveDataUIDelegateInitialize();
        }

        public void LoadGamePauseUI()
        {
            m_GamePauseUIObj = m_Resources.LoadUI("GamePauseUI"); 
        }

        public GameObject GetGamePauseUI()
        {
            return m_GamePauseUIObj;
        }

        public GameObject InstantiateGamePauseUI()
        {
            LoadGamePauseUI();
            GameObject tmpGamePauseUI = Instantiate(GetGamePauseUI(), Vector3.zero, Quaternion.identity);

            return tmpGamePauseUI;
        }

        private void CreateGamePauseUI() //TODO:Create負責的事情是否太多?
        {
            GameObject tmpGamePauseUIObj = SetObjIntoGame(InstantiateGamePauseUI());
            m_GamePauseUI = tmpGamePauseUIObj.GetComponent<GamePauseUI>();
            AddUI(m_GamePauseUI);
        }

        private void CreateAndInitinalGamePauseUI() //TODO:要想更好的辦法處理Create和Initinal
        {
            CreateGamePauseUI();
            SetGamePauseUIDelegateInitialize();
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
            AddUI(tmpLoadingUI);
        }

        public void LoadDataCheckInfoUI()
        {
            m_DataCheckInfoUIObj = m_Resources.LoadUI("DataCheckInfoUI");
        }

        public GameObject GetDataCheckInfoUI()
        {
            return m_DataCheckInfoUIObj;
        }

        public GameObject InstantiateDataCheckInfoUI()
        {
            LoadDataCheckInfoUI();
            GameObject tmpUI = Instantiate(GetDataCheckInfoUI(), Vector3.zero, Quaternion.identity);

            return tmpUI;
        }

        private void CreateDataCheckInfoUI()
        {
            GameObject tmpDataCheckInfoUIObj = SetObjIntoGame(InstantiateDataCheckInfoUI());
            m_DataCheckInfoUI = tmpDataCheckInfoUIObj.GetComponent<DataCheckInfoUI>();
            AddUI(m_DataCheckInfoUI);

        }

        private void CreateAndInitalizeDataCheckInfoUI()
        {
            CreateDataCheckInfoUI();
            SetDataCheckInfoUIDelegateInitialize();
        }

        public void LoadFightUI()
        {
            m_FightUIObj = m_Resources.LoadUI("FightUI");
        }

        public GameObject GetFightUI() //TODO:名子晚點改
        {
            return m_FightUIObj;
        }

        public GameObject InstantiateFightUI()
        {
            LoadFightUI();
            GameObject tmpUI = Instantiate(GetFightUI(), Vector3.zero, Quaternion.identity);

            return tmpUI;
        }

        private void CreateFightUI()
        {
            GameObject tmpFightUIObj = SetObjIntoGame(InstantiateFightUI());
            m_FightUI = tmpFightUIObj.GetComponent<FightUI>();
            AddUI(m_FightUI);
        }

        private void CreateAndInitinalFightUI()
        {
            CreateFightUI();
            SetFightUIDelegateInitialize();
        }

        #endregion

        #region MainMenuUI的Action設置(等整個系統做到一個段落後再決定傳遞多少Action到其他類別比較好吧)
        private void StartGame()
        {
            //TODO:一些物件還有系統的初始化
            //TODO:m_SaveDataManager.StartGame();



            SetTempleScene();//TODO:測試用，之後要改
        }

        private void ContinueGame()
        {
            CreateAndInitinalSaveDataUI();
            CreateAndInitalizeDataCheckInfoUI();
            SetSaveDataManagerDelegateInitialize();//TODO:我沒有想過SaveDataManager跟DataCheckInfoUI的宣告會出事情......
        }

        private void LeaveGame()
        {
            //TODO:存檔
            Application.Quit();
        }
        #endregion

        #region GamePauseUI的Action設置

        #endregion

        #region 共用

        #endregion

        #region 工具類程式

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

        #endregion
    }
}
