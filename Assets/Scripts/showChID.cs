using UnityEngine;

public class showChID : MonoBehaviour
{
    public string username;
    public string StudentID;
    public int chID;
    public int Level;

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        Level = PlayerPrefs.GetInt("currentLevel");
    }

    void Update()
    {
        chID = PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "ChID");
        Level = PlayerPrefs.GetInt("currentLevel");
    }
}
