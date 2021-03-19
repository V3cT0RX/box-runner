using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    [SerializeField] float forwardForce = 1000f;
    [SerializeField] float sideForce = 400f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
