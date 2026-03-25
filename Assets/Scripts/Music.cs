using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject cam;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PauseMusic()
    {
        cam.GetComponent<AudioSource>().Pause();
    }
    public void ContinueMusic()
    {
        cam.GetComponent<AudioSource>().UnPause();
    }
}
