using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;
using UnityEngine.UI;
using Unreal.BaseClass;
using Unreal.Dialogue;
using UnityEngine.Localization;
using Ink.Runtime;


/// <summary>
/// 呼叫Loading介面
/// 除理視窗需要的設定
/// TODO:這裡的東西最終會搬到Factory跟Builder的架構裡
/// </summary>

namespace Unreal
{
    public partial class UnrealGame
    {
        public void SetMainMenuScene()
        {
            MainMenuScene mainMenuScene = new MainMenuScene(m_SceneController);
            LoadMainMenuUI();
            MainMenuUI tmpMainMenuUI = new MainMenuUI(); //TODO:修整這裡的程式碼

            mainMenuScene.SceneBegin = delegate ()
            {
                GameObject tmpMainMenuUIObj = Instantiate(GetMainMenuUI(), Vector3.zero, Quaternion.identity);
                tmpMainMenuUIObj.transform.SetParent(GetCanvasTransform());

                #region MainMenuUISet
                RectTransform tmpRt = tmpMainMenuUIObj.GetComponent<RectTransform>();
                tmpRt.offsetMin = tmpRt.offsetMax = Vector2.zero;
                tmpMainMenuUIObj.GetComponent<MainMenuUI>().BeginBtn.onClick.AddListener(
                    () => SetTempleScene() //TODO:測試用，之後要改
                );

                tmpMainMenuUIObj.GetComponent<MainMenuUI>().ContinureBtn.onClick.AddListener(
                        delegate ()
                        {
                            LoadSaveDataUI();
                            GameObject tmpSaveDataUI = Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);
                            tmpSaveDataUI.transform.SetParent(GetCanvasTransform());
                            RectTransform tmpRt = tmpSaveDataUI.GetComponent<RectTransform>();
                            tmpRt.offsetMax = tmpRt.offsetMin = Vector2.zero;
                        }

                    );
                tmpMainMenuUIObj.GetComponent<MainMenuUI>().LeaveBtn.onClick.AddListener(
                    () => Application.Quit()
                    );



                #endregion
            };

            mainMenuScene.SceneUpdate = delegate ()
            {

            };

            mainMenuScene.SceneEnd = delegate
            {

            };


            StartCoroutine(m_SceneController.SetLoadingScene(mainMenuScene));
        }

        public void SetTempleScene()
        {
            TempleScene tmpTempleScene = new TempleScene(m_SceneController);
            LoadDialogueUI();
            m_DialogueSystem = new DialogueSystem();
            LocalizedTextAsset tmpStoryLocal = new LocalizedTextAsset();
            ConverationData tmpCovnerationData = new ConverationData();


            string[] TestChapterString = m_Resources.LoadConveration(0, 0);
            TextAsset testTextAsset = m_Resources.LoadStoryTable(TestChapterString[0], TestChapterString[1]);


            tmpCovnerationData.Initinal();
            int table = 0;
            int reference = 0;
            string[][] converation = tmpCovnerationData.GetConveration();
            string currectChapter = "Chapter" + table.ToString();
            string currectConveration = converation[table][reference];

            tmpStoryLocal.SetReference(currectChapter, currectConveration);

            tmpTempleScene.SceneBegin = delegate()
            {

                //TODO:Localization資料讀取要做在ProjectResources裡
                GameObject tmpDialogueUIObj = Instantiate(GetDialogueUI(), Vector3.zero, Quaternion.identity); ;
                tmpDialogueUIObj.transform.SetParent(GetCanvasTransform());
                RectTransform tmpRt = tmpDialogueUIObj.GetComponent<RectTransform>();
                tmpRt.offsetMin = tmpRt.offsetMax = Vector2.zero;
                DialogueUI tmpDialogueUI = tmpDialogueUIObj.GetComponent<DialogueUI>();
                tmpDialogueUI.ShowSentencePanel();
                tmpDialogueUI.HideChoicePanel();

                m_DialogueSystem.SetStoryLocal(tmpStoryLocal);

                m_DialogueSystem.m_SetChoiceBtn = delegate(int btnNum, Action OnClickChoiceBtn, string choiceText)
                {

                };

                m_DialogueSystem.m_SetName = new DialogueSystem.SetName(tmpDialogueUI.SetNameText);

                m_DialogueSystem.m_SetSentence = new DialogueSystem.SetSentence(tmpDialogueUI.SetSentenceText);

                m_DialogueSystem.m_SetChoicePanel = delegate ()
                {

                };

                tmpDialogueUI.ContinueButton.onClick.AddListener(delegate
                {
                    m_DialogueSystem.RefreshView();
                });


                m_DialogueSystem.gsUpdate = delegate ()
                {

                    m_DialogueSystem.m_SetChoiceBtn = new DialogueSystem.SetChoiceBtn(tmpDialogueUI.SetAllBtnState);

                    m_DialogueSystem.m_SetName = new DialogueSystem.SetName(tmpDialogueUI.SetNameText);

                    m_DialogueSystem.m_SetSentence = new DialogueSystem.SetSentence(tmpDialogueUI.SetSentenceText);

                    //m_DialogueSystem.m_SetChoicePanel = new DialogueSystem.SetChoicePanel(tmpDialogueUI.SetAvatar);

                    tmpDialogueUI.ContinueButton.onClick.AddListener(delegate
                    {
                        if(IsPressTime(1f))
                        {
                            m_DialogueSystem.RefreshView();
                        }
                    });

                    if(m_DialogueSystem.IsStoryEnd())
                    {
                        tmpDialogueUI.Release();
                    }
                };
                    
                m_DialogueSystem.Initialize();

            };

            tmpTempleScene.SceneUpdate = delegate
            {
                m_DialogueSystem.gsUpdate();
            };

            tmpTempleScene.SceneEnd = delegate
            {

            };

            StartCoroutine(m_SceneController.SetLoadingScene(tmpTempleScene));
        }

        public void SetSchoolScene()
        {
            SchoolScene tmpSchoolScene = new SchoolScene(m_SceneController);
            

            tmpSchoolScene.SceneBegin = delegate
            {

            };

            tmpSchoolScene.SceneUpdate = delegate
            {

            };

            tmpSchoolScene.SceneEnd = delegate
            {

            };

            StartCoroutine(m_SceneController.SetLoadingScene(tmpSchoolScene));            
        }

        public void SceneUpdate()
        {
            m_SceneController.SceneUpdate();
        }

        public bool IsPressTime(float waitTime)
        {
            float time = 0;
            
            while(waitTime >= time)
            {
                time += Time.deltaTime;
                return false;
            }

            return true;
        }

        public Transform GetCanvasTransform()
        {
            GameObject m_RootUI = UITool.FindUIGameObject("Canvas");

            return m_RootUI.transform;
        }
    }
}