using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButtons : MonoBehaviour
{
    public void BallShopEnter()
    {
        SceneManager.LoadScene("BallShop");
    }
    public void ObstacleShopEnter()
    {
        SceneManager.LoadScene("ObstacleShop");
    }
    public void BackgroundShopEnter()
    {
        SceneManager.LoadScene("BackgroundShop");
    }
    public void MusicShopEnter()
    {
        SceneManager.LoadScene("MusicShop");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
