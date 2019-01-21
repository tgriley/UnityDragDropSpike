using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class SaveState
    {
        public List<IItem> Inventory { get; set; }
        public List<IItem> Infrastructure { get; set; }
    }
}