using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttr
{
    private int hp; //生命條
    private int mp; //魔力條
    private int str; //力量
    private int def; //防禦
    private int mag; //魔力
    private int spd; //速度

    public int Hp { get => hp; set => hp = value; }
    public int Mp { get => mp; set => mp = value; }
    public int Str { get => str; set => str = value; }
    public int Def { get => def; set => def = value; }
    public int Mag { get => mag; set => mag = value; }
    public int Spd { get => spd; set => spd = value; }

    public static int Damage(int str, int def)
    {
        return str - def;
    }
}
