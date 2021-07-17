using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAttrStrategy
{
    public abstract int PhysicalDamage(int phyAtk, int phyDef);
    public abstract int MagicalDamage(int magAtk, int magDef);
    public abstract int Restorative(int restorative);
    public abstract int MoveSpd(int moveSpd);
    public abstract int AtkSpd(int atkSpd);
    public abstract void InitAttr();
}
 
