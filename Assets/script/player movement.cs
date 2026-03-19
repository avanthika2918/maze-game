using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Move Forward / Backward
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        Vector3 moveDirection = transform.forward * move;
        controller.Move(moveDirection);

        // Rotate Left / Right
        float rotate = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotate);

        // Gravity
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
