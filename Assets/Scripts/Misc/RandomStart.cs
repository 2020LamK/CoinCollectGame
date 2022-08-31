using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j")) {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2.5f, 2.5f);
            float z = Random.Range(-5f, 5f);
            
            transform.position = new Vector3(x, y, z);
        }
    }
}
