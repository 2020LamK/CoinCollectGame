using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Rotate by spinSpeed around local y axis each second
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
