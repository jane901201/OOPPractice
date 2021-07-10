using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caretaker
{
    Dictionary<int, SaveData> saveDatas = new Dictionary<int, SaveData>();

    public void AddSaveData(int number, SaveData theSaveData)
    {
        if(saveDatas.ContainsKey(number) == false)
        {
            saveDatas.Add(number, theSaveData);
        } 
        else
        {
            saveDatas[number] = theSaveData;
        }
    }

    public SaveData GetSaveData(int number)
    {
        if(saveDatas.ContainsKey(number) == false)
        {
            return null;
        }
        else
        {
            return saveDatas[number];
        }
    }
}
