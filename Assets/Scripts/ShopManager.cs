using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    public void Background()
    {
        SceneManager.LoadScene("Background");
    }
    public void Balls()
    {
        SceneManager.LoadScene("Balls");
    }
    public void Obstacles()
    {
        SceneManager.LoadScene("Obstacles");
    }
    public void Rainbow()
    {
        SceneManager.LoadScene("Rainbow");
    }
    public void ReturnToMenu()
        {
            SceneManager.LoadScene("MainMenu");
    }
}
