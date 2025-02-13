using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 playerMovement = new Vector3(movement.x, 0, movement.y);
        rb.AddForce(playerMovement * playerSpeed);
    }
}
