using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBCollision : MonoBehaviour
{


    public Movement movement;
    private AudioSource CarSound;
    private AudioSource CarCrashSound;
    void Start()
    {
        CarSound = GameObject.FindGameObjectWithTag("Car Sound").gameObject.GetComponent<AudioSource>();
        CarCrashSound = GameObject.FindGameObjectWithTag("CarCrashSound").gameObject.GetComponent<AudioSource>();
        CarCrashSound.Stop();


    }
    // public Jump jump;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            CarSound.Stop();
            CarCrashSound.Play();
            //  jump.enabled = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
        if (collision.collider.tag == "Terrain")
        {
            CarSound.Stop();
            CarCrashSound.Play();

            //  jump.enabled = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }

    }


}
