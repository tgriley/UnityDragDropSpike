using UnityEngine;

public class InventoryController : MonoBehaviour
{
    void Start()
    {
        var inventorySize = 9;

        for (var i = 0; i < inventorySize; i++)
        {
            var slot = (GameObject) Instantiate(Resources.Load("Prefabs/Slot"));
            slot.transform.parent = transform.parent.Find("Slots").transform;
            slot.GetComponent<SlotController>().AllowedItemsTypes.AddRange(new []{ItemTypes.Type1, ItemTypes.Type2});

        }

        var item1 = (GameObject) Instantiate(Resources.Load("Prefabs/Item"));
        item1.GetComponent<ItemController>().ItemModel = new Item1();
        item1.transform.parent = transform.parent.Find("Slots").GetChild(0);

        var item2 = (GameObject) Instantiate(Resources.Load("Prefabs/Item"));
        item2.GetComponent<ItemController>().ItemModel = new Item1();
        item2.transform.parent = transform.parent.Find("Slots").GetChild(1);

        var item3 = (GameObject) Instantiate(Resources.Load("Prefabs/Item"));
        item3.GetComponent<ItemController>().ItemModel = new Item2();
        item3.transform.parent = transform.parent.Find("Slots").GetChild(2);

        var item4 = (GameObject) Instantiate(Resources.Load("Prefabs/Item"));
        item4.GetComponent<ItemController>().ItemModel = new Item2();
        item4.transform.parent = transform.parent.Find("Slots").GetChild(3);
    }
}