﻿using System.Collections.Generic;
using Enums;
using Factories;
using Models;
using Persistence;
using UnityEngine;

namespace Controllers
{
    public class InfrastructureController : MonoBehaviour
    {
        public readonly Infrastructure InfrastructureModel = new Infrastructure();

        private void Start()
        {
            CreateGrid(9, new List<ItemTypes> {ItemTypes.Type1});
            LoadInventory();
            Populate();
        }

        private void CreateGrid(int inventorySize, IList<ItemTypes> allowedItemTypes)
        {
            for (var i = 0; i < inventorySize; i++)
            {
                var original = Resources.Load("Prefabs/Slot");
                var parent = transform.parent.Find("Slots").transform;
                var instantiateInWorldSpace = true;    
                var slot = (GameObject) Instantiate(original, parent, instantiateInWorldSpace);
                slot.GetComponent<SlotController>().AllowedItemsTypes.AddRange(allowedItemTypes);
            }
        }

        private void Populate()
        {
            var parent = transform.parent;

            for (var i = 0; i < InfrastructureModel.Items.Count; i++)
            {
                var original = Resources.Load("Prefabs/Item");
                var child = parent.Find("Slots").GetChild(i);
                var instantiateInWorldSpace = true;
                var newItem = (GameObject) Instantiate(original, child, instantiateInWorldSpace);
                newItem.GetComponent<ItemController>().ItemModel = InfrastructureModel.Items[i];
            }
        }

        private void LoadInventory()
        {
            var saveStateRepository = new SaveStateRepository();
            var saveState = saveStateRepository.Read();

            foreach (var saveStateItem in saveState.Infrastructure)
            {
                InfrastructureModel.Items.Add(ItemFactory.GetItem(saveStateItem.Id));
            }
        }
    }
}