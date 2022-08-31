using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyLocalForce : MonoBehaviour
{
    Rigidbody rb; // link to physics component of this object
    public float forwardForce = 10.0f;
    public float spinForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get and store the physics component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(new Vector3(0, 0, forwardForce * Time.deltaTime));
        }

        // Apply torque around local y axis
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddRelativeTorque(new Vector3(0, -spinForce * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddRelativeTorque(new Vector3(0, spinForce * Time.deltaTime, 0));
        }
    }
}
