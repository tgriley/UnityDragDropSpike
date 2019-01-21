using System;
using System.Collections.Generic;
using Persistence;

namespace Models
{
    public class Inventory
    {
        private SaveStateRepository _saveStateRepository;
        public IList<IItem> Items;

        public Inventory()
        {
            _saveStateRepository = new SaveStateRepository();

            var saveState = _saveStateRepository.Read();
            Items = saveState.Inventory;
        }
    }
}