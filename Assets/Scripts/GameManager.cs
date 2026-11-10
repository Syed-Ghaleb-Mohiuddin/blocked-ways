using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    void Start()
    {
        completeLevelUI.SetActive(false);

    }
    bool gameHasEnded = false;
    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            Invoke("Restart", 2f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void completeLevel()
    {
       
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won!!!");
        Invoke("TimeDelay", 2f);
    }
    void TimeDelay()
    {
        Time.timeScale = 0f;
    }
}
