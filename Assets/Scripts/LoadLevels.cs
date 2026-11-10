using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    public string levelName = "Level1";
    public GameObject levelLoader;
    public AudioSource buttonPlay;

    public void LoadScene(int sceneIndex)
    {
       
        //levelLoader.Get LoadGame(sceneIndex);
        levelLoader.GetComponent<LevelDoder>().LoadGame(sceneIndex);
        buttonPlay.Play();
        Invoke("loadgameLevel", 0.2f);

    }
    public void loadgameLevel()
    {
        SceneManager.LoadScene(levelName);

    }
    public void LevelLoadConnection(int sceneIndex)
    {
    }
}
