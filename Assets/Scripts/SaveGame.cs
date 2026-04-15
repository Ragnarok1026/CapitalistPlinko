using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public Activate activateBall;
    public Activate activateObstacle;
    public Activate activateBackground;

    public void Save()
    {
        SaveSystem.SavePlayer(activateBall);
        SaveSystem.SavePlayer(activateObstacle);
        SaveSystem.SavePlayer(activateBackground);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        activateBall.isRedActive = data.isRedActive;
        activateBall.isOrangeActive = data.isOrangeActive;
        activateBall.isYellowActive = data.isYellowActive;
        activateBall.isGreenActive = data.isGreenActive;
        activateBall.isBlueActive = data.isBlueActive;
        activateBall.isPurpleActive = data.isPurpleActive;

        activateObstacle.isRedActive = data.isRedActive;
        activateObstacle.isOrangeActive = data.isOrangeActive;
        activateObstacle.isYellowActive = data.isYellowActive;
        activateObstacle.isGreenActive = data.isGreenActive;
        activateObstacle.isBlueActive = data.isBlueActive;
        activateObstacle.isPurpleActive = data.isPurpleActive;

        activateBackground.isRedActive = data.isRedActive;
        activateBackground.isOrangeActive = data.isOrangeActive;
        activateBackground.isYellowActive = data.isYellowActive;
        activateBackground.isGreenActive = data.isGreenActive;
        activateBackground.isBlueActive = data.isBlueActive;
        activateBackground.isPurpleActive = data.isPurpleActive;
    }
}
