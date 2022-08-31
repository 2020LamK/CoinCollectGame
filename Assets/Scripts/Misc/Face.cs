using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public float tx = 0, ty = 0, tz = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(new Vector3(tx, ty, tz));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
