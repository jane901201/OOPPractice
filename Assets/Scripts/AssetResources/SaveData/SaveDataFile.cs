using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  儲存角色資料
///  關卡資訊
///  對話進度
///  遊玩時間
///  產生複數資料的類別
/// </summary>

namespace Unreal.AssetResources
{
    public class SaveDataFile
    {

        private Role m_Role;
        private Story m_Story;


        public SaveDataFile GetSaveData()
        {
            return this;
        }
        public void SetSaveData()
        {
            //各種資料處理
        }

        public void SetRole(Role role)
        {
            m_Role = role;
        }


        public Role GetRole()
        {
            return m_Role;
        }

        public void SetStory(Story story)
        {
            m_Story = story;
        }

        public Story GetStory()
        {
            return m_Story;
        }
    }
}


