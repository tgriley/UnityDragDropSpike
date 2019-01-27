using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class SaveState
    {
        public List<SaveStateItem> Inventory;
        public int Id;
    }

    [Serializable]
    public class SaveStateItem
    {
        public int Id;
    }
}