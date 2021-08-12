using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/SaveDataUI")]
    public class SaveDataUI : IUserInterface
    {
        [SerializeField] private GameObject m_SaveDataObj;
        [SerializeField] private Button m_SaveDataBtn;
        [SerializeField] private Text m_SaveDataNum;

        public GameObject SaveDataObj { get => m_SaveDataObj; set => m_SaveDataObj = value; }
        public Button LoadSaveDataBtn { get => m_SaveDataBtn; set => m_SaveDataBtn = value; }

        public void SetAllSaveDataState(Action SaveDataFile)
        {
            //TODO:存檔資料的設定
        }


    }
}

