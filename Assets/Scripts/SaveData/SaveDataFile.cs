using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  �x�s������
///  ���d��T
///  ��ܶi��
///  �C���ɶ�
///  ���ͽƼƸ�ƪ����O
/// </summary>
public class SaveDataFile
{
    private int hp; //�ͩR��
    private int mp; //�]�O��
    private int str; //�O�q
    private int def; //���m
    private int mag; //�]�O
    private int moveSpd; //���ʳt��
    private int atkSpd; //�����t��
    private int res; //�]�k���

    //private Item item; //�I�]

    private int conversation; //��ܶi��
    private string scenesName; //�ثe����

    public int Hp { get => hp; set => hp = value; }
    public int Mp { get => mp; set => mp = value; }
    public int Str { get => str; set => str = value; }
    public int Def { get => def; set => def = value; }
    public int Mag { get => mag; set => mag = value; }
    public int MoveSpd { get => moveSpd; set => moveSpd = value; }
    public int AtkSpd { get => atkSpd; set => atkSpd = value; }
    public int Res { get => res; set => res = value; }
    public int Conversation { get => conversation; set => conversation = value; }
    public string Scenes { get => scenesName; set => scenesName = value; }

    public SaveDataFile GetSaveData()
    {
        return this;
    }
    public void SetSaveData()
    {
        //�U�ظ�ƳB�z
    }
}
