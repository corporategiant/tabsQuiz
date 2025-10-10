using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneMarker : MonoBehaviour
{
    public GameObject LoadOptions;
    public GameObject Question1;
    public GameObject TestLevelNextLevel;
    public GameObject Published;
    public String SceneToLoad;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("NewQuiz") == 1)
        {
            LoadOptions.SetActive(false);
            Question1.SetActive(true);

        }
        else if (PlayerPrefs.GetInt("TestQuiz") == 1)
        {
            LoadOptions.SetActive(false);
            TestLevelNextLevel.SetActive(true);
            Published.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("PlayPublished") == 1)
        {
            LoadOptions.SetActive(false);
            TestLevelNextLevel.SetActive(false);
            Published.SetActive(true);
        }
        else 
        {
            LoadOptions.SetActive(true);
            TestLevelNextLevel.SetActive(false);
            Published.SetActive(false);

        }
    }

    public void NewQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 1);
        PlayerPrefs.SetInt("TestQuiz", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
    }
    public void TestLocal()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("TestQuiz", 1);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("Level"));
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

    public void PlayPublished()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayPublished", 1);
        PlayerPrefs.SetInt("TestQuiz", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }


}
