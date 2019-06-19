using System.Collections.Generic;
using Models;

namespace Factories
{
    public class ItemFactory
    {
        public IItem GetItem(int id)
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
    }
}