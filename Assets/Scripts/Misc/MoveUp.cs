using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);

    }
}
