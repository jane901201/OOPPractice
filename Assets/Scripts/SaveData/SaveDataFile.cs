using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  儲存角色資料
///  關卡資訊
///  對話進度
///  遊玩時間
///  產生複數資料的類別
/// </summary>
public class SaveDataFile
{
    private int hp; //生命條
    private int mp; //魔力條
    private int str; //力量
    private int def; //防禦
    private int mag; //魔力
    private int moveSpd; //移動速度
    private int atkSpd; //攻擊速度
    private int res; //魔法抵抗

    //private Item item; //背包

    private int conversation; //對話進度
    private string scenesName; //目前視窗

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
        //各種資料處理
    }
}
