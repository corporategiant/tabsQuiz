using UnityEngine;

public class selectCorrect : MonoBehaviour
{
    public int Level;
    public GameObject TabAO;
    public GameObject TabAX;
    public GameObject TabBO;
    public GameObject TabBX;
    public GameObject TabCO;
    public GameObject TabCX;
    public int QuestionNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Level = PlayerPrefs.GetInt("currentLevel");
        Debug.Log("Level" + Level + "CorrectAnswer" + QuestionNumber + " = " + PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber));
        if (PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber) == 1)
        {
            TabAO.SetActive(true);
            TabBX.SetActive(true);
            TabCX.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber) == 2)
        {
            TabAX.SetActive(true);
            TabBO.SetActive(true);
            TabCX.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer"+QuestionNumber) == 3)
        {
            TabAX.SetActive(true);
            TabBX.SetActive(true);
            TabCO.SetActive(true);
        }
    }


}
