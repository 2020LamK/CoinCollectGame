using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardGlobal : MonoBehaviour
{
    public float speed = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        // Amount to move in x, z dimensions
        float dx = 0;
        float dz = 0;

        // Use wasd keys to determine global movement direction
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            dz = speed;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            dz = -speed;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            dx = -speed;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            dx = speed;
        }

        // Move in global xz plane based on key pressed
        transform.Translate(new Vector3(dx, 0, dz) * Time.deltaTime, Space.World);
    }
}
