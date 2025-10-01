using UnityEngine;

public class SwitchSubmitLastLevel : MonoBehaviour
{
    public GameObject ButtonSubmitNext;
    public GameObject ButtonSubmitLast;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CheckLast()
    {
        if (PlayerPrefs.GetInt("Level") <= 4)
        {
            ButtonSubmitNext.SetActive(true);
            ButtonSubmitLast.SetActive(false);

        }
        if (PlayerPrefs.GetInt("Level") == 4)
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
