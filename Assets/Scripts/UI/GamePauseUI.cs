using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/GamePauseUI")]
    public class GamePauseUI : IUserInterface
    {
        [SerializeField] private GameObject m_GamePauseUI;
        [SerializeField] private Button m_SaveDataBtn;

        private Action m_GetSaveDataUI;

        public override void Initialize()
        {
            SetSaveDataBtn();
            m_DelegateInitialize();
        }

        public void SetSaveDataUI(Action saveDataUI)
        {
            m_GetSaveDataUI = saveDataUI;
        }

        private void SetSaveDataBtn()
        {
            m_SaveDataBtn.onClick.AddListener(() => m_GetSaveDataUI());
        }

    }
}

