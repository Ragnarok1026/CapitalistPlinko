using System;
using System.ComponentModel;
using UnityEngine;

public class Color : MonoBehaviour
{
    public enum ItemType
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple
    }

    public static int GetCost (ItemType itemType)
    {
        switch (itemType)
        {
            default:
                case ItemType.Red:     return 200;
                case ItemType.Orange:  return 300;
                case ItemType.Yellow:  return 400;
                case ItemType.Green:   return 0;
                case ItemType.Blue:    return 500;
                case ItemType.Purple:  return 600;
        }
    }

    public static Sprite GetSprite (ItemType itemType)
    {
        switch (itemType)
        {
            default:
                case ItemType.Red:     return GameAssets.i.Red;
                case ItemType.Orange:  return GameAssets.i.Orange;
                case ItemType.Yellow:  return GameAssets.i.Yellow;
                case ItemType.Green:   return GameAssets.i.Green;
                case ItemType.Blue:    return GameAssets.i.Blue;
                case ItemType.Purple:  return GameAssets.i.Purple;
        }
    }
}
