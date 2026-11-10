using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private AudioSource CarSound;

    void OnTriggerEnter()
    {
        CarSound = GameObject.FindGameObjectWithTag("Car Sound").gameObject.GetComponent<AudioSource>();
        CarSound.Stop();

            if (SceneManager.GetActiveScene().buildIndex == 41) 
            {
                Debug.Log("You Completed ALL Levels");

                //Show Win Screen or Somethin.
            }
            else
            {
                //Move to next level
                gameManager.completeLevel();
            Debug.Log("LevelA T " + PlayerPrefs.GetInt("levelAt"));

            //Setting Int for Index
            if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("LevelA T" + PlayerPrefs.GetInt("levelAt"));
                }
            }
        
 
    }
}
