using UnityEngine;

public class SetLevel : MonoBehaviour
{
    public int currentLevel;
    public int NumberOfLevels;

    public string username;
    public string StudentID;

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        currentLevel = PlayerPrefs.GetInt("currentLevel");
    }

    public void SetLevel1()
    {
        currentLevel = 1;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        PlayerPrefs.SetInt(username + StudentID + "NumberOfLevels", currentLevel);
        NumberOfLevels = PlayerPrefs.GetInt(username + StudentID + "NumberOfLevels");
    }

    public void LevelUp()
    {
        currentLevel++;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        PlayerPrefs.SetInt(username + StudentID + "NumberOfLevels", currentLevel);
        NumberOfLevels =  PlayerPrefs.GetInt(username + StudentID + "NumberOfLevels");
        Debug.Log("currentLevel = " + currentLevel + ", Number of Levels = " + NumberOfLevels);
    }
}
