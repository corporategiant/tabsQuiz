using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneToLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("TestLocal") == 1)
        {
            SceneToLoad = "UserInputScreen";
        }
        if (PlayerPrefs.GetInt("TestPublished") == 1)
        {
            PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel") + 1);
            SceneToLoad = "SceneA";
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }


}
