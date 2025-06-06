using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // We marked this as "Fixed"Update because we
    // are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // evens out if a computer has High or low Frame
        
    }
}
