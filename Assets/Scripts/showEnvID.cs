using UnityEngine;

public class showEnvID : MonoBehaviour
{
    public string username;
    public string StudentID;
    public int envID;
    public int Level;
    public int NumberofLevels;

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        Level = PlayerPrefs.GetInt("currentLevel");
    }

    void Update()
    {
        envID = PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID");
        Level = PlayerPrefs.GetInt("currentLevel");
        NumberofLevels = PlayerPrefs.GetInt(username + StudentID + "NumberOfLevels");
    }
}
