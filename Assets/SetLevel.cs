using UnityEngine;

public class SetLevel : MonoBehaviour
{
    public int Level;

    void Start()
    {
        Level = PlayerPrefs.GetInt("Level");
    }

    public void SetLevel1()
    {
        Level = 1;
        PlayerPrefs.SetInt("Level", Level);
    }

    public void LevelUp()
    {
        Level++;
        PlayerPrefs.SetInt("Level", Level);
        Debug.Log("Level = " + Level);

    }
}
