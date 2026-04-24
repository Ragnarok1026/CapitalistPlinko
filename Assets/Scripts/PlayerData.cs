using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool redBought;
    public bool orangeBought;
    public bool yellowBought;
    public bool greenBought;
    public bool blueBought;
    public bool purpleBought;

    public bool redActivated;
    public bool orangeActivated;
    public bool yellowActivated;
    public bool greenActivated;
    public bool blueActivated;
    public bool purpleActivated;
    public float scoreSO;

    public PlayerData(Player player)
    {
        redBought = player.redBought;
        orangeBought = player.orangeBought;
        yellowBought = player.yellowBought;
        greenBought = player.greenBought;
        blueBought = player.blueBought;
        purpleBought = player.purpleBought;

        redActivated = player.redActivated;
        orangeActivated = player.orangeActivated;
        yellowActivated = player.yellowActivated;
        greenActivated = player.greenActivated;
        blueActivated = player.blueActivated;
        purpleActivated = player.purpleActivated;

        scoreSO = player.scoreSO;
    }
    public PlayerData()
    {
        redBought = false;
        orangeBought = false;
        yellowBought = false;
        greenBought = true;
        blueBought = false;
        purpleBought = false;

        redActivated = false;
        orangeActivated = false;
        yellowActivated = false;
        greenActivated = true;
        blueActivated = false;
        purpleActivated = false;
    }
}
