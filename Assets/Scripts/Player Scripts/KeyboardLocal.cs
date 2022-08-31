using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardLocal : MonoBehaviour
{
    public float forwardSpeed = 1.0f;
    public float turnSpeed = 30.0f;

    // Update is called once per frame
    void Update()
    {
        // Move forward on local z axis on Up Arrow
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, forwardSpeed * Time.deltaTime));
        }

        // Rotate left or right around local y axis
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
    }
}
