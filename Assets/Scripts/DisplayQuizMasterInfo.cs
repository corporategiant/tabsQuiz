using UnityEngine;
using TMPro;

public class DisplayQuizMasterInfo : MonoBehaviour
{

    public TextMeshProUGUI QuizMasterInfoText;


    // Update is called once per frame
    void Update()
    {
        QuizMasterInfoText.text = "Quiz by " + PlayerPrefs.GetString("QuizMasterusername");
    }
}
