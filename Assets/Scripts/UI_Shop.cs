using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Shop : MonoBehaviour
{
    public bool isRedActive = false;
    public bool isOrangeActive = false;
    public bool isYellowActive = false;
    public bool isGreenActive = true;
    public bool isBlueActive = false;
    public bool isPurpleActive = false;

    public bool isRedBought = false;
    public bool isOrangeBought = false;
    public bool isYellowBought = false;
    public bool isGreenBought = true;
    public bool isBlueBought = false;
    public bool isPurpleBought = false;
    public void SavePlayer()
    {
       SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        isRedActive = data.isRedActive;
        isOrangeActive = data.isOrangeActive;
        isYellowActive = data.isYellowActive;
        isGreenActive = data.isGreenActive;
        isBlueActive = data.isBlueActive;
        isPurpleActive = data.isPurpleActive;

        isRedBought = data.isRedActive;
        isOrangeBought = data.isOrangeActive;
        isYellowBought = data.isYellowActive;
        isGreenBought = data.isGreenActive;
        isBlueBought = data.isBlueActive;
        isPurpleBought = data.isPurpleActive;
    }
}
