using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  �x�s������
///  ���d��T
///  ��ܶi��
///  �C���ɶ�
///  ���ͽƼƸ�ƪ����O
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
            //�U�ظ�ƳB�z
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


