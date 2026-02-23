using UnityEngine;

public class MultiplierProbability : MonoBehaviour
{
    public GameObject multiplier3X;
    public GameObject multiplier2X;
    public GameObject add30Points;
    public GameObject add50Points;
    
    public static int multiplierChance { get; private set; }
    void Start()
    {

    }
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Multiplier"))
        {
            multiplierChance = Random.Range(1, 20);
            Debug.Log("Multiplier Chance: " + multiplierChance);
            if (multiplierChance >= 1 && multiplierChance <= 5)
            {
                 add30Points.SetActive(true);
                 add50Points.SetActive(false);
                 multiplier2X.SetActive(false);
                 multiplier3X.SetActive(false);
            }
            if(multiplierChance >= 6 && multiplierChance <= 10)
            {
                 add50Points.SetActive(true);
                 add30Points.SetActive(false);
                 multiplier2X.SetActive(false);
                 multiplier3X.SetActive(false);
            }
            if(multiplierChance >= 11 && multiplierChance <= 15)
            {
                 multiplier2X.SetActive(true);
                 add30Points.SetActive(false);
                 add50Points.SetActive(false);
                 multiplier3X.SetActive(false);
            }
            if(multiplierChance >= 16 && multiplierChance <= 20)
            {
                 multiplier3X.SetActive(true);
                 add30Points.SetActive(false);
                 add50Points.SetActive(false);
                 multiplier2X.SetActive(false);
            }
        }
    }

}
