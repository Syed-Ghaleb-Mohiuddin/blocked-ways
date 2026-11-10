using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{


    public Rigidbody rb;

    bool isMovingUp = false;
    bool isMovingDown = false;

    public bool onStay = true;
    public bool onExit = false;

    public float JumpForce = 300;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && onStay || isMovingUp && onStay)
        {
            rb.AddForce(0, 10f, 0.5f, ForceMode.Impulse);
            onStay = false;
        }
        // if (isMovingUp && onStay)
        // {
        //     rb.AddForce(0, 30.30f, 0.5f, ForceMode.Impulse);
        //     onStay = false;
        // }
        ///////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.S) && onExit || isMovingDown && onExit == false)
        {
            rb.AddForce(0, -2f, 0.5f, ForceMode.Impulse);
            onExit = true;


        }
        // if (isMovingDown && onExit == false)
        // {
        //     rb.AddForce(0, -10f, 0.5f, ForceMode.Impulse);
        //     onExit = true;


        // }

    }

    public void TriggerUp(bool canMove)
    {
        isMovingUp = canMove;
    }
    public void TriggerDown(bool canMove)
    {
        isMovingDown = canMove;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "GroundTag")
        {
            Debug.Log("Ground");
            onStay = true;

        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "GroundTag")
        {
            Debug.Log("Ground");
            onExit = false;

        }
    }


}
