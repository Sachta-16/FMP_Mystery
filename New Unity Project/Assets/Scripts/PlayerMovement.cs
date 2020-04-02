using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;
    public Animator animator;

    public void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);

        if (Input.GetKey("w"))
        {
                animator.SetInteger("Direction", (2));
        }
        else if (Input.GetKeyUp("w"))
        {
            animator.SetInteger("Direction", (5));
        }

        if (Input.GetKey("s"))
        {
            animator.SetInteger("Direction", (1));
        }
        else if (Input.GetKeyUp("s"))
        {
            animator.SetInteger("Direction", (0));
        }

        if (Input.GetKey("d"))
        {
            animator.SetInteger("Direction", (3));
        }
        else if (Input.GetKeyUp("d"))
        {
            animator.SetInteger("Direction", (0));
        }

        if (Input.GetKey("a"))
        {
            animator.SetInteger("Direction", (4));
        }
        else if (Input.GetKeyUp("a"))
        {
            animator.SetInteger("Direction", (0));
        }
    }
}
