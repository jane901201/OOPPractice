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
        Dictionary<Button, int> SaveDataNum = new Dictionary<Button, int>();
        Action tmpAction;//TODO:�ȥΨӴ���
        private int m_ChooseNum = 0;

        private void Start() //TODO:�ȥΨӴ���
        {
            SetAllSaveDataState(tmpAction);
        }

        public void SetAllSaveDataState(Action SaveDataFile)
        {
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
                        if(SaveDataNum.ContainsKey(tmpSaveDataBtn))
                        {
                            m_ChooseNum = SaveDataNum[tmpSaveDataBtn];
                            Debug.Log(m_ChooseNum);
                            //TODO:SaveDataFile();
                        }
                    }
                    );

                List<GameObject> tmpSaveDataBtnChild = new List<GameObject>();

                /*TODO:����n�Q����n����k...
                 * ����
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
                tmpSaveDataNumText.text = "�s�� " + i;


            }
        }
    }
}

