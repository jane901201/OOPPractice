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
        FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/XML/character.xml", FileMode.Create); //會有override的風險，之後要改
        serializer.Serialize(stream, characterDB);
        stream.Close();
    }

    public void LoadCharacter()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CharacterDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/XML/character.xml", FileMode.Open); //會有override的風險，之後要改
        characterDB = serializer.Deserialize(stream) as CharacterDataBase;
        stream.Close();
    }
}

public class CharacterDataBase {
    [XmlArray("JustTest")]
    string a = "test";
}
