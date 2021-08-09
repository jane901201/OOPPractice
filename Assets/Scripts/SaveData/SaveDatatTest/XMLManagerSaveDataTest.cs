using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
public class XMLManagerSaveDataTest : MonoBehaviour
{
    public static XMLManagerSaveDataTest ins;

    private void Awake()
    {
        ins = this;
    }

    public ItemDataBase itemDB;
    public void SaveItem()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/XML/item_data.xml", FileMode.Create); //會有override的風險，之後要改
        serializer.Serialize(stream, itemDB);
        stream.Close();
    }

    public void LoadItem()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/XML/item_data.xml", FileMode.Open); //會有override的風險，之後要改
        itemDB = serializer.Deserialize(stream) as ItemDataBase;
        stream.Close();
    }
}

[System.Serializable]
public class ItemEntry
{
    public string itmeName;
    public Material material;
    public int value;
}

[System.Serializable]
public class ItemDataBase
{
    [XmlArray("CombatEquipment")]
    public List<ItemEntry> list = new List<ItemEntry>();

}

public enum Material
{
    Wood,
    Copper
}