using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��o�ثe��ƪ���T
/// </summary>

namespace Unreal.SaveData
{
    public class SaveDataManager
    {
        //�}��ƭ�
        private int hp; //�ͩR��
        private int mp; //�]�O��
        private int str; //�O�q
        private int def; //���m
        private int mag; //�]�O
        private int moveSpd; //���ʳt��
        private int atkSpd; //�����t��
        private int res; //�]�k���




        //private Item item; //�I�]

        //��������
        private int conversation; //��ܶi��
        private string m_SceneName; //�ثe������̭������


        public SaveDataFile CreateSaveData()
        {
            SaveDataFile newSaveData = new SaveDataFile();
            //TODO:SetSaveData��ƪ��B�z
            newSaveData.SetSaveData();
            return newSaveData;
        }

        public void SetSaveData(SaveDataFile data)
        {
            //�N�U�ئs�ɸ�ƶǵ�Originator
        }

        public void SetSceneName(string sceneName)
        {
            m_SceneName = sceneName;
        }
    }

}

