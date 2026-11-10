using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public bool isMovingLeft = false;
    public bool isMovingRight = false;
    public float ForwardForce = 2000f;
    public float sideForce = 300;    
    private AudioSource CarSound;

    
    public void Start()
    {
        CarSound = GameObject.FindGameObjectWithTag("Car Sound").gameObject.GetComponent<AudioSource>();
        CarSound.Play();
        CarSound.volume = PlayerPrefs.GetFloat("effectsvolume");
    }
    void FixedUpdate()
    {
        CarSound.volume = PlayerPrefs.GetFloat("effectsvolume");
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        movement();
    }
    //////////////////////////////////////////////////////////////////////
    void movement()
    {
        if (Input.GetKey(KeyCode.D) || isMovingLeft)
        {
            left();
        }
        if (Input.GetKey(KeyCode.A) || isMovingRight)
        {
            right();
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    public void TriggerLeft(bool canMove)
    {
        isMovingRight = canMove;
    }
    public void TriggerRight(bool canMove)
    {
        isMovingLeft = canMove;
    }

    ////////////////////////////////////////////////////////////////////////////////////
    void left()
    {
        rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (PlayerPrefs.GetFloat("effectsvolume") != 0f)
        { 
        CarSound.volume = PlayerPrefs.GetFloat("effectsvolume") + 0.5f;
        }
    }
    void right()
    {
        rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (PlayerPrefs.GetFloat("effectsvolume") != 0f)
        {
        CarSound.volume = PlayerPrefs.GetFloat("effectsvolume") + 0.5f;
        }
    }

}
