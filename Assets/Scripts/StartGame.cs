using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject HomeScreen;
    public GameObject LevelsScreen;
    public GameObject LevelsScreen2;
    public GameObject OptionsScreen;
    public AudioSource buttonPlay;
    public void PlayButtonClicked()
    {
        buttonPlay.Play();
        LevelsScreen.SetActive(true);
        HomeScreen.GetComponent<Animator>().SetBool("PlayButtonClicked", true);
        //Invoke("LoadScene", 0.2f);

    }
    public void LevelsScreenClosed()
    {
        buttonPlay.Play();
        HomeScreen.GetComponent<Animator>().SetBool("PlayButtonClicked", false);
        LevelsScreen.SetActive(true);
        //Invoke("LoadScene", 0.2f);

    }
    public void LevelsScreenNextPageRequested()
    {
        buttonPlay.Play();
        HomeScreen.GetComponent<Animator>().SetBool("LevelsPage2Clicked", true);
        LevelsScreen2.SetActive(true);
    } 
    public void LevelsScreenNextPageClosed()
    {
        buttonPlay.Play();
        HomeScreen.GetComponent<Animator>().SetBool("LevelsPage2Clicked", false);
       // LevelsScreen2.SetActive(true);
    }
    public void OptionsButtonCLicked()
    {
        buttonPlay.Play();
        OptionsScreen.SetActive(true);
        HomeScreen.GetComponent<Animator>().SetBool("OptionsButtonClicked",true);
    }public void OptionsScreenClosed()
    {
        buttonPlay.Play();
        // OptionsScreen.SetActive(true);
        HomeScreen.GetComponent<Animator>().SetBool("OptionsButtonClicked",false);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Levels");
        Invoke("LoadScene", 0.2f);
    }
    public void QuiteGame()
    {
        buttonPlay.Play();


        Application.Quit();
    }
}
