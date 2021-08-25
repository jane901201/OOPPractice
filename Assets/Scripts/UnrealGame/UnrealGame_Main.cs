using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.Character;
using Unreal.Dialogue;
using Unreal.BaseClass;
using Unreal.AssetResources;
using Unreal.UI;

/// <summary>
/// 1.UI北
/// 2.俱╰参北
/// 3.倒籔╰参ㄤン狥﹁
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

        public void GameStart() //程秨﹍璶笴笴栏璶﹍狥﹁
        {
           

        }

        public void GameContinue() //翴膥尿笴栏璶﹍狥﹁
        {

        }

        public void Initinal()
        {
            m_CharacterSystem = new CharacterSystem();
        }


    }

}

