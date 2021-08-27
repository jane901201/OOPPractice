using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.BaseClass;
/// <summary>
/// 暫時將IGameSystem的Delegate的宣告放在這裡
/// TODO:未來會把DelegateInitialize跟Initialize等等拆開
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {

        List<IGameSystem> m_GameSystems = new List<IGameSystem>();

        public void AddGameSystem(IGameSystem gameSystem)
        {
            m_GameSystems.Add(gameSystem);
        }

        public void RemoveGameSystem(IGameSystem gameSystem)
        {
            if(m_GameSystems.Contains(gameSystem))
            {
                m_GameSystems.Remove(gameSystem);
            }
        }

        public void UpdateGameSystem() //TODO:未來為主要的Update
        {
            if(m_GameSystems.Count > 0)
            {
                for(int i = 0; i < m_GameSystems.Count; i++)
                {
                    m_GameSystems[i].Update();
                }
            }
        }

        public void SetSaveDataManagerDelegateInitialize()
        {
            m_SaveDataManager.m_DelegateInitialize = delegate ()
            {
                m_SaveDataManager.SetResources(m_Resources);
                m_SaveDataManager.SetShowDataCheckInfoUI(m_DataCheckInfoUI.ShowDataCheckInfoUI);
                m_SaveDataManager.SetHideDataCheckInfoUI(m_DataCheckInfoUI.HideDataCheckInfoUI);
                m_SaveDataManager.SetSaveDataIsNotFoundAlert(m_DataCheckInfoUI.ShowSaveDataIsNotFoundAlert);
                m_SaveDataManager.SetWantToLoadDavaAlert(m_DataCheckInfoUI.ShowWantToLoadDavaAlert);
            };
            m_SaveDataManager.Initialize();
        }

        public void SetSceneControllerDelegateInitialize()
        {
            m_SceneController.m_DelegateInitialize = delegate ()
            {
                m_SceneController.SetLoadingUI(CreateLoadingUI);
            };
            m_SceneController.Initialize();
        }

        public void SetDialgoueSystemDelegateInitialize()
        {
            if(m_DialogueSystem == null) //TODO:好吧，這裡的生成有點意外
            {
                m_DialogueSystem = new Dialogue.DialogueSystem();
            }
            m_DialogueSystem.m_DelegateInitialize = delegate ()
            {
                int table = 0;
                int reference = 0;
                m_DialogueSystem.GetName(m_DialogueUI.SetNameText);
                m_DialogueSystem.GetSentence(m_DialogueUI.SetSentenceText);
                m_DialogueSystem.GetAvatar(m_DialogueUI.SetAvatar);
                m_DialogueSystem.GetChoicePanel(m_DialogueUI.SetAllBtnState);
                m_DialogueSystem.SetStoryTextAsset(m_Resources.LoadConverationTextAssetInk(table, reference)); //TODO:重點段落，設置存檔的點
            };
            m_DialogueSystem.Initialize();
        }

        public void SetDialogueSystemDelegateUpdate()
        {
            m_DialogueSystem.m_DelegateGameSystemUpdate = delegate () //TODO:m_DelegateGameSystemUpdate會拋出意外NullReferenceException
            {
                if (m_UIs.Contains(m_DialogueUI)) //TODO:之後要改成陣列
                {
                    if (m_DialogueSystem.IsStoryEnd()) //TODO:IsStoryEnd的判斷要做在m_DialogueSystem裡面
                    {
                        RemoveUI(m_DialogueUI);
                        m_DialogueUI.Release();
                        CreateAndInitinalFightUI();

                    }
                }

            };
        }
    }
}