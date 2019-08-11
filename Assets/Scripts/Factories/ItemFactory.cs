using System.Collections.Generic;
using Enums;
using Models;

namespace Factories
{
    public static class ItemFactory
    {
        public static IItem GetItem(int id)
        {
            switch (id)
            {
                case 1:
                    return new Item1();
                case 2:
                    return new Item2();
                default:
                    throw new KeyNotFoundException("No item with id " + id + " found");
            }
        }

        public static int GetSaveStateItemId(IItem item)
        {
            switch (item.ItemType)
            {
                case ItemTypes.Type1:
                    return 1;
                case ItemTypes.Type2:
                    return 2;
                default:
                    throw new KeyNotFoundException(item.ItemType + " is not a valid Save State Item");
            }
        }
    }
}
