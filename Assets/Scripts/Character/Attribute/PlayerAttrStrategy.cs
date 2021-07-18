using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttrStrategy : IAttrStrategy
{

    public override int PhysicalDamage(int phyAtk, int phyDef)
    {
        return phyAtk - phyDef;
    }
    public override int MagicalDamage(int magAtk, int magDef)
    {
        return magAtk - magDef;
    }

    public override int Restorative(int restorative)
    {
        return restorative;
    }

    public override int MoveSpd(int moveSpd)
    {
        return moveSpd;
    }

    public override int AtkSpd(int atkSpd)
    {
        return atkSpd;
    }

    public override void InitAttr()
    {
        throw new System.NotImplementedException();
    }

    public override int TotalHp(ICharacter character)
    {
        int hp = 0;
        return hp;
    }
}
