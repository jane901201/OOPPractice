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
        [SerializeField] private GameObject SaveDataObj;
        [SerializeField] private Button SaveDataBtn;
        [SerializeField] private Text SaveDataNum;

        public void SetAllSaveDataState(Action SaveDataFile)
        {
            //TODO:存檔資料的設定
        }
    }
}

