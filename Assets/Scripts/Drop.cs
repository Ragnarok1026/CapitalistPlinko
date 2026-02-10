using UnityEngine;
using UnityEngine.InputSystem;

public class Drop : MonoBehaviour
{
    public bool hasDropped = false; 
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Slider>().enabled = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
    public void OnDrop(InputValue value)
    {
        DropInput(value.isPressed);
    }
    public void DropInput(bool DroppedState)
    {
        hasDropped = DroppedState;
    }
}
