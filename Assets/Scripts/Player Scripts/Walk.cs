using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    Animator myAnimator; // Link to animation controller

    // Start is called before the first frame update
    void Start()
    {
        // Set that link at the beginning
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // transition to walking animation when any of these keys are pressed
        // by setting the walking parameter to true
        if (Input.GetKeyDown(KeyCode.LeftArrow) || 
            Input.GetKeyDown(KeyCode.RightArrow) ||
            Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown("w") ||
            Input.GetKeyDown("a") ||
            Input.GetKeyDown("d"))
        {
            myAnimator.SetBool("walking", true);
        }

        // Transition to idle animation when any of these keys are released
        // by setting the walking parameter to true
        if (Input.GetKeyUp(KeyCode.LeftArrow) ||
            Input.GetKeyUp(KeyCode.RightArrow) ||
            Input.GetKeyUp(KeyCode.UpArrow) ||
            Input.GetKeyUp("w") ||
            Input.GetKeyUp("a") ||
            Input.GetKeyUp("d"))
        {
            myAnimator.SetBool("walking", false);
        }
    }
}
