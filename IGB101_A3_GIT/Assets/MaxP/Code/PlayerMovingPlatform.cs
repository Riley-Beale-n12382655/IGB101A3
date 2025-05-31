using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlatformRider : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 platformVelocity = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (platformVelocity != Vector3.zero)
        {
            controller.Move(platformVelocity * Time.deltaTime);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("MovingPlatform"))
        {
            MovingPlatform platform = hit.collider.GetComponent<MovingPlatform>();
            if (platform != null)
            {
                platformVelocity = platform.Velocity;
                return;
            }
        }

        platformVelocity = Vector3.zero;
    }
}
