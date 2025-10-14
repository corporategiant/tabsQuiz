using UnityEngine;

public class lastLevelMenuSwitch : MonoBehaviour
{
    public GameObject AddLevelButton;
    public GameObject AddEndingButton;
    public int currentLevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SwitchLastLevelMenu()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");

        if (currentLevel <= 5)
        {
            AddLevelButton.SetActive(true);
            AddEndingButton.SetActive(false);
        }

        if (currentLevel == 5)
        {
            AddLevelButton.SetActive(false);
            AddEndingButton.SetActive(true);
        }
    }


}
