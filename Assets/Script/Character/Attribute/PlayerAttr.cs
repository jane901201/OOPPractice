using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttr
{
    private int hp; //�ͩR��
    private int mp; //�]�O��
    private int str; //�O�q
    private int def; //���m
    private int mag; //�]�O
    private int moveSpd; //���ʳt��
    private int atkSpd; //�����t��
    private int res; //�]�k���

    public int Hp { get => hp; set => hp = value; }
    public int Mp { get => mp; set => mp = value; }
    public int Str { get => str; set => str = value; }
    public int Def { get => def; set => def = value; }
    public int Mag { get => mag; set => mag = value; }
    public int Spd { get => moveSpd; set => moveSpd = value; }
    public int Res { get => res; set => res = value; }

    public static int PhysicalDamage(int str, int def)
    {
        return str - def;
    }

    public static int MagicalDamage(int mag, int def)
    {
        return mag - def;
    }
}
