using System.Collections.Generic;
using Models;
using UnityEngine;

namespace Persistence
{
    public class SaveStateRepository
    {
        private readonly string SaveStateKey = "save-state";
        public SaveState Read()
        {
//            Save(new SaveState()
//            {
//                Inventory = new List<SaveStateItem>()
//                {
//                    new SaveStateItem(){Id = 1},
//                    new SaveStateItem(){Id = 1},
//                    new SaveStateItem(){Id = 2},
//                },
//                Infrastructure = new List<SaveStateItem>()
//                {
//                    new SaveStateItem(){Id = 1},
//                    new SaveStateItem(){Id = 1}
//                }
//            });
            
            if (!PlayerPrefs.HasKey(SaveStateKey))
            {
                return new SaveState();
            }

            var saveStateJsonString = PlayerPrefs.GetString(SaveStateKey);
            var saveState = JsonUtility.FromJson<SaveState>(saveStateJsonString);
            
            return saveState;
        }

        public void Save(SaveState saveState)
        {
            var saveStateJson = JsonUtility.ToJson(saveState);
            PlayerPrefs.SetString(SaveStateKey, saveStateJson);
            PlayerPrefs.Save();
        }
    }
}