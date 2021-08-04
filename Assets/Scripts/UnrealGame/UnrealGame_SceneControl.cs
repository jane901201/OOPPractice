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
                RectTransform tmpRt = tmpMainMenuUI.GetComponent<RectTransform>();
                tmpRt.offsetMin = tmpRt.offsetMax = Vector2.zero;
                tmpMainMenuUI.GetComponent<MainMenuUI>().BeginBtn.onClick.AddListener(
                    () => SetTempleScene() //TODO:測試用，之後要改
                );

                tmpMainMenuUI.GetComponent<MainMenuUI>().ContinureBtn.onClick.AddListener(
                        delegate()
                        {
                            LoadSaveDataUI();
                            GameObject tmpSaveDataUI =  Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);
                            tmpSaveDataUI.transform.SetParent(m_RootUI.transform);
                            RectTransform tmpRt = tmpSaveDataUI.GetComponent<RectTransform>();
                            tmpRt.offsetMin = tmpRt.offsetMax = Vector2.zero;
                        }
                
                    );
                tmpMainMenuUI.GetComponent<MainMenuUI>().LeaveBtn.onClick.AddListener(
                    () => Application.Quit()
                    );
                #endregion
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
            LoadDialogueUI();
            m_DialogueSystem = new DialogueSystem();
            LocalizedTextAsset tmpStoryLocal = new LocalizedTextAsset();
            ConverationData tmpCovnerationData = new ConverationData();
            tmpCovnerationData.Initinal();
            int table = 0;
            int reference = 0;
            string[][] converation = tmpCovnerationData.GetConveration();
            string currectChapter = "Chapter" + table.ToString();
            string currectConveration = converation[table][reference];

            tmpStoryLocal.SetReference(currectChapter, currectConveration);

            tmpTempleScene.SceneBegin = delegate()
            {
                m_RootUI = UITool.FindUIGameObject("Canvas");

                GameObject tmpDialogueUIObj = Instantiate(GetDialogueUI(), Vector3.zero, Quaternion.identity); ;
                tmpDialogueUIObj.transform.SetParent(m_RootUI.transform);
                RectTransform tmpRt = tmpDialogueUIObj.GetComponent<RectTransform>();
                tmpRt.offsetMin = tmpRt.offsetMax = Vector2.zero;
                //tmpDialogueUIObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
                DialogueUI tmpDialogueUI = tmpDialogueUIObj.GetComponent<DialogueUI>();
                tmpDialogueUI.ShowSentencePanel();
                tmpDialogueUI.HideChoicePanel();

                m_DialogueSystem.SetStoryLocal(tmpStoryLocal);

                m_DialogueSystem.m_SetChoiceBtn = delegate(Action OnClickChoiceBtn , int i, Choice choice)
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
                            tmpDialogueUI.HideSentencePanel();
                            tmpDialogueUI.ShowChoicePanel();
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
              
                tmpDialogueUI.ContinueButton.onClick.AddListener(delegate
                {
                    m_DialogueSystem.RefreshView();
                });

                


                m_DialogueSystem.gsUpdate = delegate ()
                {
                    m_DialogueSystem.m_SetChoiceBtn = delegate (Action OnClickChoiceBtn, int i, Choice choice)
                    {
                        tmpDialogueUI.HideSentencePanel();
                        tmpDialogueUI.ShowChoicePanel();

                        switch (i)
                        {
                            case 0:
                                tmpDialogueUI.ButtonA.GetComponentInChildren<Text>().text = choice.text.Trim();
                                tmpDialogueUI.ButtonA.onClick.AddListener(
                                    delegate()
                                    {
                                        OnClickChoiceBtn();
                                        tmpDialogueUI.HideChoicePanel();
                                        tmpDialogueUI.ShowSentencePanel();
                                    }
                                    );
                                break;
                            case 1:
                                tmpDialogueUI.ButtonB.GetComponentInChildren<Text>().text = choice.text.Trim();
                                tmpDialogueUI.ButtonB.onClick.AddListener(
                                     delegate ()
                                     {
                                         OnClickChoiceBtn();
                                         tmpDialogueUI.HideChoicePanel();
                                         tmpDialogueUI.ShowSentencePanel();
                                     }
                                    );
                                break;
                            case 2:
                                tmpDialogueUI.ButtonC.GetComponentInChildren<Text>().text = choice.text.Trim();
                                tmpDialogueUI.ButtonC.onClick.AddListener(
                                     delegate ()
                                     {
                                         OnClickChoiceBtn();
                                         tmpDialogueUI.HideChoicePanel();
                                         tmpDialogueUI.ShowSentencePanel();
                                     }
                                    );
                                break;
                            case 3:
                                tmpDialogueUI.ButtonD.GetComponentInChildren<Text>().text = choice.text.Trim();
                                tmpDialogueUI.ButtonD.onClick.AddListener(
                                     delegate ()
                                     {
                                         OnClickChoiceBtn();
                                         tmpDialogueUI.HideChoicePanel();
                                         tmpDialogueUI.ShowSentencePanel();
                                     }
                                    );
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

        public bool isClick()
        {
            return true;
        }
    }
}