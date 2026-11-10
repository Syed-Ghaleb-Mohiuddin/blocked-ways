using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class LevelDoder : MonoBehaviour
{
    public GameObject LevelsScreen;
    public GameObject loadingBar;
    public Slider slider;
    public Text progressText;
    public GameObject PauseScreen;

    void Start()
    {
        slider = loadingBar.GetComponentInChildren<Slider>();
        progressText = slider.GetComponentInChildren<Text>();
        loadingBar.SetActive(false);
        
        if(SceneManager.GetActiveScene().buildIndex==0)
        {
            loadingBar.SetActive(true);

            LoadGame(1);
        }
    }
    public void LoadGame(int sceneIndex)
    {
        loadingBar.SetActive(true);
        LevelsScreen.SetActive(false);
        Debug.Log("Loading level: " + sceneIndex);
        if (SceneManager.GetActiveScene().buildIndex > 1)
        {
            PauseScreen = GameObject.Find("PauseCanvas");
            PauseScreen.SetActive(false);
        }
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    public IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingBar.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            progressText.text = progress.ToString() + "00%";
            yield return null;
        }
    }
}
