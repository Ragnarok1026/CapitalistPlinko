using UnityEngine;

public class ShopFunction : MonoBehaviour
{
    public FloatSO Money;

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
            //PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Color.GetCost(Color.ItemType.Red));
            //PlayerPrefs.SetInt("Red", 1);
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
            //PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Color.GetCost(Color.ItemType.Orange));
            //PlayerPrefs.SetInt("Orange", 1);
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
            //PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Color.GetCost(Color.ItemType.Yellow));
            //PlayerPrefs.SetInt("Yellow", 1);
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
            //PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Color.GetCost(Color.ItemType.Blue));
            //PlayerPrefs.SetInt("Blue", 1);
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
            //PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Color.GetCost(Color.ItemType.Purple));
            //PlayerPrefs.SetInt("Purple", 1);
            isPurpleBought = true;
        }
        else
        {
            Debug.Log("Haha, Broke!");
            isPurpleBought = false;
        }
    }
}
