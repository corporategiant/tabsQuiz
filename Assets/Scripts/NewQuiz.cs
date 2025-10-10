using UnityEngine;
using UnityEngine.SceneManagement;

public class NewQuiz : MonoBehaviour
{
    public string SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    public void ResetQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 1);
        PlayerPrefs.SetInt("TestLocal", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

        public void LoadQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("TestLocal", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
