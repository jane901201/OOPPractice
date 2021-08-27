using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/MainMenuUI")]
    public class MainMenuUI : IUserInterface
    {

        [SerializeField] private Button m_BeginBtn;
        [SerializeField] private Button m_ContinureBtn;
        [SerializeField] private Button m_LeaveBtn;

        private Action m_GetStratGame;
        private Action m_GetContinueGame;
        private Action m_GetLeaveGame;

        public override void Initialize()
        {
            SetStartGameBtn();
            SetContinueGameBtn();
            SetLeaveGameBtn();
            m_DelegateInitialize();
        }

        public void SetStartGame(Action startGame)
        {
            m_GetStratGame = startGame;
        }

        public void SetContinueGame(Action continueGame)
        {
            m_GetContinueGame = continueGame;
        }

        public void SetLeaveGame(Action leaveGame)
        {
            m_GetLeaveGame = leaveGame;
        }

        private void SetStartGameBtn()
        {
            m_BeginBtn.onClick.AddListener(() => m_GetStratGame());
        }

        private void SetContinueGameBtn()
        {
            m_ContinureBtn.onClick.AddListener(() => m_GetContinueGame());
        }

        private void SetLeaveGameBtn()
        {
            m_LeaveBtn.onClick.AddListener(() => m_GetLeaveGame());
        }
    }
}

