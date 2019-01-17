using Enums;
using UnityEngine;

namespace Controllers
{
	public class InfrastructureController : MonoBehaviour 
	{
		private void Start ()
		{
			const int infrastructureSize = 9;

			for (var i = 0; i < infrastructureSize; i++)
			{
				var slot = (GameObject)Instantiate(Resources.Load("Prefabs/Slot"), transform.parent.Find("Slots").transform, true);
				slot.GetComponent<SlotController>().AllowedItemsTypes.Add(ItemTypes.Type1);
			}
		}
	}
}
