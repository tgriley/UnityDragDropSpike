using System;
using Factories;
using Models;
using Persistence;
using UnityEngine;

namespace Controllers
{
    public class InvInfController : MonoBehaviour
    {
        private readonly SaveStateRepository _saveStateRepository = new SaveStateRepository();
        
        public GameObject Infrastructure;
        public GameObject Inventory;

        public void SaveState()
        {
            var saveState = new SaveState();

            var infrastructureController = Infrastructure.GetComponent<InfrastructureController>();

            foreach (var item in infrastructureController.InfrastructureModel.Items)
            {
                var saveStateItem = new SaveStateItem(){ Id = ItemFactory.GetSaveStateItemId(item)};
                saveState.Infrastructure.Add(saveStateItem);
            }
            
            var inventoryController = Inventory.GetComponent<InventoryController>();

            foreach (var item in inventoryController.InventoryModel.Items)
            {
                var saveStateItem = new SaveStateItem(){ Id = ItemFactory.GetSaveStateItemId(item)};
                saveState.Inventory.Add(saveStateItem);
            }
            
            _saveStateRepository.Save(saveState);
        }
    }
}