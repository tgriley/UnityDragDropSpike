using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class Infrastructure
    {
        public IList<IItem> Items;

        public Infrastructure()
        {
            Items = new List<IItem>();
        }
    }
}