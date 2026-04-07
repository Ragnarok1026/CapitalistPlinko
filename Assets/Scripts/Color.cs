using System.ComponentModel;
using UnityEngine;

public class Color : MonoBehaviour
{
    public enum ColorType
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple
    }

    public static int GetCost(ColorType color)
    {
        switch (color)
        {
            default:
                case ColorType.Red:     return 200;
                case ColorType.Orange:  return 300;
                case ColorType.Yellow:  return 400;
                case ColorType.Green:   return 0;
                case ColorType.Blue:    return 500;
                case ColorType.Purple:  return 600;
        }
    }

    public static Sprite GetSprite(ColorType color)
    {
        switch (color)
        {
            default:
                case ColorType.Red:     return GameAssets.i.Red;
                case ColorType.Orange:  return GameAssets.i.Orange;
                case ColorType.Yellow:  return GameAssets.i.Yellow;
                case ColorType.Green:   return GameAssets.i.Green;
                case ColorType.Blue:    return GameAssets.i.Blue;
                case ColorType.Purple:  return GameAssets.i.Purple;
        }
    }
}
