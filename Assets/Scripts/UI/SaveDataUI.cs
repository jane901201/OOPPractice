using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unreal.BaseClass;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/SaveDataUI")]
    public class SaveDataUI : IUserInterface
    {
        private GameObject tmpSaveDataBtnObj;

        private Action m_GetLoadingUI;
        private Action m_GetDataCheckInfoUI;
        private Func<bool> m_GetIsCheck;

        private List<Button> m_SaveDataBtn;
        private List<Text> m_SaveDataNumText;
        private List<Text> m_ChapterText;
        private List<Text> m_TimeTexts;
        private List<Text> m_DifficultlyLevelTexts;

        Dictionary<Button, int> SaveDataNum = new Dictionary<Button, int>();
        private int m_ChooseNum = 0;

        public override void Initialize()
        {
            m_DelegateInitialize();
        }

        public void SetLoadingUI(Action loadingUI)
        {
            m_GetLoadingUI = loadingUI;
        }

        public void SetDataCheckInfoUI(Action dataCheckInfoUI)
        {
            m_GetDataCheckInfoUI = dataCheckInfoUI;
        }



        public void SetAllSaveDataState(Action<int> LoadSaveDataFile)
        {
            //Text tmpText = m_TimeTexts[0];
            int dataNum = 11;
            for(int i = 0; i < dataNum; i++)
            {
                GameObject tmpSaveData = UITool.FindUIGameObject("SaveData" + i);
                GameObject tmpSaveDataBtnObj = tmpSaveData.transform.GetChild(0).gameObject;
                Button tmpSaveDataBtn = tmpSaveDataBtnObj.GetComponent<Button>();
                SaveDataNum.Add(tmpSaveDataBtn, i);
                tmpSaveDataBtn.onClick.AddListener(
                    delegate()
                    {
                        GameObject tmp = tmpSaveDataBtn.GetComponentInParent<Transform>().gameObject;
                        if(SaveDataNum.ContainsKey(tmpSaveDataBtn)) //除了要有Btn還要有檔案還要獲得確認
                        {
                            m_ChooseNum = SaveDataNum[tmpSaveDataBtn];
                            Debug.Log(m_ChooseNum);
                            LoadSaveDataFile(m_ChooseNum);
                            //m_GetLoadingUI();
                        }
                    }
                    );

                SetSaveDataBtnChild();

               List<GameObject> tmpSaveDataBtnChild = new List<GameObject>();

                /*TODO:之後要想比較好的方法...
                 * 順序
                 * SaveDataNumText
                 * ChapterText
                 * PartText
                 * PlayerNameText
                 * TimeText
                 * DifficultlyText
                 */
                for (int j = 0; j < tmpSaveDataBtnObj.transform.childCount; j++)
                {
                    tmpSaveDataBtnChild.Add(tmpSaveDataBtnObj.transform.GetChild(j).gameObject);
                    //Debug.Log(tmpSaveDataBtn.transform.GetChild(j).gameObject);
                }

                Text tmpSaveDataNumText = tmpSaveDataBtnChild[0].GetComponent<Text>();
                tmpSaveDataNumText.text = "存檔 " + i;

            }
        }

        private void SetSaveDataBtnChild()
        {
               

        }
    }
}

