using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool isRedActive;
    public bool isOrangeActive;
    public bool isYellowActive;
    public bool isGreenActive;
    public bool isBlueActive;
    public bool isPurpleActive;

    public PlayerData (Activate activate)
    {
        isRedActive = activate.isRedActive;
        isOrangeActive = activate.isOrangeActive;
        isYellowActive = activate.isYellowActive;
        isGreenActive = activate.isGreenActive;
        isBlueActive = activate.isBlueActive;
        isPurpleActive = activate.isPurpleActive;
    }
}
