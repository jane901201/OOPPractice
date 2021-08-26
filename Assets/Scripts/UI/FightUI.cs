using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Unreal.UI
{
    public class FightUI : IUserInterface
    {
        [SerializeField] private GameObject m_FightUI;
        [SerializeField] private Button m_GamePauseUIBtn;

        private Action m_GetGamePauseUI;

        public override void Initialize()
        {
            SetGamePauseUIBtn();
            m_DelegateInitialize();
        }

        public void SetGamePauseUI(Action gamePauseUI)
        {
            m_GetGamePauseUI = gamePauseUI;
        }

        public void SetFightUIIsActive()
        {
            m_FightUI.SetActive(true);
        }

        public void SetFightUIIsNotActive()
        {
            m_FightUI.SetActive(false);
        }

        private void SetGamePauseUIBtn()
        {
            m_GamePauseUIBtn.onClick.AddListener(() => m_GetGamePauseUI());
        }

      
    }
}