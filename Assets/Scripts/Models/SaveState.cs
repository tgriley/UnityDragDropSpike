using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class SaveState
    {
        public List<SaveStateItem> Inventory;
        public List<SaveStateItem> Infrastructure;
        public int Id;

        public SaveState()
        {
            Inventory = new List<SaveStateItem>();
            Infrastructure = new List<SaveStateItem>();
        }
    }

    [Serializable]
    public class SaveStateItem
    {
        
        public int Id;
    }
}