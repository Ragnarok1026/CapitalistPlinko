using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
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
    public static Player instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            LoadPlayer();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
       
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(instance);
        Debug.Log("Player Saved");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Debug.Log("Player Loaded");

        instance.redBought = data.redBought;
        instance.orangeBought = data.orangeBought;
        instance.yellowBought = data.yellowBought;
        instance.greenBought = data.greenBought;
        instance.blueBought = data.blueBought;
        instance.purpleBought = data.purpleBought;

        instance.redActivated = data.redActivated;
        instance.orangeActivated = data.orangeActivated;
        instance.yellowActivated = data.yellowActivated;
        instance.greenActivated = data.greenActivated;
        instance.blueActivated = data.blueActivated;
        instance.purpleActivated = data.purpleActivated;
    }

    public void ResetPlayer()
    {
        instance.redBought = false;
        instance.orangeBought = false;
        instance.yellowBought = false;
        instance.greenBought = true;
        instance.blueBought = false;
        instance.purpleBought = false;
        instance.redActivated = false;
        instance.orangeActivated = false;
        instance.yellowActivated = false;
        instance.greenActivated = true;
        instance.blueActivated = false;
        instance.purpleActivated = false;
        PlayerManager.Instance.scoreSO.Value = 0;
        PlayerManager.Instance.scoreText.text = "Points: " + PlayerManager.Instance.scoreSO.Value;
        SaveSystem.SavePlayer(instance);
        Debug.Log(PlayerManager.Instance.scoreSO.Value);
        Debug.Log(PlayerManager.Instance);
    }
}
