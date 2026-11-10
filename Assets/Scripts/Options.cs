using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public Canvas canvas;
    public Canvas optionsCanvas;
    public AudioSource buttonPlay;

    void Start()
    {
        optionsCanvas.enabled = false;
    }

    void Update()
    {

    }
    public void triggerClick(bool clicked)
    {
        buttonPlay.Play();
        canvas.enabled = false;
        optionsCanvas.enabled = true;
    }

    public void triggerBack(bool clicked)
    {
        buttonPlay.Play();
        canvas.enabled = true;
        optionsCanvas.enabled = false;
        Debug.Log("clicked");
    }
}
