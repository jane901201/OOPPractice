using System.Collections.Generic;
/// <summary>
/// 資料的增減處理
/// </summary>
namespace Unreal.AssetResources
{
    public class Caretaker
    {

        private IResources m_Resources = null;
        private SaveDataFileDataBase m_SaveDataFileDataBase = null;

        private Dictionary<int, SaveDataFile> m_SaveDatas = new Dictionary<int, SaveDataFile>();

        public void SetResource(IResources resources)
        {
            m_Resources = resources;
        }

        public void SetSaveData()
        {
            m_SaveDataFileDataBase = m_Resources.LoadSaveDataFileDataBaseXML();

            m_SaveDatas = m_SaveDataFileDataBase.GetSaveDataFileDictionary();
        }

        public void AddSaveData(int number, SaveDataFile theSaveData)
        {
            if(m_SaveDatas.ContainsKey(number) == false)
            {
                m_SaveDatas.Add(number, theSaveData);
            } 
            else
            {
                m_SaveDatas[number] = theSaveData;
            }
        }

        public SaveDataFile GetSaveData(int number)
        {
            if(m_SaveDatas.ContainsKey(number) == false)
            {
                return null;
            }
            else
            {
                return m_SaveDatas[number];
            }
        }

        public SaveDataFileDataBase GetSaveDataFileDataBase()
        {
            return m_SaveDataFileDataBase;
        }

        public Dictionary<int ,SaveDataFile> GetSaveDatas()
        {
            return m_SaveDatas;
        }

    }

}

