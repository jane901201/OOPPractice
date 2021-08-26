using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.BaseClass;
/// <summary>
/// 獲得目前資料的資訊(從ProjectResoruces獲取)
/// 呼叫ProjectResources將資料設定為XML檔
/// 建設Caretaker
/// </summary>

namespace Unreal.AssetResources
{
    public class SaveDataManager : IGameSystem
    {
        private IResources m_Resources = null;
        private Caretaker m_Caretaker = null;
        private Role m_Role = null;
        private Story m_Story = null;
        private string m_SceneName = null;

        private Action m_GetSaveDataIsNotFoundAlert;
        private Action m_GetWantToLoadDavaAlert;

        public override void Initialize()
        {
            m_Caretaker = new Caretaker();
            m_DelegateInitialize();
            LoadSaveDataFileInXML();

        }




        public void LoadSaveData(int num)
        {
            SaveDataFile tmpSaveDataFile = m_Caretaker.GetSaveData(num);
            if(tmpSaveDataFile != null)
            {            
                //TODO:將檔案回復之類的
            }
            else
            {
                //TODO:先呼叫確認UI，告訴玩家此沒檔案
            }

            Debug.Log(tmpSaveDataFile);

        }

        public void SaveSaveDataToCaretaker(int num, SaveDataFile saveDataFile)
        {
            m_Caretaker.AddSaveData(num, saveDataFile);
        }

        public void LoadSaveDataFileInXML()
        {
            m_Caretaker.SetResource(m_Resources);
            m_Caretaker.SetSaveData();
        }

        public SaveDataFileDataBase GetSaveDataFileDataBase()
        {
            return m_Caretaker.GetSaveDataFileDataBase();
        }

        public SaveDataFile CreateSaveData()
        {
            SaveDataFile newSaveData = new SaveDataFile();
            //TODO:SetSaveData資料的處理
            newSaveData.SetSaveData();
            return newSaveData;
        }

        public void SetResources(IResources resources)
        {
            m_Resources = resources;
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

        public Role GetRole()
        {
            return m_Role;
        }

        public Story GetStory()
        {
            return m_Story;
        }


    }

}

