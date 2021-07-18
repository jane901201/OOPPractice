using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplay : MonoBehaviour
{
    public ItemBlock blockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Display();
    }

    public void Display()
    {
        foreach(ItemEntry item in XMLManager.ins.itemDB.list)
        {
            ItemBlock newBlock = Instantiate(blockPrefab) as ItemBlock;
            newBlock.transform.SetParent(transform, false);
            newBlock.Display(item);
        }   
    }
}
