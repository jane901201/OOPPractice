using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.UI;
using Unreal.Character;
using Unreal.Dialogue;
public class UnrealGame
{

    private CharacterSystem m_CharacterSystem = null;
    private DialogueSystem m_DialogueSystem = null;
    private GameEventSystem gameEventSystem = null;


    private CharacterAttrUI m_characterAttrUI;
    private DialogueUI m_dialogueUI;
    private GamePauseUI m_GamePauseUI;

    public void Initinal()
    {
        m_CharacterSystem = new CharacterSystem();
        //m_CharacterSystem.SetinitializeDeleagte(() => { RegisterGameEvent(ENUM_GameEvent.EnemyKilled); });
        //m_CharacterSystem.SetinitializeDeleagte(() => { RegisterGameEvent(ENUM_GameEvent.PlayerKilled); });
        m_DialogueSystem = new DialogueSystem();
    }


    public void RegisterGameEvent(ENUM_GameEvent emGameEvent)
    {
        Debug.Log("RegisterGame");
    }


}





