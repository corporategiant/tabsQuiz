using UnityEngine;
using UnityEngine.SceneManagement;

public class NewQuiz : MonoBehaviour
{
    public string SceneToLoad;
    public string username;
    public string StudentID;

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");

    }

    public void ResetQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 1);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        PlayerPrefs.SetInt(username + StudentID + "NumberOfLevels", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

        public void LoadQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
