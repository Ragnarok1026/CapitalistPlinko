using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public UI_Shop shop;
    public bool isRedActive;
    public bool isOrangeActive;
    public bool isYellowActive;
    public bool isGreenActive;
    public bool isBlueActive;
    public bool isPurpleActive;

    public PlayerData (UI_Shop shop)
    {
        isRedActive = shop.isRedActive;
        isOrangeActive = shop.isOrangeActive;
        isYellowActive = shop.isYellowActive;
        isGreenActive = shop.isGreenActive;
        isBlueActive = shop.isBlueActive;
        isPurpleActive = shop.isPurpleActive;
    }
}
