using System.Collections;
using UnityEngine;

namespace Unreal
{
    public partial class UnrealGame
    {
        public void SaveSceneName()
        {
            string name = m_SceneController.GetCurrectSceneName();
            m_SaveDataManager.SetSceneName(name);
        }

        public void LoadSaveData()
        {

        }

        public void SaveSaveData()
        {

        }

        public void LoadSaveDataFileInXML()
        {
            m_Resources.LoadSaveDataFileDataBaseXML
        }


        public void SaveSaveDataInXML()
        {

        }
    }
}