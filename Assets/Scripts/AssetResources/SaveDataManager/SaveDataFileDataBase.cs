using System.Collections.Generic;

namespace Unreal.AssetResources
{
    public class SaveDataFileDataBase
    {
        private Dictionary<int, SaveDataFile> m_SaveDataFileDictionary = new Dictionary<int, SaveDataFile>();

        public Dictionary<int, SaveDataFile> GetSaveDataFileDictionary()
        {
            return m_SaveDataFileDictionary;
        }
    }
}