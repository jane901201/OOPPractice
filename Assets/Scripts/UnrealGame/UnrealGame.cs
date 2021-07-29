using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.UI;
using Unreal.Character;
using Unreal.Dialogue;
using Unreal.BaseClass;


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








