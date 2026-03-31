using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    public static AudioManager Instance { get { return _instance; } }

    public AudioMixer masterMixer;

    private void Awake()
    {
        if( _instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(_instance);
    }
    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PlayerPrefs.SetFloat("MasterVol", soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PlayerPrefs.SetFloat("MusicVol", soundLevel);
    }
}
