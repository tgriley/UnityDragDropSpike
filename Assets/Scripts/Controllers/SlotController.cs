using System;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Controllers
{
    public class SlotController : MonoBehaviour
    {
        [NonSerialized]
        public List<ItemTypes> AllowedItemsTypes = new List<ItemTypes>();
    }
}