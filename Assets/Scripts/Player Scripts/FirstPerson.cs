using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public float senseH = 9.0f;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Point the object in the direction of the mouse
        transform.Rotate(0, Input.GetAxis("Mouse X") * senseH, 0);

        // Move forward if left mouse button down
        if (Input.GetMouseButton(0))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
