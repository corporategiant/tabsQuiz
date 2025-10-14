using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneToLoad;
    public int NumberOfLevels;
    public int currentLevel;
    public string username;
    public string StudentID;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        NumberOfLevels = PlayerPrefs.GetInt(username + StudentID + "NumberOfLevels");
        currentLevel = PlayerPrefs.GetInt("currentLevel");

        // if (PlayerPrefs.GetInt("TestLocal") == 1)
        // {
        //     SceneToLoad = "UserInputScreen";
        // }
        // if (PlayerPrefs.GetInt("TestPublished") == 1)
        // {
        //     PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel"));
        //     SceneToLoad = "SceneA";
        // }
        // else
        // {
        //     PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel"));
        //     SceneToLoad = "SceneA";
        // }
    }

    public void LoadNextScene()
    {
        if (PlayerPrefs.GetInt("currentLevel") == NumberOfLevels)
        {
            SceneManager.LoadScene("SceneB");
        }
        else 
        {
            currentLevel++;
            PlayerPrefs.SetInt("currentLevel",currentLevel);

            SceneManager.LoadScene("SceneA");
        }
    }


}
