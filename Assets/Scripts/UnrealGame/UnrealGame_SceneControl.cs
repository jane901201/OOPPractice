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

            tmpTempleScene.SceneBegin = delegate ()
            {
                CreateAndInitinalDialogueUI();
                SetDialgoueSystemDelegateInitialize();
                SetDialogueSystemDelegateUpdate();
            };

            tmpTempleScene.SceneUpdate = delegate
            {
                m_DialogueSystem.Update();
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