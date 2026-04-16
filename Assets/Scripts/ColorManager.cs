using UnityEngine;

public class ColorManager : MonoBehaviour
{
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

    private bool redBought = false;
    private bool orangeBought = false;
    private bool yellowBought = false;
    private bool greenBought = true;
    private bool blueBought = false;
    private bool purpleBought = false;

    public bool redActivated = false;
    public bool orangeActivated = false;
    public bool yellowActivated = false;
    public bool greenActivated = true;
    public bool blueActivated = false;
    public bool purpleActivated = false;
    void Update()
    {
        // code to change buttons to select based on the bools
        if (redBought == true)
        {
            redBuy.SetActive(false);
            redSelect.SetActive(true);
        }
        if (orangeBought == true)
        {
            orangeBuy.SetActive(false);
            orangeSelect.SetActive(true);
        }
        if (yellowBought == true)
        {
            yellowBuy.SetActive(false);
            yellowSelect.SetActive(true);
        }
        if (greenBought == true)
        {
            greenBuy.SetActive(false);
            greenSelect.SetActive(true);
        }
        if (blueBought == true)
        {
            blueBuy.SetActive(false);
            blueSelect.SetActive(true);
        }
        if (purpleBought == true)
        {
            purpleBuy.SetActive(false);
            purpleSelect.SetActive(true);
        }
        // code to change buttons to active based on the bools
        if (redActivated == true)
        {
            redSelect.SetActive(false);
            redActive.SetActive(true);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
        }
        if (orangeActivated == true)
        {
            orangeSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(true);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
        }
        if (yellowActivated == true)
        {
            yellowSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(true);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
        }
        if (greenActivated == true)
        {
            greenSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(true);
            blueActive.SetActive(false);
            purpleActive.SetActive(false);
        }
        if (blueActivated == true)
        {
            blueSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(true);
            purpleActive.SetActive(false);
        }
        if (purpleActivated == true)
        {
            purpleSelect.SetActive(false);
            redActive.SetActive(false);
            orangeActive.SetActive(false);
            yellowActive.SetActive(false);
            greenActive.SetActive(false);
            blueActive.SetActive(false);
            purpleActive.SetActive(true);
        }
    }
    public void buyRed()
    {
        redBought = true;
    }
    public void buyOrange()
    {
        orangeBought = true;
    }
    public void buyYellow()
    {
        yellowBought = true;
    }
    public void buyBlue()
    {
        blueBought = true;
    }
    public void buyPurple()
    {
        purpleBought = true;
    }

    public void activateRed()
    {
        redActivated = true;
        orangeActivated = false;
        yellowActivated = false;
        greenActivated = false;
        blueActivated = false;
        purpleActivated = false;
    }
    public void activateOrange()
    {
        redActivated = false;
        orangeActivated = true;
        yellowActivated = false;
        greenActivated = false;
        blueActivated = false;
        purpleActivated = false;
    }
    public void activateYellow()
    {
        redActivated = false;
        orangeActivated = false;
        yellowActivated = true;
        greenActivated = false;
        blueActivated = false;
        purpleActivated = false;
    }
    public void activateGreen()
    {
        redActivated = false;
        orangeActivated = false;
        yellowActivated = false;
        greenActivated = true;
        blueActivated = false;
        purpleActivated = false;
    }
    public void activateBlue()
    {
        redActivated = false;
        orangeActivated = false;
        yellowActivated = false;
        greenActivated = false;
        blueActivated = true;
        purpleActivated = false;
    }
    public void activatePurple()
    {
        redActivated = false;
        orangeActivated = false;
        yellowActivated = false;
        greenActivated = false;
        blueActivated = false;
        purpleActivated = true;
    }
}
