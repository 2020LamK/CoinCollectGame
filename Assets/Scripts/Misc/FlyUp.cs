using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyUp : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Create vector to move at speed upward
        Vector3 vector = new Vector3(0, speed, 0);

        // Normalize it to the frame rate
        vector *= Time.deltaTime;

        // Translate by this amount along global y axis
        transform.Translate(vector, Space.World);
    }
}
