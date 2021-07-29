using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.UI;
using Unreal.Character;
using Unreal.Dialogue;
using Unreal.BaseClass;


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
        private SceneStateController m_SceneController = null;

        private GameObject m_DialogueUI = null;
        private GameObject m_SaveDataUI = null;
        private GameObject m_GamePauseUI = null;

        private ConverationData m_ConverationData = null;


        public void GameStartInitinal()
        {

        }

        public void Initinal()
        {
            m_Resources = new ProjectResources();
            m_CharacterSystem = new CharacterSystem();
        }


    }
}








