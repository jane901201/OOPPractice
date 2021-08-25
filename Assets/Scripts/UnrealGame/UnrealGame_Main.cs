using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.Character;
using Unreal.Dialogue;
using Unreal.BaseClass;
using Unreal.AssetResources;
using Unreal.UI;

/// <summary>
/// 1.UI����
/// 2.��Өt�α���
/// 3.���P�t�Ψ�L���󪺪F��
/// </summary>


namespace Unreal
{
    public partial class UnrealGame
    {
        private CharacterSystem m_CharacterSystem = null;
        private DialogueSystem m_DialogueSystem = null;
        //TODO:private GameEventSystem m_GameEventSystem = null;
        private ProjectResources m_Resources = null;
        private static SceneController m_SceneController = null;
        private static SaveDataManager m_SaveDataManager = null;

        public void UnrealAwake()
        {
            m_SceneController = new SceneController();
            m_Resources = new ProjectResources();
            m_SaveDataManager = new SaveDataManager();
            
        }

        public void UnrealStart()
        {
            SetSaveDataManagerDelegateInitialize();
            SetMainMenuScene();
            m_SaveDataManager.Initialize();
        }

        public void UnrealUpdate()
        {

        }

        public void GameStart() //�̤@�}�l�n�C���C���ɭn��l���F��
        {
           

        }

        public void GameContinue() //�I�~��C���ɭn��l���F��
        {

        }

        public void Initinal()
        {
            m_CharacterSystem = new CharacterSystem();
        }


    }

}

