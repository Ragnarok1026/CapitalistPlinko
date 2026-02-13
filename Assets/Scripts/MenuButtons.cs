using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject pauseGame;
    public GameObject resumeGame;
    void Start()
    {

    }
    void Update()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        resumeGame.SetActive(false);
        pauseGame.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        resumeGame.SetActive(true);
        pauseGame.SetActive(false);
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
}
