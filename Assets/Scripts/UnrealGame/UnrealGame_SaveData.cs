using System.Collections;
using UnityEngine;
using Unreal.AssetResources;
using Unreal.UI;
/// <summary>
/// 
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {
        public void SaveSceneName()
        {
            string name = m_SceneController.GetCurrectSceneName();
        }

        public void LoadSaveData(int num)
        {
            m_SaveDataManager.LoadSaveData(num);
        }

        public void SaveSaveData(int num, SaveDataFile saveDataFile)
        {
            m_SaveDataManager.SaveSaveDataToCaretaker(num, saveDataFile);
        }


        public void SaveSaveDataInXML()
        {
            m_Resources.SaveSaveDataFileDataBase(m_SaveDataManager.GetSaveDataFileDataBase());
        }
    }
}