using UnityEngine;
using UnityEngine.SceneManagement;

public class NewQuiz : MonoBehaviour
{
    public GameObject NewQuizLoadQuiz;
    public string SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    public void ResetQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 1);
        PlayerPrefs.SetInt("TestLocal", 0);
        PlayerPrefs.SetInt("TestPublished", 0);
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

        public void LoadQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("TestLocal", 0);
        PlayerPrefs.SetInt("TestPublished", 0);
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
