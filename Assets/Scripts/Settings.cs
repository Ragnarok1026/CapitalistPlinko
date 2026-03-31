using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider soundSlider;
    public Slider musicSlider;
    void Start()
    {
        soundSlider.value = PlayerPrefs.GetFloat("MasterVol", 0f);
        musicSlider.value = PlayerPrefs.GetFloat("MusicVol", 0f);
    }
    void Update()
    {
        
    }
    public void ChangeSoundVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSoundVolume(soundLevel);
    }
    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }
}
