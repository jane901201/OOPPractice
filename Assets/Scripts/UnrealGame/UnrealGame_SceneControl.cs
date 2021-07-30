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
            SetMainMenuUI();
            //TODO:Instantiate(GetMainMenuUI(), Vector3.zero, Quaternion.identity);
            mainMenuScene.SceneBegin = delegate ()
            {
                m_RootUI = UITool.FindUIGameObject("Canvas");
                GameObject tmpMainMenuUI = Instantiate(GetMainMenuUI(), Vector3.zero, Quaternion.identity);
                tmpMainMenuUI.transform.SetParent(m_RootUI.transform);
                tmpMainMenuUI.GetComponent<MainMenuUI>().BeginBtn.onClick.AddListener(
                    () => SetSchoolScene()
                );

                tmpMainMenuUI.GetComponent<MainMenuUI>().ContinureBtn.onClick.AddListener(
                        delegate()
                        {
                            SetSaveDatatUI();
                            Instantiate(GetSaveDataUI(), Vector3.zero, Quaternion.identity);
                        }
                
                    );
                tmpMainMenuUI.GetComponent<MainMenuUI>().LeaveBtn.onClick.AddListener(
                    () => Application.Quit()
                    );
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
            StartCoroutine(m_SceneController.SetLoadingScene(new TempleScene(m_SceneController)));
            
        }

        public void SetSchoolScene()
        {
            StartCoroutine(m_SceneController.SetLoadingScene(new SchoolScene(m_SceneController)));
            
        }

        public void SceneUpdate()
        {
            m_SceneController.SceneUpdate();
        }
    }
}