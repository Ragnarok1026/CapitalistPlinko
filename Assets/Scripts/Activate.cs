using UnityEngine;

public class Activate : MonoBehaviour
{
    public UI_Shop shop;
    public GameObject ActiveRed;
    public GameObject ActiveOrange;
    public GameObject ActiveYellow;
    public GameObject ActiveGreen;
    public GameObject ActiveBlue;
    public GameObject ActivePurple;

    public GameObject Red;
    public GameObject Orange;
    public GameObject Yellow;
    public GameObject Green;
    public GameObject Blue;
    public GameObject Purple;

    public bool isRedActive;
    public bool isOrangeActive;
    public bool isYellowActive;
    public bool isGreenActive;
    public bool isBlueActive;
    public bool isPurpleActive;
    void Start()
    {
        
    }
    void Update()
    {
        if (shop.isRedActive == true)
        {
            ActiveRed.SetActive(true);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (shop.isOrangeActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(true);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (shop.isYellowActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(true);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (shop.isGreenActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(true);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (shop.isBlueActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(true);
            ActivePurple.SetActive(false);
        }
        if (shop.isPurpleActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(true);
        }
    }
}
