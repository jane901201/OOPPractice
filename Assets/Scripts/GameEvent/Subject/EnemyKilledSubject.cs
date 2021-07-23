using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilledSubject : IGameEventSubject
{
    private int m_KilledCount = 0;
    private IEnemy m_Enemy = null;

    public EnemyKilledSubject()
    {

    }

    public IEnemy GetEnemy()
    {
        return m_Enemy;
    }


}
