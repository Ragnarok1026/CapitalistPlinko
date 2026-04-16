using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public UI_Shop shop;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(shop);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        shop.isRedActive = data.isRedActive;
        shop.isOrangeActive = data.isOrangeActive;
        shop.isYellowActive = data.isYellowActive;
        shop.isGreenActive = data.isGreenActive;
        shop.isBlueActive = data.isBlueActive;
        shop.isPurpleActive = data.isPurpleActive;
    }
}
