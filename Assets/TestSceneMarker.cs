using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneMarker : MonoBehaviour
{
    public GameObject LoadOptions;
    public GameObject Question1;
    public GameObject TestLevelNextLevel;
    public GameObject TestPublish;
    public GameObject Test;
    public GameObject Publish;
    public String SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("NewQuiz") == 1)
        {
            LoadOptions.SetActive(false);
            Question1.SetActive(true);

        }
        if (PlayerPrefs.GetInt("TestLocal") == 1)
        {

            if (PlayerPrefs.GetInt("Level") <= 4)
            {
                LoadOptions.SetActive(false);
                TestLevelNextLevel.SetActive(true);
                TestPublish.SetActive(false);
                Test.SetActive(true);
                Publish.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Level") == 4)
            {
                LoadOptions.SetActive(false);
                TestLevelNextLevel.SetActive(false);
                TestPublish.SetActive(true);
                Test.SetActive(true);
                Publish.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("TestPublished") == 1)
        {
            LoadOptions.SetActive(false);
            TestLevelNextLevel.SetActive(false);
            TestPublish.SetActive(true);
            Test.SetActive(false);
            Publish.SetActive(true);
        }
    }

    public void TestLocal()
    {
        PlayerPrefs.SetInt("TestLocal", 1);
        PlayerPrefs.SetInt("TestPublished", 0);
        PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("Level"));
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

    public void TestPublished()
    {
        PlayerPrefs.SetInt("TestPublished", 1);
        PlayerPrefs.SetInt("TestLocal", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }


}
