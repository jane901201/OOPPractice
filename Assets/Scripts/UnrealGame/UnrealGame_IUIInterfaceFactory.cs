using System.Collections;
using UnityEngine;
using Unreal.UI;
/// <summary>
/// 暫時將IGameSystem的Delegate的宣告放在這裡
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {


        public SaveDataUI SetSaveDataUIDelegateInitialize(GameObject saveDataUIObj)
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
            m_SaveDataUI = saveDataUIObj.GetComponent<SaveDataUI>();
            m_SaveDataUI.m_DelegateInitialize = delegate ()
            {
                m_SaveDataUI.SetAllSaveDataState(LoadSaveData);
                m_SaveDataUI.SetLoadingUI(CreateDataCheckInfoUI);
            };

            return m_SaveDataUI;
        }
    }
}