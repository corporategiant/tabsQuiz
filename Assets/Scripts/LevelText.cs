using UnityEngine;
using TMPro;

public class SetLevelText : MonoBehaviour
{
    public TextMeshProUGUI LevelText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelText.text = "Level " + PlayerPrefs.GetInt("Level");
    }

    public void StartSetLevelText()
    {
        LevelText.text = "Level " + PlayerPrefs.GetInt("Level");
    }


}
