using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ƪ��W��B�z
/// </summary>
namespace Unreal.AssetResources
{
    public class Caretaker
    {

        private IResources m_Resources;
        private SaveDataFileDataBase m_SaveDataFileDataBase;

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
    }

}
