using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;

    public static PlayerManager Instance
    {
        get { return _instance; }
    }

    [SerializeField]
    public FloatSO scoreSO;

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
        scoreText.text = "Points: " + scoreSO.Value;
    }

    public void AddPoints(int pointsToAdd)
    {
        scoreSO.Value += pointsToAdd;
        scoreText.text = "Points: " + scoreSO.Value;
        Player.instance.scoreSO = scoreSO.Value;
        Player.instance.SavePlayer();
    }
    public void ResetPoints()
    {
        Player.instance.ResetPlayer();

    }
}