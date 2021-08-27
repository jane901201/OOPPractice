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
/// TODO:要把這裡UI的實作全部消除掉
/// </summary>

namespace Unreal
{
    public partial class UnrealGame
    {
        public void SetMainMenuScene()
        {
            MainMenuScene mainMenuScene = new MainMenuScene(m_SceneController);
            

            mainMenuScene.SceneBegin = delegate ()
            {
                CreateAndInitinalMainMenuUI();     
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
            m_DialogueSystem = new DialogueSystem();

            int table = 0;
            int reference = 0;


            tmpTempleScene.SceneBegin = delegate ()
            {
                GameObject tmpDialogueUIObj = SetObjIntoGame(InstantiateDialogeUI());
                DialogueUI tmpDialogueUI = tmpDialogueUIObj.GetComponent<DialogueUI>();
                AddUI(tmpDialogueUI);
                tmpDialogueUI.ShowSentencePanel();
                tmpDialogueUI.HideChoicePanel();

                m_DialogueSystem.SetStoryTextAsset(m_Resources.LoadConverationTextAssetInk(table, reference)); //TODO:重點段落，設置存檔的點

                m_DialogueSystem.m_MustBeRemove_SetChoiceBtn = new DialogueSystem.SetChoiceBtn(tmpDialogueUI.SetAllBtnState); //TODO:要設定在Initinal才比較好
                m_DialogueSystem.m_MustBeRemove_SetName = new DialogueSystem.SetName(tmpDialogueUI.SetNameText);
                m_DialogueSystem.m_MustBeRemove_SetSentence = new DialogueSystem.SetSentence(tmpDialogueUI.SetSentenceText);
                //TODO:m_DialogueSystem.m_SetAvater = new DialogueSystem.SetAvatar(tmpDialogueUI.SetAvatar);

                m_DialogueSystem.m_MustBeRemove_SetChoicePanel = delegate ()
                {

                };

                tmpDialogueUI.ContinueButton.onClick.AddListener(delegate
                {
                    m_DialogueSystem.RefreshView();
                });


                m_DialogueSystem.m_DelegateGameSystemUpdate = delegate () //TODO:m_DelegateGameSystemUpdate會拋出意外NullReferenceException
                {
                    if(m_UIs.Contains(tmpDialogueUI)) //TODO:之後要改成陣列
                    {
                        if (m_DialogueSystem.IsStoryEnd()) //TODO:IsStoryEnd的判斷要做在m_DialogueSystem裡面
                        {
                            RemoveUI(tmpDialogueUI);
                            tmpDialogueUI.Release();
                            CreateAndInitinalFightUI();

                        }
                    }
                   
                };

                m_DialogueSystem.Initialize();

            };

            tmpTempleScene.SceneUpdate = delegate
            {
                m_DialogueSystem.m_DelegateGameSystemUpdate();
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

            while (waitTime >= time)
            {
                time += Time.deltaTime;
                return false;
            }

            return true;
        }

    }
}