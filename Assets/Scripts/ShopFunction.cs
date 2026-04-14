using UnityEngine;

public class ShopFunction : MonoBehaviour
{
    public FloatSO Money;
    public PlayerManager playerManager;

    public GameObject Red;
    public GameObject RedSelect;
    public GameObject RedActive;
    public GameObject Orange;
    public GameObject OrangeSelect;
    public GameObject OrangeActive;
    public GameObject Yellow;
    public GameObject YellowSelect;
    public GameObject YellowActive;
    public GameObject Green;
    public GameObject GreenSelect;
    public GameObject GreenActive;
    public GameObject Blue;
    public GameObject BlueSelect;
    public GameObject BlueActive;
    public GameObject Purple;
    public GameObject PurpleSelect;
    public GameObject PurpleActive;

    private bool isRedBought;
    private bool isOrangeBought;
    private bool isYellowBought;
    private bool isGreenBought;
    private bool isBlueBought;
    private bool isPurpleBought;
    public void Start()
    {
        isRedBought = false;
        isOrangeBought = false;
        isYellowBought = false;
        isGreenBought = true;
        isBlueBought = false;
        isPurpleBought = false;
    }
    public void Update()
    {
        if (isRedBought == true)
        {
            Red.SetActive(false);
            RedSelect.SetActive(true);
        }
        if(isOrangeBought == true)
        {
            Orange.SetActive(false);
            OrangeSelect.SetActive(true);
        }
        if(isYellowBought == true)
        {
            Yellow.SetActive(false);
            YellowSelect.SetActive(true);
        }
        if(isGreenBought == true)
        {
            Green.SetActive(false);
            GreenSelect.SetActive(true);
        }
        if(isBlueBought == true)
        {
            Blue.SetActive(false);
            BlueSelect.SetActive(true);
        }
        if(isPurpleBought == true)
        {
            Purple.SetActive(false);
            PurpleSelect.SetActive(true);
        }
    }
    public void BuyColorRed()
    {
        if(Money.Value >= Color.GetCost(Color.ItemType.Red))
        {
            Debug.Log("Color Red bought!");
            playerManager.AddPoints(-Color.GetCost(Color.ItemType.Red));

            isRedBought = true;
        }
       else
       {
            Debug.Log("Haha, Broke!");
            isRedBought = false;
       }
    }
    public void BuyColorOrange()
    {
       if (Money.Value >= Color.GetCost(Color.ItemType.Orange))
        {
            Debug.Log("Color Orange bought!");
            playerManager.AddPoints(-Color.GetCost(Color.ItemType.Orange));
            isOrangeBought = true;
        }
       else
       {
           Debug.Log("Haha, Broke!");
           isOrangeBought = false;
        }
    }
    public void BuyColorYellow()
    {
        if (Money.Value >= Color.GetCost(Color.ItemType.Yellow))
        {
            Debug.Log("Color Yellow bought!");
            playerManager.AddPoints(-Color.GetCost(Color.ItemType.Yellow));
            isYellowBought = true;
        }
       else
       {
           Debug.Log("Haha, Broke!");
           isYellowBought = false;
       }
    }
    public void BuyColorBlue()
    {
        if (Money.Value >= Color.GetCost(Color.ItemType.Blue))
        {
            Debug.Log("Color Blue bought!");
            playerManager.AddPoints(-Color.GetCost(Color.ItemType.Blue));
            isBlueBought = true;
        }
        else
        {
            Debug.Log("Haha, Broke!");
            isBlueBought = false;
        }
    }
    public void BuyColorPurple()
    {
        if (Money.Value >= Color.GetCost(Color.ItemType.Purple))
        {
            Debug.Log("Color Purple bought!");
            playerManager.AddPoints(-Color.GetCost(Color.ItemType.Purple));
            isPurpleBought = true;
        }
        else
        {
            Debug.Log("Haha, Broke!");
            isPurpleBought = false;
        }
    }
}
