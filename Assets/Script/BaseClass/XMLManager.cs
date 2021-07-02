using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
public class XMLManager : MonoBehaviour
{
    public CharacterDataBase characterDB;
    public void SaveCharacter()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CharacterDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/XML/character.xml", FileMode.Create); //�|��override�����I�A����n��
        serializer.Serialize(stream, characterDB);
        stream.Close();
    }

    public void LoadCharacter()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CharacterDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/XML/character.xml", FileMode.Open); //�|��override�����I�A����n��
        characterDB = serializer.Deserialize(stream) as CharacterDataBase;
        stream.Close();
    }
}

public class CharacterDataBase {
    [XmlArray("JustTest")]
    string a = "test";
}
