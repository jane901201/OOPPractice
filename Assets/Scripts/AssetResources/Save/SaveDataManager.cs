using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��o�ثe��ƪ���T(�qProjectResoruces���)
/// �I�sProjectResources�N��Ƴ]�w��XML��
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
            //TODO:SetSaveData��ƪ��B�z
            newSaveData.SetSaveData();
            return newSaveData;
        }

        public void SetSaveData(SaveDataFile data)
        {
            //TODO:�N�U�ئs�ɸ�ƶǵ�Originator
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

