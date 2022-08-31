using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyForward : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Create vector to move at speed along local z axis
        Vector3 vector = new Vector3(0, 0, speed);

        // Normalize it to the frame rate
        vector *= Time.deltaTime;

        // Translate by this amount locally
        transform.Translate(vector);
    }
}
