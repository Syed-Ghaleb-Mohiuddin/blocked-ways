using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPage : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public AudioSource buttonPlay;

    public bool nextOpen = true;
    void Start()
    {
        canvas2.enabled = false;
        canvas1.enabled = true;
    }
    void Update()
    {
    }
    public void triggerNext(bool next)
    {
        buttonPlay.Play();
        canvas1.enabled = false;
        canvas2.enabled = true;
    }
    public void triggerPrevious(bool previous)
    {
        buttonPlay.Play();
        canvas1.enabled = true;
        canvas2.enabled = false;
        Debug.Log("Clicked");
    }
    public void triggerBack(bool previous)
    {
        buttonPlay.Play();
        Invoke("homeScreen", 0.2f);

    }
    void homeScreen()
    {
        SceneManager.LoadScene("StartGame");
    }
}
