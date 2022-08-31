using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light myLight;
    bool on = true;
    public int flicker = 20;
    public float power = 5.0f;
    public float rate = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();    
    }

    // Update is called once per frame
    void Update()
    {
        // turn on light when pressed 1
        if (Input.GetKeyDown("1"))
        {
            myLight.intensity = power;
            on = true;
        }

        // turn off light when pressed 0
        if (Input.GetKeyDown("0"))
        {
            myLight.intensity = 0.0f;
            on = false;
        }

        if (on)
        {
            // decrease power when on
            power -= rate;

            // flicker the light
            if (Random.Range(0, flicker) == 0)
            {
                myLight.intensity = 0.0f;
            }
            else
            {
                myLight.intensity = power;
            }
        }
    }
}
