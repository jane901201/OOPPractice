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
        private IResources m_Resources = null;
        private Caretaker m_Caretaker = null;
        private Role m_Role = null;
        private Story m_Story = null;
        private string m_SceneName = null;

        public override void Initialize()
        {
            m_Caretaker = new Caretaker();
            m_DelegateInitialize();
            LoadSaveDataFileInXML();

        }



        public void LoadSaveData(int num)
        {
            SaveDataFile tmpSaveDataFile = m_Caretaker.GetSaveData(num);
            Debug.Log(tmpSaveDataFile);

            //TODO:�N�ɮצ^�_������
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
            //TODO:SetSaveData��ƪ��B�z
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

