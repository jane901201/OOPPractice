using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.UI;
/// <summary>
/// 暫時將IUserInterface的Delegate的宣告放在這裡
/// TODO:過度展示內部細節的問題之後要解決
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {
        List<IUserInterface> m_UIs = new List<IUserInterface>();

        public void AddUI(IUserInterface ui)
        {
            m_UIs.Add(ui);
        }

        public void RemoveUI(IUserInterface ui)
        {
            if (m_UIs.Contains(ui))
            {
                m_UIs.Remove(ui);
            }
        }

        public void UpdateUI() //TODO:未來為主要的Update
        {
            if (m_UIs.Count > 0)
            {
                for (int i = 0; i < m_UIs.Count; i++)
                {
                    ;
                }
            }
        }

        public SaveDataUI SetSaveDataUIDelegateInitialize(GameObject saveDataUIObj)
        {
            /*TODO:之後要想比較好的方法...
             * 順序
             * SaveDataNumText
             * ChapterText
             * PartText
             * PlayerNameText
             * TimeText
             * DifficultlyText
             */
            m_SaveDataUI = saveDataUIObj.GetComponent<SaveDataUI>();
            m_SaveDataUI.m_DelegateInitialize = delegate ()
            {
                m_SaveDataUI.SetAllSaveDataState(LoadSaveData);
                m_SaveDataUI.SetLoadingUI(CreateDataCheckInfoUI);
            };

            return m_SaveDataUI;
        }

        public void SetSaveDataUIDelegateInitialize()
        {
            m_SaveDataUI.m_DelegateInitialize = delegate ()
            {
                m_SaveDataUI.SetAllSaveDataState(LoadSaveData);
                m_SaveDataUI.SetLoadingUI(CreateDataCheckInfoUI);
            };
            m_SaveDataUI.Initialize();
        }

        public void SetFightUIDelegateInitialize()
        {
            m_FightUI.m_DelegateInitialize = delegate ()
            {
                m_FightUI.SetGamePauseUI(CreateAndInitinalGamePauseUI);
            };
            m_FightUI.Initialize();
        }

        public void SetGamePauseUIDelegateInitialize()
        {
            m_GamePauseUI.m_DelegateInitialize = delegate ()
            {
                m_GamePauseUI.SetSaveDataUI(CreateAndInitinalSaveDataUI);
            };
            m_GamePauseUI.Initialize();
        }
    }
}