using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1000.0f; // Movement speed in units per second
    [SerializeField] private Rigidbody2D rb; // Reference to the Rigidbody component

    void Start()
    {
        // Check if Rigidbody component exists
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        // Get horizontal and vertical input from the keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector based on input
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Apply movement to the Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}

