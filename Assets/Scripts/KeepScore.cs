using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public Transform spawnPoint;
    public bool add30Points;
    public bool add50Points;
    public bool Multiply3;
    public bool Multiply2;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("+30"))
        {
            add30Points = true;
        }
        if (collision.gameObject.CompareTag("+50"))
        {
            add50Points = true;
        }
        if (collision.gameObject.CompareTag("3X"))
        {
            Multiply3 = true;
        }
        if (collision.gameObject.CompareTag("2X"))
        {
            Multiply2 = true;
        }

        if (collision.gameObject.CompareTag("10 Points"))
        {
            transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
            PlayerManager.Instance.AddPoints(10);
            Debug.Log("You scored 10 points!");
            if (add30Points == true)
            {
                PlayerManager.Instance.AddPoints(30);
                Debug.Log("You scored an additional 30 points!");
                add30Points = false;
            }
            if (add50Points == true)
            {
                PlayerManager.Instance.AddPoints(50);
                Debug.Log("You scored an additional 50 points!");
                add50Points = false;
            }
            if (Multiply3 == true)
            {
                PlayerManager.Instance.AddPoints(20);
                Debug.Log("Your points have been multiplied by 3!");
                Multiply3 = false;
            }
            if (Multiply2 == true)
            {
                PlayerManager.Instance.AddPoints(10);
                Debug.Log("Your points have been multiplied by 2!");
                Multiply2 = false;
            }
        }
        if (collision.gameObject.CompareTag("20 Points"))
        {
            transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
            PlayerManager.Instance.AddPoints(20);
            Debug.Log("You scored 20 points!");
            if (add30Points == true)
            {
                PlayerManager.Instance.AddPoints(30);
                Debug.Log("You scored an additional 30 points!");
                add30Points = false;
            }
            if (add50Points == true)
            {
                PlayerManager.Instance.AddPoints(50);
                Debug.Log("You scored an additional 50 points!");
                add50Points = false;
            }
            if (Multiply3 == true)
            {
                PlayerManager.Instance.AddPoints(40);
                Debug.Log("Your points have been multiplied by 2!");
                Multiply3 = false;
            }
            if (Multiply2 == true)
            {
                PlayerManager.Instance.AddPoints(20);
                Debug.Log("Your points have been multiplied by 2!");
                Multiply2 = false;
            }
        }
        if (collision.gameObject.CompareTag("30 Points"))
        {
            transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
            PlayerManager.Instance.AddPoints(30);
            Debug.Log("You scored 30 points!");
            if (add30Points == true)
            {
                PlayerManager.Instance.AddPoints(30);
                Debug.Log("You scored an additional 30 points!");
                add30Points = false;
            }
            if (add50Points == true)
            {
                PlayerManager.Instance.AddPoints(50);
                Debug.Log("You scored an additional 50 points!");
                add50Points = false;
            }
            if (Multiply3 == true)
            {
                PlayerManager.Instance.AddPoints(60);
                Debug.Log("Your points have been multiplied by 3!");
                Multiply3 = false;
            }
            if (Multiply2 == true)
            {
                PlayerManager.Instance.AddPoints(30);
                Debug.Log("Your points have been multiplied by 2!");
                Multiply2 = false;
            }
        }
    }
}
