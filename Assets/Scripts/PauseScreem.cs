using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreem : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public AudioSource buttonPlay;
    private AudioSource CarSound;
    public LevelDoder levelDoder;

    bool isPaused = false;
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1f;
            //   buttonPlay.Play();
            isPaused = false;

        }
        else
        {
            Time.timeScale = 0f;
            buttonPlay.Play();
            CarSound.Stop();
            isPaused = true;
            canvas1.enabled = false;
            canvas2.enabled = true;
        }
    }
    void Start()
    {
        canvas2 = GameObject.Find("PauseCanvas").GetComponent<Canvas>();
        CarSound = GameObject.FindGameObjectWithTag("Car Sound").gameObject.GetComponent<AudioSource>();
        canvas2.enabled = false;
        canvas1.enabled =true;
    }

    public void triggerResume()
    {
        Time.timeScale = 1f;
        buttonPlay.Play();
        isPaused = false;
        canvas1.enabled = true;
        canvas2.enabled = false;
        CarSound.Play();


    }
    public void triggerNext()
    {
        Time.timeScale = 1f;

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        levelDoder.LoadGame(SceneManager.GetActiveScene().buildIndex + 1);
        buttonPlay.Play();

    }
    public void triggerRestart()
    {

        Time.timeScale = 1f;
        buttonPlay.Play();
        isPaused = false;
        levelDoder.LoadGame(SceneManager.GetActiveScene().buildIndex);

       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void triggerExit()
    {
        if (levelDoder == null)
        {
            Debug.LogError("levelDoder is null in exiteToLevels");
            return;
        }
        buttonPlay.Play();
        Invoke("exiteToLevels", 0.2f);
        Time.timeScale = 1f;

    }
    public void exiteToLevels()
    {
       
        Debug.Log("exiteTolevel");
        Time.timeScale = 1f;
        isPaused = false;
        levelDoder.LoadGame(0);

       // SceneManager.LoadScene("StartGame");
    }
}
//