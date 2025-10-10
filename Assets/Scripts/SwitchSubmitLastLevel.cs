using UnityEngine;

public class SwitchSubmitLastLevel : MonoBehaviour
{
    public GameObject ButtonSubmitNext;
    public GameObject ButtonSubmitLast;

    public int NumberOfLevels;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CheckLast()
    {
        if (PlayerPrefs.GetInt("Level") <= NumberOfLevels)
        {
            ButtonSubmitNext.SetActive(true);
            ButtonSubmitLast.SetActive(false);

        }
        if (PlayerPrefs.GetInt("Level") == NumberOfLevels)
        {
            ButtonSubmitNext.SetActive(false);
            ButtonSubmitLast.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
