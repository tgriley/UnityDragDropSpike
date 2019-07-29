using System.Collections.Generic;
using Factories;
using Persistence;

namespace Models
{
    public class Inventory
    {
        private SaveStateRepository _saveStateRepository;
        public IList<IItem> Items;

        public Inventory()
        {
            Items = new List<IItem>();
            
            _saveStateRepository = new SaveStateRepository();

            var saveState = _saveStateRepository.Read();

            foreach (var saveStateItem in saveState.Inventory)
            {
                Items.Add(ItemFactory.GetItem(saveStateItem.Id));
            }
        }
    }
}