using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;

    public static PlayerManager Instance
    {
        get { return _instance; }
    }

    // Score variables
    private int currentPoints;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        scoreText.text = "Score: " + currentPoints;
    }

    public void AddPoints(int pointsToAdd)
    {
        currentPoints += pointsToAdd;
        scoreText.text = "Score: " + currentPoints;
    }
}