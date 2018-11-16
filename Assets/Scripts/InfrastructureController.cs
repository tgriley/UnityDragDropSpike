using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfrastructureController : MonoBehaviour {

	void Start ()
	{
		var infrastructureSize = 9;

		for (var i = 0; i < infrastructureSize; i++)
		{
			var slot = (GameObject)Instantiate(Resources.Load("Prefabs/Slot"));
			slot.transform.parent = transform.parent.Find("Slots").transform;
			slot.GetComponent<SlotController>().AllowedItemsTypes.Add(ItemTypes.Type1);
		}
	}
}
