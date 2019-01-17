using Enums;
using Models;
using UnityEngine;

namespace Controllers
{
    public class InventoryController : MonoBehaviour
    {
        private void Start()
        {
            const int inventorySize = 9;

            for (var i = 0; i < inventorySize; i++)
            {
                var slot = (GameObject) Instantiate(Resources.Load("Prefabs/Slot"), transform.parent.Find("Slots").transform, true);
                slot.GetComponent<SlotController>().AllowedItemsTypes.AddRange(new []{ItemTypes.Type1, ItemTypes.Type2});
            }

            var parent = transform.parent;

            var items = new Inventory().Items;
            for (var i = 0; i < items.Count; i++)
            {
                var newItem = (GameObject) Instantiate(Resources.Load("Prefabs/Item"), parent.Find("Slots").GetChild(i), true);
                newItem.GetComponent<ItemController>().ItemModel = items[i];
            }
        }
    }
}