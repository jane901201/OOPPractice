using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.Character;
using Unreal.Dialogue;
using Unreal.BaseClass;
using Unreal.AssetResources;

/// <summary>
/// 1.UI控制
/// 2.整個系統控制
/// 3.給與系統其他物件的東西
/// </summary>


namespace Unreal
{
    public partial class UnrealGame
    {
        private CharacterSystem m_CharacterSystem = null;
        private DialogueSystem m_DialogueSystem = null;
        private GameEventSystem m_GameEventSystem = null;
        private ProjectResources m_Resources = null;
        private static SceneController m_SceneController = null;
        private static SaveDataManager m_SaveDataManager = null;
        private static Caretaker m_Caretaker = null;

        private ConverationData m_ConverationData = null;

        public void UnrealAwake()
        {
            m_SceneController = new SceneController();
            m_Resources = new ProjectResources();
            m_SaveDataManager = new SaveDataManager();
            //TODO:XML讀取

        }

        public void GameStartInitinal() //最一開始要遊玩遊戲時要初始的東西
        {
           

        }

        public void GameContinueInitinal() //點繼續遊戲時要初始的東西
        {

        }

        public void Initinal()
        {
            m_CharacterSystem = new CharacterSystem();
        }


    }

}

