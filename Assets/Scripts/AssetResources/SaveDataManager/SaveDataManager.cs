using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.BaseClass;
/// <summary>
/// ��o�ثe��ƪ���T(�qProjectResoruces���)
/// �I�sProjectResources�N��Ƴ]�w��XML��
/// �س]Caretaker
/// </summary>

namespace Unreal.AssetResources
{
    public class SaveDataManager : IGameSystem
    {
        private Caretaker m_Caretaker = null;
        private Role m_Role = null;
        private Story m_Story = null;
        private string m_SceneName = null;

        public override void Initialize()
        {
            m_Caretaker = new Caretaker();
        }



        public void LoadSaveData(int num)
        {
            SaveDataFile tmpSaveDataFile = m_Caretaker.GetSaveData(num);
        }

        public void SaveSaveDataToCaretaker(int num, SaveDataFile saveDataFile)
        {
            m_Caretaker.AddSaveData(num, saveDataFile);
        }

        public SaveDataFile CreateSaveData()
        {
            SaveDataFile newSaveData = new SaveDataFile();
            //TODO:SetSaveData��ƪ��B�z
            newSaveData.SetSaveData();
            return newSaveData;
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

