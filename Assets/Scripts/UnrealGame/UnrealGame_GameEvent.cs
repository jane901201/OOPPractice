using System.Collections;
using UnityEngine;

namespace Unreal
{
    public partial class UnrealGame
    {
        public void CharacterSystemGameEvent()
        {
            m_CharacterSystem.RegisterGameEvent(() => { RegisterGameEvent(ENUM_GameEvent.EnemyKilled); });
            m_CharacterSystem.RegisterGameEvent(() => { RegisterGameEvent(ENUM_GameEvent.PlayerKilled); });
        }

        public void RegisterGameEvent(ENUM_GameEvent emGameEvent)
        {
            //TODO:做完CharacterSystem的GameEvent
            Debug.Log("RegisterGame");
        }
    }
}