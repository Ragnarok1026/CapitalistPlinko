using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public Transform spawnPoint;
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
        if (collision.gameObject.CompareTag("10 Points"))
        {
           transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
            PlayerManager.Instance.AddPoints(10);
            Debug.Log("You scored 10 points!");
        }
        if (collision.gameObject.CompareTag("20 Points"))
        {
            transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
            PlayerManager.Instance.AddPoints(20);
            Debug.Log("You scored 20 points!");
        }
        if (collision.gameObject.CompareTag("30 Points"))
        {
            transform.position = spawnPoint.position;
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
            PlayerManager.Instance.AddPoints(30);
            Debug.Log("You scored 30 points!");
        }
    }
}
