using System.Collections.Generic;
using Factories;
using Persistence;

namespace Models
{
    public class Inventory
    {
        public IList<IItem> Items;

        public Inventory()
        {
            Items = new List<IItem>();
        }
    }
}