using UnityEngine;

public class Activate : MonoBehaviour
{
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

    public bool isRedActive = false;
    public bool isOrangeActive = false;
    public bool isYellowActive = false;
    public bool isGreenActive = true;
    public bool isBlueActive = false;
    public bool isPurpleActive = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (isRedActive == true)
        {
            ActiveRed.SetActive(true);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (isOrangeActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(true);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (isYellowActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(true);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (isGreenActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(true);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(false);
        }
        if (isBlueActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(true);
            ActivePurple.SetActive(false);
        }
        if (isPurpleActive == true)
        {
            ActiveRed.SetActive(false);
            ActiveOrange.SetActive(false);
            ActiveYellow.SetActive(false);
            ActiveGreen.SetActive(false);
            ActiveBlue.SetActive(false);
            ActivePurple.SetActive(true);
        }
    }

    public void ActivateRed()
    {
        isRedActive = true;
        isOrangeActive = false;
        isYellowActive = false;
        isGreenActive = false;
        isBlueActive = false;
        isPurpleActive = false;
    }
    public void ActivateOrange()
    {
        isRedActive = false;
        isOrangeActive = true;     
        isYellowActive = false;
        isGreenActive = false;
        isBlueActive = false;
        isPurpleActive = false;
    }
    public void ActivateYellow()
    {
        isRedActive = false;
        isOrangeActive = false;
        isYellowActive = true;    
        isGreenActive = false;
        isBlueActive = false;
        isPurpleActive = false;
    }
    public void ActivateGreen()
    {
        isRedActive = false;
        isOrangeActive = false;
        isYellowActive = false;
        isGreenActive = true;
        isBlueActive = false;
        isPurpleActive = false;
    }
    public void ActivateBlue()
    {
        isRedActive = false;
        isOrangeActive = false;
        isYellowActive = false;
        isGreenActive = false;
        isBlueActive = true;      
        isPurpleActive = false;
    }
    public void ActivatePurple()
    {
        isRedActive = false;
        isOrangeActive = false;
        isYellowActive = false;
        isGreenActive = false;
        isBlueActive = false;
        isPurpleActive = true;      
    }
}
