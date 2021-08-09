using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caretaker
{
    Dictionary<int, SaveDataFile> saveDatas = new Dictionary<int, SaveDataFile>();

    public void AddSaveData(int number, SaveDataFile theSaveData)
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

    public SaveDataFile GetSaveData(int number)
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
