using UnityEngine;

public interface IItem
{
    ItemTypes ItemType { get; }
    string Name { get; }
    Sprite Sprite { get; }
}