using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Drop : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float horizontal;
    private bool hasDropped = false; 
    private bool isEscaped = false;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(new Vector3 (horizontal, 0, 0) * moveSpeed * Time.deltaTime);
        if (hasDropped)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1f;
            Debug.Log("Dropping the object!");
            hasDropped = false; 
        }
    }
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }
    public void OnDrop(InputValue value)
    {
        // Read drop input
        DropInput(value.isPressed);
    }
    public void MoveInput(Vector2 moveDirection)
    {
        horizontal = moveDirection.normalized.x;
    }
    public void DropInput(bool dropState)
    {
        hasDropped = dropState;
    }

}
