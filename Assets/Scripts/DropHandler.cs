using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        var droppedItemType = eventData.pointerDrag.GetComponent<ItemController>().ItemModel.ItemType;
        if (gameObject.GetComponent<SlotController>().AllowedItemsTypes.Contains(droppedItemType))
        {
            eventData.pointerDrag.GetComponent<DragHandler>().TargetSlot = gameObject;
        }
    }
}