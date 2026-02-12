using UnityEngine;

public class ReturnToGame : MonoBehaviour
{
    public GameObject pauseMenuUI;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Return()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
    }
}
