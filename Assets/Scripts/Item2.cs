using Enums;
using Models;
using UnityEngine;

public class Item2 : IItem
{
    public ItemTypes ItemType
    {
        get { return ItemTypes.Type2; }
    }

    public string Name
    {
        get { return "Item 2 of water"; }
    }

    public Sprite Sprite
    {
        get { return Resources.Load<Sprite>("Images/Item2"); }
    }
}