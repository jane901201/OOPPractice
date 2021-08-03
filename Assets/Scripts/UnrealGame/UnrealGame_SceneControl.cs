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
                    () => SetTempleScene() //測試用
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
            GameObject tmpDialogueUIObj = InstantiateDialogeUI();
            DialogueUI tmpDialogueUI = tmpDialogueUIObj.GetComponent<DialogueUI>();
            m_DialogueSystem = new DialogueSystem();
            LocalizedTextAsset tmpStoryLocal = new LocalizedTextAsset();
            ConverationData tmpCovnerationData = new ConverationData();
            tmpCovnerationData.Initinal();
            int table = 0;
            int reference = 0;
            string[][] converation = tmpCovnerationData.GetConveration();
            Debug.Log(converation);
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

                m_DialogueSystem.m_SetChoiceBtn = delegate(Action OnClickChoiceBtn , int i)
                {
                    switch (i)
                    {
                        case 0:
                            tmpDialogueUI.ButtonA.onClick.AddListener(() => OnClickChoiceBtn());
                            break;
                        case 1:
                            tmpDialogueUI.ButtonB.onClick.AddListener(() => OnClickChoiceBtn());
                            break;
                        case 2:
                            tmpDialogueUI.ButtonC.onClick.AddListener(() => OnClickChoiceBtn());
                            break;
                        case 3:
                            tmpDialogueUI.ButtonD.onClick.AddListener(() => OnClickChoiceBtn());
                            break;
                        default:
                            Debug.Log("Something error happen in DialogueUI's button");
                            break;
                    }
                };

                m_DialogueSystem.m_SetName = delegate (string name)
                {
                    tmpDialogueUI.SetNameText(name);
                };

                m_DialogueSystem.m_SetSentence = delegate (string sentence)
                {
                    tmpDialogueUI.SetSentenceText(sentence);
                };
                m_DialogueSystem.m_SetContinueBtn = delegate ()
                {
                    bool tmpIsClick = false;
                    tmpDialogueUI.ContinueButton.onClick.AddListener(delegate
                    {
                        tmpIsClick = isClick();
                    });
                    return tmpIsClick;
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

        public bool isClick()
        {
            return true;
        }
    }
}