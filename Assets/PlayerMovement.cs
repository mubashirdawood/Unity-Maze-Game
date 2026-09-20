using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;
    private Vector3 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        // Normal physics Rigidbody
        rb.isKinematic = false;

        // We don't want the player falling
        rb.useGravity = false;

        // Keep the player at the same height and prevent rotation
        rb.constraints =
            RigidbodyConstraints.FreezePositionY |
            RigidbodyConstraints.FreezeRotation;
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // X = left/right
        // Z = forward/backward
        // Y = fixed
        movement = new Vector3(horizontal, 0f, vertical).normalized;
    }

    private void FixedUpdate()
    {
        Vector3 newPosition =
            rb.position + movement * speed * Time.fixedDeltaTime;

        rb.MovePosition(newPosition);
    }
}