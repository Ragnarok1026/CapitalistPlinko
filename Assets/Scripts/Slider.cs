using UnityEngine;

public class Slider : MonoBehaviour
{
    public float speed = 3f;
    public GameObject leftStop;
    public GameObject rightStop;
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }
    void Update()
    {
        // Move the enemy left or right based on the Speed variable
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        // Check for direction change at the stop points
        if (transform.position.x <= leftStop.transform.position.x)
        {
            speed = -3;
        }
        // Change direction when reaching the right stop point
        else if (transform.position.x >= rightStop.transform.position.x)
        {
            speed = 3;
        }
    }
}
