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
        else
        {
            PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel") + 1);
            SceneToLoad = "SceneA";
        }
    }

    public void LoadNextScene()
    {
        if (PlayerPrefs.GetInt("currentLevel")==4)
        {
            SceneManager.LoadScene("SceneB");
        }
        else 
        {
        SceneManager.LoadScene(SceneToLoad);
        }
    }


}
