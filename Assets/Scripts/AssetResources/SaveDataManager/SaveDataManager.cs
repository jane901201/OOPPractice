using System;
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
        private Scene m_Scene = null;

        private Action m_ShowDataCheckInfoUI;
        private Action m_HideDataCheckInfoUI;
        private Action m_GetSaveDataIsNotFoundAlert;
        private Action m_GetWantToLoadDavaAlert;
        private Func<bool> m_GetIsCheck;

        public override void Initialize()
        {
            m_Caretaker = new Caretaker();
            m_DelegateInitialize();
            LoadSaveDataFileInXML();

        }
        
        public override void Update()
        {
            //TODO:�p�G�F������A�N�سy����
        }



        public void SetSaveDataIsNotFoundAlert(Action alert)
        {
            m_GetSaveDataIsNotFoundAlert = alert;
        }

        public void SetWantToLoadDavaAlert(Action alert)
        {
            m_GetWantToLoadDavaAlert = alert;
        }

        public void SetShowDataCheckInfoUI(Action action)
        {
            m_ShowDataCheckInfoUI = action;
        }

        public void SetHideDataCheckInfoUI(Action action)
        {
            m_HideDataCheckInfoUI = action;
        }

        public void SetIsCheck(Func<bool> func)
        {
            m_GetIsCheck = func;
        }

        public void LoadSaveData(int num)
        {
            m_ShowDataCheckInfoUI();
            if(m_Caretaker.GetSaveData(num) != null)
            {
                //TODO:�N�ɮצ^�_������
                SaveDataFile tmpSaveDataFile = m_Caretaker.GetSaveData(num);
                m_GetWantToLoadDavaAlert();
            }
            else
            {
                
                m_GetSaveDataIsNotFoundAlert();
            }
        }

        public void StartGame()
        {
            //TODO:�]�w�̤@�}�l�C���ɡA�C�Ӫ��󪺼ƾ�
            m_Scene.SceneName = "";
            m_Story.Chapter = 0;
            m_Story.Conversation = 0;
            //TODO:m_Role�]�w
        }

        public void Recover()
        {
            //TODO:�^�_���e��������ƾ�
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

        public void SetScene(Scene scene)
        {
            m_Scene = scene;
        }


        public Role GetRole()
        {
            return m_Role;
        }

        public Story GetStory()
        {
            return m_Story;
        }

        public Scene GetScene()
        {
            return m_Scene;
        }
    }

}

