using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Originator //static?
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
    private string scenes; //�ثe������̭������

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
        //�N�U�ئs�ɸ�ƶǵ�Originator
    }
}
