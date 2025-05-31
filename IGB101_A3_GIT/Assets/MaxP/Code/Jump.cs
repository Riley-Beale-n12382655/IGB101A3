using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class RobotJump : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 8f;
    public float gravity = 20f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private float verticalVelocity = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -1f;  // Keeps grounded when on the floor

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpHeight;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // Replace Vector3.zero with movement if needed later
        moveDirection = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveDirection * Time.deltaTime);
    }
}