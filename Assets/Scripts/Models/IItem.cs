using Enums;
using UnityEngine;

namespace Models
{
    public interface IItem
    {
        ItemTypes ItemType { get; }
        string Name { get; }
        Sprite Sprite { get; }
    }
}