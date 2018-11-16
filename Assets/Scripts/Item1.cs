using UnityEngine;

public class Item1 : IItem
{
    public ItemTypes ItemType
    {
        get { return ItemTypes.Type1; }
    }

    public string Name
    {
        get { return "Item 1 of fire"; }
    }

    public Sprite Sprite
    {
        get { return Resources.Load<Sprite>("Images/Item1"); }
    }
}