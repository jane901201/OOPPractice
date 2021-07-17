using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterAttr
{
    protected string attrName = "";
    protected int hp; //生命條
    protected int mp; //魔力條
    protected int phyAtk; //力量
    protected int phyDef;
    protected int magAtk; //魔力
    protected int magDef; //魔法抵抗
    protected int restorativePower; //恢復力
    protected float moveSpd = 1.0f;
    protected float atkSpd; //攻擊速度

   
    private IAttrStrategy attrStrategy = null;

    public void SetAttStrategy(IAttrStrategy attrStrategy)
    {
        this.attrStrategy = attrStrategy;
    }

    public virtual void InitAttr()
    {
        
    }

    public int Hp 
    {
        get { return hp; }
        set { hp = value; }
    }
    public int Mp { get => mp; set => mp = value; }
    public int PhyAtk { get => phyAtk; set => phyAtk = value; }
    public int PhyDef { get => phyDef; set => phyDef = value; }
    public int MagDef { get => magDef; set => magDef = value; }
    public int Mag { get => magAtk; set => magAtk = value; }
    public float Spd { get => moveSpd; set => moveSpd = value; }
    public int Res { get => magDef; set => magDef = value; }
    public int RestorativePower { get => restorativePower; set => restorativePower = value; }
    public float AtkSpd { get => atkSpd; set => atkSpd = value; }


}
