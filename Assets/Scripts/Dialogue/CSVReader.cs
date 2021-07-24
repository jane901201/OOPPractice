using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVReader
{
    [SerializeField]
    private TextAsset textAssetData;

    public SentenceList converationList = new SentenceList();


    public void SetConveration(ChapterList chapterList)
    {

    }

    public void ReadCSV()
    {
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        Debug.Log(textAssetData.ToString());
        Debug.Log(textAssetData.name);
        int tableSize = data.Length / 2 - 1;
        converationList.Sentence = new Sentence[tableSize];


        for(int i = 0; i < tableSize; i++)
        {
            converationList.Sentence[i] = new Sentence();
            converationList.Sentence[i].Name = data[2 * (i + 1)];
            Debug.Log(converationList.Sentence[i].Name);
            converationList.Sentence[i].AvatarString = data[2 * (i + 1)];
            Debug.Log(converationList.Sentence[i].AvatarString);
        }



    }


}
