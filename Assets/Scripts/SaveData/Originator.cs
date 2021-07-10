using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Originator //static?
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
    private string scenes; //目前視窗跟裡面的資料

    private CharacterOriginator characterOriginator = null;
    private ItemOriginator itemOriginator = null;
    private SceneOriginator sceneOriginator = null;

    public CharacterOriginator CharacterOriginator { get => characterOriginator; set => characterOriginator = value; }
    public ItemOriginator ItemOriginator { get => itemOriginator; set => itemOriginator = value; }
    public SceneOriginator SceneOriginator { get => sceneOriginator; set => sceneOriginator = value; }

    public SaveData CreateSaveData()
    {
        SaveData newSaveData = new SaveData();
        newSaveData.SetSaveData(characterOriginator, itemOriginator, sceneOriginator);
        return newSaveData;
    }

    public void SetSaveData(SaveData data)
    {
        //將各種存檔資料傳給Originator
    }
}
