using System.Collections;
using UnityEngine;
using Unreal.AssetResources;
/// <summary>
/// TODO:SaveData的Initial先在這裡宣告，之後會移到Factory那邊
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {
        public void SaveDataUIInitialize()
        {

            /*TODO:之後要想比較好的方法...
             * 順序
             * SaveDataNumText
             * ChapterText
             * PartText
             * PlayerNameText
             * TimeText
             * DifficultlyText
             */


        }

        public void SaveSceneName()
        {
            string name = m_SceneController.GetCurrectSceneName();
            m_SaveDataManager.SetSceneName(name);
        }

        public void LoadSaveData(int num)
        {
            m_SaveDataManager.LoadSaveData(num);
        }

        public void SaveSaveData(int num, SaveDataFile saveDataFile)
        {
            m_Caretaker.AddSaveData(num, saveDataFile);
            //TODO:應該中間要用SaveDataManager
        }

        public void LoadSaveDataFileInXML()
        {
            m_Caretaker.SetResource(m_Resources);
            m_Caretaker.SetSaveData();
        }


        public void SaveSaveDataInXML()
        {
            m_Resources.SaveSaveDataFileDataBase(m_Caretaker.GetSaveDataFileDataBase());
        }
    }
}