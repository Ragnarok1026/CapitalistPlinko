using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public GameObject start;
    public GameObject shop;
    public GameObject settings;
    public GameObject exit;
    public GameObject ball;
    public GameObject background;
    public GameObject obstacle;

    public GameObject points;
    public GameObject shopTitle;
    public GameObject backgroundTitle;
    public GameObject settingsTitle;
    public GameObject logo1;
    public GameObject logo2;

    public GameObject redLogo;
    public GameObject greenLogo;

    public GameObject exitShop;
    public GameObject exitBackground;
    public GameObject exitSettings;

    public Slider MusicSlider;
    public GameObject MusicHandle;
    public GameObject MusicBackground;
    public Slider SoundSlider;
    public GameObject SoundHandle;
    public GameObject SoundBackground;

    private bool isRed = false;
    private bool isOrange = false;
    private bool isYellow = false;
    private bool isGreen = true;
    private bool isBlue = false;
    private bool isPurple = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (isRed)
        {
            start.GetComponent<Image>().color = Color.red;
            shop.GetComponent<Image>().color = Color.red;
            settings.GetComponent<Image>().color = Color.red;
            exit.GetComponent<Image>().color = Color.red;
            ball.GetComponent<Image>().color = Color.red;
            background.GetComponent<Image>().color = Color.red;
            obstacle.GetComponent<Image>().color = Color.red;
            exitShop.GetComponent<Image>().color = Color.red;
            exitBackground.GetComponent<Image>().color = Color.red;
            exitSettings.GetComponent<Image>().color = Color.red;

            points.GetComponent<TextMeshProUGUI>().color = Color.red;
            shopTitle.GetComponent<TextMeshProUGUI>().color = Color.red;
            backgroundTitle.GetComponent<TextMeshProUGUI>().color = Color.red;
            settingsTitle.GetComponent<TextMeshProUGUI>().color = Color.red;
            SoundBackground.GetComponent<Image>().color = Color.red;
            SoundHandle.GetComponent<Image>().color = Color.red;
            MusicBackground.GetComponent<Image>().color = Color.red;
            MusicHandle.GetComponent<Image>().color = Color.red;

            logo1.GetComponent<TextMeshPro>().color = Color.red;
            logo2.GetComponent<TextMeshPro>().color = Color.red;
            redLogo.SetActive(true);
            greenLogo.SetActive(false);

            SoundSlider.GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
            SoundSlider.GetComponentInChildren<Image>().color = Color.red;
            MusicSlider.GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
            MusicSlider.GetComponentInChildren<Image>().color = Color.red;
        }
        if (isGreen)
        {
            start.GetComponent<Image>().color = Color.green;
            shop.GetComponent<Image>().color = Color.green;
            settings.GetComponent<Image>().color = Color.green;
            exit.GetComponent<Image>().color = Color.green;
            ball.GetComponent<Image>().color = Color.green;
            background.GetComponent<Image>().color = Color.green;
            obstacle.GetComponent<Image>().color = Color.green;
            exitShop.GetComponent<Image>().color = Color.green;
            exitBackground.GetComponent<Image>().color = Color.green;
            exitSettings.GetComponent<Image>().color = Color.green;

            points.GetComponent<TextMeshProUGUI>().color = Color.green;
            shopTitle.GetComponent<TextMeshProUGUI>().color = Color.green;
            backgroundTitle.GetComponent<TextMeshProUGUI>().color = Color.green;
            settingsTitle.GetComponent<TextMeshProUGUI>().color = Color.green;
            SoundBackground.GetComponent<Image>().color = Color.green;
            SoundHandle.GetComponent<Image>().color = Color.green;
            MusicBackground.GetComponent<Image>().color = Color.green;
            MusicHandle.GetComponent<Image>().color = Color.green;

            logo1.GetComponent<TextMeshPro>().color = Color.green;
            logo2.GetComponent<TextMeshPro>().color = Color.green;
            redLogo.SetActive(false);
            greenLogo.SetActive(true);

            SoundSlider.GetComponentInChildren<TextMeshProUGUI>().color = Color.green;
            SoundSlider.GetComponentInChildren<Image>().color = Color.green;
            MusicSlider.GetComponentInChildren<TextMeshProUGUI>().color = Color.green;
            MusicSlider.GetComponentInChildren<Image>().color = Color.green;
        }
    }
    public void Red()
    {
        isRed = true;
        isOrange = false;
        isYellow = false;
        isGreen = false;
        isBlue = false;
        isPurple = false;
    }
    public void Green()
    {
        isRed = false;
        isOrange = false;
        isYellow = false;
        isGreen = true;
        isBlue = false;
        isPurple = false;
    }
}
