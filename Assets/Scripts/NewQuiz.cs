using UnityEngine;
using UnityEngine.SceneManagement;

public class NewQuiz : MonoBehaviour
{
    public GameObject NewQuizLoadQuiz;
    public GameObject Question1;
    public string SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("NewQuiz") == 1)
        {
            NewQuizLoadQuiz.SetActive(false);
            Question1.SetActive(true);
            PlayerPrefs.SetInt("NewQuiz", 0);
        }
    }

    public void ResetQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
