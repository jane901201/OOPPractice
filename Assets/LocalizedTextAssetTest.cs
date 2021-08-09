using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using Unreal.Dialogue;
using Unreal.UI;
/// <summary>
/// �]��UnitTest���䴩SetReference�A�ҥH�u�n�����b�o�̴��դF
/// </summary>
public class LocalizedTextAssetTest : MonoBehaviour
{

    public LocalizedTextAsset localizedTextAsset;
    private DialogueSystem m_DialogueSystem;
    private DialogueUI m_DialogueUI;
    private TextAsset textAsset;

    private void Awake()
    {
        m_DialogueSystem = new DialogueSystem();
        //TODO:�p�G�ݭn�o�̡A����ɻݭn�[SetStoryTextAsset
        m_DialogueSystem.Initialize();
    }

    // Start is called before the first frame update
    void Start()
    {
        //testEqual();
        //SplitSentence_Player();
        //testSplit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SplitSentence_Player()
    {
        string sentence = "Player:fjieofjoief";
    
        m_DialogueSystem.SplitSentenceAndSetSentenceandName(sentence);

       


    }

    public void testEqual()
    {
        string test1 =  ":";
        char test2 = ':';

        Debug.Log(test1.Contains(test2));
    }

    public void testSplit()
    {
        string sentence = "Player:fjieofjoief";
        string m_TmpName = null;
        string m_TmpSentence = null;

        string[] data = sentence.Split(":"[0]);
        Debug.Log(data);
        m_TmpName = data[0];
        Debug.Log(m_TmpName);
        m_TmpSentence =  data[1];
        Debug.Log(m_TmpSentence);
    }
}
