using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.BaseClass;

public enum ENUM_GameEvent
{
    Null = 0,
    EnemyKilled = 1,
    PlayerKilled = 2,
    ConverationEventTrigger = 3,
    FightEventTrigger =4,
    NewStage = 5,
}
public class GameEventSystem : IGameSystem
{
    private Dictionary<ENUM_GameEvent, IGameEventSubject> m_GameEvents =
        new Dictionary<ENUM_GameEvent, IGameEventSubject>();

    public GameEventSystem()
    {
        
    }

    public void GameEventRelease()
    {
        m_GameEvents.Clear();
    }

    public void RegisterObserver(ENUM_GameEvent emGameEvent, IGameEventObserver observer)
    {
        IGameEventSubject subject = GetGameEventSubject(emGameEvent);
    }

    private IGameEventSubject GetGameEventSubject(ENUM_GameEvent emGameEvent)
    {
        if(m_GameEvents.ContainsKey(emGameEvent))
        {
            return m_GameEvents[emGameEvent];
        }
        IGameEventSubject pSubject = null;
        switch(emGameEvent)
        {
            case ENUM_GameEvent.EnemyKilled:
                pSubject = new EnemyKilledSubject();
                break;
            case ENUM_GameEvent.PlayerKilled:
                pSubject = new PlayerKilledSubject();
                break;
            case ENUM_GameEvent.FightEventTrigger:
                pSubject = new FightEventTriggerSubject();
                break;
            case ENUM_GameEvent.ConverationEventTrigger:
                pSubject = new ConverationEventTriggerSubject();
                break;
            case ENUM_GameEvent.NewStage:
                pSubject = new NewStageSubject();
                break;
            default:
                Debug.LogWarning("沒有指定[" + emGameEvent + "]的Subject類別");
                return null;

        }

        m_GameEvents.Add(emGameEvent, pSubject);
        return pSubject;
    }

    public void NotifySubject(ENUM_GameEvent emGameEvent, System.Object Param)
    {
        if(m_GameEvents.ContainsKey(emGameEvent) == false)
        {
            m_GameEvents[emGameEvent].SetParam(Param);
            return;
        }
    }

}
