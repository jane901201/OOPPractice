using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 獲得目前資料的資訊
/// </summary>

namespace Unreal.SaveData
{
    public class SaveDataManager
    {
        //腳色數值
        private int hp; //生命條
        private int mp; //魔力條
        private int str; //力量
        private int def; //防禦
        private int mag; //魔力
        private int moveSpd; //移動速度
        private int atkSpd; //攻擊速度
        private int res; //魔法抵抗




        //private Item item; //背包

        //視窗相關
        private int conversation; //對話進度
        private string m_SceneName; //目前視窗跟裡面的資料


        public SaveDataFile CreateSaveData()
        {
            SaveDataFile newSaveData = new SaveDataFile();
            //TODO:SetSaveData資料的處理
            newSaveData.SetSaveData();
            return newSaveData;
        }

        public void SetSaveData(SaveDataFile data)
        {
            //將各種存檔資料傳給Originator
        }

        public void SetSceneName(string sceneName)
        {
            m_SceneName = sceneName;
        }
    }

}

