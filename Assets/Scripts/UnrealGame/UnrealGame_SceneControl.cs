using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;
using UnityEngine.UI;
using Unreal.BaseClass;
using Unreal.Dialogue;
using UnityEngine.Localization;

/// <summary>
/// 呼叫Loading介面
/// 除理視窗需要的設定
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {
        private GameObject m_RootUI = null;
        public void SetMainMenuScene()
        {
            MainMenuScene mainMenuScene = new MainMenuScene(m_SceneController);
            LoadMainMenuUI();
            mainMenuScene.SceneBegin = delegate ()
            {
                m_RootUI = UITool.FindUIGameObject("Canvas");
                GameObject tmpMainMenuUI = Instantiate(GetMainMenuUI(), Vector3.zero, Quaternion.identity);
                tmpMainMenuUI.transform.SetParent(m_RootUI.transform);

                #region MainMenuUISet
                tmpMainMenuUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
                tmpMainMenuUI.GetComponent<MainMenuUI>().BeginBtn.onClick.AddListener(
                    () => SetSchoolScene()
                );

                tmpMainMenuUI.GetComponent<MainMenuUI>().ContinureBtn.onClick.AddListener(
                        delegate()
                        {
                            LoadSaveDataUI();
                            Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);
                        }
                
                    );
                tmpMainMenuUI.GetComponent<MainMenuUI>().LeaveBtn.onClick.AddListener(
                    () => Application.Quit()
                    );
                #endregion
               
                m_RootUI = UITool.FindUIGameObject("Canvas");
                tmpMainMenuUI.transform.SetParent(m_RootUI.transform);
                

            };

            mainMenuScene.SceneUpdate = delegate
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
            GameObject tmpDialogueUIObj = null;
            DialogueUI tmpDialogueUI = tmpDialogueUIObj.GetComponent<DialogueUI>();
            m_DialogueSystem = new DialogueSystem();
            LocalizedObject tmpStoryLocal = new LocalizedObject();
            ConverationData tmpCovnerationData = new ConverationData();
            int table = 0;
            int reference = 0;
            string[][] converation = tmpCovnerationData.GetConveration();
            string currectChapter = "Chapter" + table.ToString();
            string currectConveration = converation[table][reference];

            tmpStoryLocal.SetReference(currectChapter, currectConveration);

            tmpTempleScene.SceneBegin = delegate()
            {
                tmpDialogueUIObj = GetDialogueUI();

                tmpDialogueUI.ShowSentencePanel();
                tmpDialogueUI.HideChoicePanel();

                m_DialogueSystem.SetStoryLocal(tmpStoryLocal);
                m_DialogueSystem.Initialize();

                m_DialogueSystem.ActionButton = delegate ()
                {
                    //TODO:之後要思考怎麼設計Button的設定
                    tmpDialogueUI.ButtonA.onClick.AddListener(() => SetChoice());
                    tmpDialogueUI.ButtonB.onClick.AddListener(() => SetChoice());
                    tmpDialogueUI.ButtonC.onClick.AddListener(() => SetChoice());
                    tmpDialogueUI.ButtonD.onClick.AddListener(() => SetChoice());
                };

                m_DialogueSystem.ActionName = delegate ()
                {
                    tmpDialogueUI.SetNameText(GetName());
                };

                m_DialogueSystem.ActionSentence = delegate ()
                {
                    tmpDialogueUI.SetSentenceText(GetSentence());
                };
            };

            tmpTempleScene.SceneUpdate = delegate
            {
                tmpDialogueUI.UIUpdate();
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

        public void SetButton(int i, DialogueUI dialogueUI, DialogueSystem dialogueSystem)
        {
            switch(i) {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    Debug.Log("Something error happen in DialogueUI's button");
                    break;
            }
                
        }
    }
}