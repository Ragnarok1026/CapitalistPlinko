using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
public class ColorManager : MonoBehaviour
{
    private static ColorManager instance;
    public static ColorManager Instance
        {
        get { return instance; }
    }
    public PlayerManager playerManager;
    public Color color;
    public GameObject playerGame;
    public Image player;

    public GameObject redBuy;
    public GameObject redSelect;
    public GameObject redActive;
    public GameObject orangeBuy;
    public GameObject orangeSelect;
    public GameObject orangeActive;
    public GameObject yellowBuy;
    public GameObject yellowSelect;
    public GameObject yellowActive;
    public GameObject greenBuy;
    public GameObject greenSelect;
    public GameObject greenActive;
    public GameObject blueBuy;
    public GameObject blueSelect;
    public GameObject blueActive;
    public GameObject purpleBuy;
    public GameObject purpleSelect;
    public GameObject purpleActive;

    public Material redMat;
    public Material orangeMat;
    public Material yellowMat;
    public Material greenMat;
    public Material blueMat;
    public Material purpleMat;

    void Start()
    {
       
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
            
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
        // code to change buttons to select based on the bools
        if (Player.instance.redBought == true)
        {
            redBuy.SetActive(false);
            redSelect.SetActive(true);
        }
        else if (Player.instance.redBought == false)
        {
            redBuy.SetActive(true);
            redSelect.SetActive(false);
        }
        if (Player.instance.orangeBought == true)
        {
            orangeBuy.SetActive(false);
            orangeSelect.SetActive(true);
        }
        else if (Player.instance.orangeBought == false)
        {
            orangeBuy.SetActive(true);
            orangeSelect.SetActive(false);
        }
        if (Player.instance.yellowBought == true)
        {
            yellowBuy.SetActive(false);
            yellowSelect.SetActive(true);
        }
        else if (Player.instance.yellowBought == false)
        {
            yellowBuy.SetActive(true);
            yellowSelect.SetActive(false);
        }
        if (Player.instance.greenBought == true)
        {
            greenBuy.SetActive(false);
            greenSelect.SetActive(true);
        }
        else if (Player.instance.greenBought == false)
        {
            greenBuy.SetActive(true);
            greenSelect.SetActive(false);
        }
        if (Player.instance.blueBought == true)
        {
            blueBuy.SetActive(false);
            blueSelect.SetActive(true);
        }
        else if (Player.instance.blueBought == false)
        {
            blueBuy.SetActive(true);
            blueSelect.SetActive(false);
        }
        if (Player.instance.purpleBought == true)
        {
            purpleBuy.SetActive(false);
            purpleSelect.SetActive(true);
        }
        else if (Player.instance.purpleBought == false)
        {
            purpleBuy.SetActive(true);
            purpleSelect.SetActive(false);
        }
        // code to change buttons to active based on the bools
        if (Player.instance.redActivated == true)
        {
            redSelect.SetActive(false);
            redActive.SetActive(true);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
            player.color = UnityEngine.Color.red;
            playerGame.GetComponent<SpriteRenderer>().material = redMat;

        }
        if (Player.instance.orangeActivated == true)
        {
            orangeSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(true);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
            player.color = new UnityEngine.Color(1f, 0.5f, 0f);
            playerGame.GetComponent<SpriteRenderer>().material = orangeMat;
        }
        if (Player.instance.yellowActivated == true)
        {
            yellowSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(true);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
            player.color = UnityEngine.Color.yellow;
            playerGame.GetComponent<SpriteRenderer>().material = yellowMat;
        }
        if (Player.instance.greenActivated == true)
        {
            greenSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(true);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
            player.color = UnityEngine.Color.green;
            playerGame.GetComponent<SpriteRenderer>().material = greenMat;
        }
        if (Player.instance.blueActivated == true)
        {
            blueSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(true);
            purpleActive.SetActive(false);
            player.color = UnityEngine.Color.blue;
            playerGame.GetComponent<SpriteRenderer>().material = blueMat;
        }
        if (Player.instance.purpleActivated == true)
        {
            purpleSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(true);
            player.color = new UnityEngine.Color(0.5f, 0f, 0.5f);
            playerGame.GetComponent<SpriteRenderer>().material = purpleMat;
        }
    }
    public void buyRed()
    {
        if (PlayerManager.Instance.scoreSO.Value >= Color.GetCost(Color.ItemType.Red))
        {

            PlayerManager.Instance.AddPoints(-Color.GetCost(Color.ItemType.Red));
            Player.instance.redBought = true;
            Player.instance.SavePlayer();
        }
        else
        {
            Debug.Log("Come back when your a little......Richer");
        }
    }
    public void buyOrange()
    {
        if (PlayerManager.Instance.scoreSO.Value >= Color.GetCost(Color.ItemType.Orange))
        {

            PlayerManager.Instance.AddPoints(-Color.GetCost(Color.ItemType.Orange));
            Player.instance.orangeBought = true;
            Player.instance.SavePlayer();
        }
        else
        {
            Debug.Log("Come back when your a little......Richer");
        }
    }
    public void buyYellow()
    {
        if (PlayerManager.Instance.scoreSO.Value >= Color.GetCost(Color.ItemType.Yellow))
        {

            PlayerManager.Instance.AddPoints(-Color.GetCost(Color.ItemType.Yellow));
            Player.instance.yellowBought = true;
            Player.instance.SavePlayer();
        }
        else
        {
            Debug.Log("Come back when your a little......Richer");
        }
    }
    public void buyBlue()
    {
        if (PlayerManager.Instance.scoreSO.Value >= Color.GetCost(Color.ItemType.Blue))
        {

            PlayerManager.Instance.AddPoints(-Color.GetCost(Color.ItemType.Blue));
            Player.instance.blueBought = true;
            Player.instance.SavePlayer();
        }
        else
        {
            Debug.Log("Come back when your a little......Richer");
        }
    }
    public void buyPurple()
    {
        if (PlayerManager.Instance.scoreSO.Value >= Color.GetCost(Color.ItemType.Purple))
        {

            PlayerManager.Instance.AddPoints(-Color.GetCost(Color.ItemType.Purple));
            Player.instance.purpleBought = true;
            Player.instance.SavePlayer();
        }
        else
        {
            Debug.Log("Come back when your a little......Richer");
        }
    }

    public void activateRed()
    {
        Player.instance.redActivated = true;
        Player.instance.orangeActivated = false;
        Player.instance.yellowActivated = false;
        Player.instance.greenActivated = false;
        Player.instance.blueActivated = false;
        Player.instance.purpleActivated = false;
        Player.instance.SavePlayer();
    }
    public void activateOrange()
    {
        Player.instance.redActivated = false;
        Player.instance.orangeActivated = true;
        Player.instance.yellowActivated = false;
        Player.instance.greenActivated = false;
        Player.instance.blueActivated = false;
        Player.instance.purpleActivated = false;
        Player.instance.SavePlayer();
    }
    public void activateYellow()
    {
        Player.instance.redActivated = false;
        Player.instance.orangeActivated = false;
        Player.instance.yellowActivated = true;
        Player.instance.greenActivated = false;
        Player.instance.blueActivated = false;
        Player.instance.purpleActivated = false;
        Player.instance.SavePlayer();
    }
    public void activateGreen()
    {
        Player.instance.redActivated = false;
        Player.instance.orangeActivated = false;
        Player.instance.yellowActivated = false;
        Player.instance.greenActivated = true;
        Player.instance.blueActivated = false;
        Player.instance.purpleActivated = false;
        Player.instance.SavePlayer();
    }
    public void activateBlue()
    {
        Player.instance.redActivated = false;
        Player.instance.orangeActivated = false;
        Player.instance.yellowActivated = false;
        Player.instance.greenActivated = false;
        Player.instance.blueActivated = true;
        Player.instance.purpleActivated = false;
        Player.instance.SavePlayer();
    }
    public void activatePurple()
    {
        Player.instance.redActivated = false;
        Player.instance.orangeActivated = false;
        Player.instance.yellowActivated = false;
        Player.instance.greenActivated = false;
        Player.instance.blueActivated = false;
        Player.instance.purpleActivated = true;
        Player.instance.SavePlayer();
    }
}
