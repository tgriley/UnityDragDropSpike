using System.Collections;
using System.Collections.Generic;
using Models;

namespace Persistence
{
    public class SaveStateRepository
    {
        public SaveState Read()
        {
            var saveState = new SaveState();
            saveState.Inventory = new List<IItem>()
            {
                new Item1(),
                new Item1(),
                new Item2(),
                new Item2(),
            };

            return saveState;
        }

        public void Save(SaveState saveState)
        {

        }
    }
}