using System;
using System.Collections;
using UnityEngine;
using Unreal.UI;
using UnityEngine.UI;
using Unreal.BaseClass;

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
            tmpTempleScene.SceneBegin = delegate
            {

            };

            tmpTempleScene.SceneUpdate = delegate
            {

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
    }
}