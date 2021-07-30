using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        private SceneController m_SceneController = null;



        private ConverationData m_ConverationData = null;

        public void UnrealAwake() //�C���Q���}�ɭn��l���F��
        {
            m_SceneController = new SceneController();
            m_Resources = new ProjectResources();

        }

        public void GameStartInitinal() //�̤@�}�l�n�C���C���ɭn��l���F��
        {
           

        }

        public void GameContinueInitinal() //�I�~��C���ɭn��l���F��
        {

        }

        public void Initinal()
        {
            m_Resources = new ProjectResources();
            m_CharacterSystem = new CharacterSystem();
        }


    }

}

