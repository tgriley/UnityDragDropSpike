using System;
using System.Collections.Generic;

namespace Models
{
    public class Inventory
    {
        [NonSerialized] 
        public IList<IItem> Items;

        public Inventory()
        {
            Items = new List<IItem>();
            
            Items.Add(new Item1());
            Items.Add(new Item1());
            Items.Add(new Item2());
            Items.Add(new Item2());
        }
    }
}