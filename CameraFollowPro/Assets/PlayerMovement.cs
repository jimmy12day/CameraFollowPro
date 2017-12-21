//Bin Wei, 12/21/2017
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float jumpSpeed = 10;
    public float forwardSpeed = 0.5f;
    public float backwardSpeed = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //GetKey is good for move smoothly
        if (Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.x >= 0)
                rb.velocity = Vector3.Lerp(rb.velocity, new Vector3(0, rb.velocity.y, rb.velocity.z), 0.1f);
            rb.AddForce(Vector3.left * backwardSpeed, ForceMode.VelocityChange);
        }
        //GetKeyDown is not good to move smoothly
        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.x <= 0)
                rb.velocity = Vector3.Lerp(rb.velocity, new Vector3(0, rb.velocity.y, rb.velocity.z), 0.1f);
            rb.AddForce(Vector3.right * forwardSpeed, ForceMode.VelocityChange);
        }
        //GetKey is not good here because jump should not be smooth like walk and run
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.VelocityChange);
        }

    }
}
