using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    public GameObject settings;
    public GameObject back;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Settings()
    {
        settings.SetActive(true);
        back.SetActive(false);
    }
    public void Back()
    {
        back.SetActive(true);
        settings.SetActive(false);
    }
}
