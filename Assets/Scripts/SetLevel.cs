using UnityEngine;

public class SetLevel : MonoBehaviour
{
    public int currentLevel;

    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
    }

    public void SetLevel1()
    {
        currentLevel = 1;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
    }

    public void LevelUp()
    {
        currentLevel++;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        Debug.Log("currentLevel = " + currentLevel);

    }
}
