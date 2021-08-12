using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 獲得目前資料的資訊(從ProjectResoruces獲取)
/// 呼叫ProjectResources將資料設定為XML檔
/// </summary>

namespace Unreal.AssetResources
{
    public class SaveDataManager
    {
        private Role m_Role = null;
        private Story m_Story = null;
        private string m_SceneName = null;
      

        public SaveDataFile CreateSaveData()
        {
            SaveDataFile newSaveData = new SaveDataFile();
            //TODO:SetSaveData資料的處理
            newSaveData.SetSaveData();
            return newSaveData;
        }

        public void SetSaveData(SaveDataFile data)
        {
            //TODO:將各種存檔資料傳給Originator
        }

        public void SetRole(Role role)
        {
            m_Role = role;
        }

        public void SetStory(Story story)
        {
            m_Story = story;
        }

        public void SetSceneName(string sceneName)
        {
            m_SceneName = sceneName;
        }
    }

}

