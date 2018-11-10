using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    void Start()
    {
        var inventorySize = 9;
        var inventoryItems = 4;

        for (var i = 0; i < inventorySize; i++)
        {
            var slot = (GameObject) Instantiate(Resources.Load("Prefabs/Slot"));
            slot.transform.parent = transform.parent.Find("Slots").transform;
        }
        
        for (var i = 0; i < inventoryItems; i++)
        {
            var item = (GameObject) Instantiate(Resources.Load("Prefabs/Item"));
            item.transform.parent = transform.parent.Find("Slots").GetChild(i);
        }
    }
}