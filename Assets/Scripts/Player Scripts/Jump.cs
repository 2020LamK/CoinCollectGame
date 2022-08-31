using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce = 10.0f;
    Rigidbody rb;
    bool onground;
    Animator myAnimator; // Link to animation controller

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onground)
        {
            rb.AddForce(new Vector3(0, jumpforce, 0), ForceMode.Impulse);

            myAnimator.SetBool("jumping", true);
        }

        if (Input.GetKeyUp(KeyCode.Space) && !onground) 
        {
            myAnimator.SetBool("jumping", false);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        GameObject g = c.gameObject;
        if (g.CompareTag("Ground"))
        {
            onground = true;
        }
    }

    void OnCollisionExit(Collision c)
    {
        GameObject g = c.gameObject;
        if (g.CompareTag("Ground"))
        {
            onground = false;
        }
    }
}
