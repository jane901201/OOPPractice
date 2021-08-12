using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.Character;
using Unreal.Dialogue;
using Unreal.BaseClass;
using Unreal.AssetResources;

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
        private GameEventSystem m_GameEventSystem = null;
        private ProjectResources m_Resources = null;
        private static SceneController m_SceneController = null;
        private static SaveDataManager m_SaveDataManager = null;


        private ConverationData m_ConverationData = null;

        public void UnrealAwake()
        {
            m_SceneController = new SceneController();
            m_Resources = new ProjectResources();
            m_SaveDataManager = new SaveDataManager();

        }

        public void GameStartInitinal() //程秨﹍璶笴笴栏璶﹍狥﹁
        {
           

        }

        public void GameContinueInitinal() //翴膥尿笴栏璶﹍狥﹁
        {

        }

        public void Initinal()
        {
            m_Resources = new ProjectResources();
            m_CharacterSystem = new CharacterSystem();
        }


    }

}

