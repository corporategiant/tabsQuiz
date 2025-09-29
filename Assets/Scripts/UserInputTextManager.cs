using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class UserInputTextManager : MonoBehaviour
{

    public TextMeshProUGUI TextQ;
    public TextMeshProUGUI PlaceholderTextQ;
    public TextMeshProUGUI TextA;
    public TextMeshProUGUI TextB;
    public TextMeshProUGUI TextC;
    public TMP_InputField InputQ;
    public TMP_InputField InputA;
    public TMP_InputField InputB;
    public TMP_InputField InputC;
    public GameObject ThisPanel;
    public GameObject PreviousPanel;
    public GameObject NextPanel;
    public GameObject xBoxA;
    public GameObject xBoxB;
    public GameObject xBoxC;
    public GameObject oBoxA;
    public GameObject oBoxB;
    public GameObject oBoxC;
    public GameObject envSelect3D;
    public GameObject ErrorMessage;
    public bool lastPanel;
    public int QuestionNumber;
    public string SceneToLoad;
    public bool CorrectAnswerSelected;



    
    public void LoadQuiz()
    {
        string savedText = PlayerPrefs.GetString("Question" + QuestionNumber);
        Debug.Log("Loaded Text" + savedText);
        InputQ.text = savedText;
        InputA.text = PlayerPrefs.GetString("Answer" + QuestionNumber + "A");
        InputB.text = PlayerPrefs.GetString("Answer" + QuestionNumber + "B");
        InputC.text = PlayerPrefs.GetString("Answer" + QuestionNumber + "C");
        if (PlayerPrefs.GetInt("CorrectAnswer" + QuestionNumber) == 1)
        {
            oBoxA.SetActive(true);
            oBoxB.SetActive(false);
            oBoxC.SetActive(false);
            CorrectAnswerSelected = true;
        }
        else if (PlayerPrefs.GetInt("CorrectAnswer" + QuestionNumber) == 2)
        {
            oBoxA.SetActive(false);
            oBoxB.SetActive(true);
            oBoxC.SetActive(false);
            CorrectAnswerSelected = true;
        }
        else if (PlayerPrefs.GetInt("CorrectAnswer" + QuestionNumber) == 3)
        {
            oBoxA.SetActive(false);
            oBoxB.SetActive(false);
            oBoxC.SetActive(true);
            CorrectAnswerSelected = true;
        }

    }
    public void SubmitInput()
    {
        if (CorrectAnswerSelected == true)
        {
            PlayerPrefs.SetString("Question" + QuestionNumber, TextQ.text);
            PlayerPrefs.SetString("Answer" + QuestionNumber + "A", TextA.text);
            PlayerPrefs.SetString("Answer" + QuestionNumber + "B", TextB.text);
            PlayerPrefs.SetString("Answer" + QuestionNumber + "C", TextC.text);
            PlayerPrefs.Save();
            Debug.Log("Text Saved" + PlayerPrefs.GetString("Question" + QuestionNumber));
            Debug.Log(PlayerPrefs.GetString("Answer" + QuestionNumber + "A"));
            Debug.Log(PlayerPrefs.GetString("Answer" + QuestionNumber + "B"));
            Debug.Log(PlayerPrefs.GetString("Answer" + QuestionNumber + "C"));
            ThisPanel.SetActive(false);
            NextPanel.SetActive(true);
            if (lastPanel == true)
            {
                envSelect3D.SetActive(true);
                //SceneManager.LoadSceneAsync(SceneToLoad);
            }
        }
        else
        {
            ErrorMessage.SetActive(true);
        }

    }

    public void SaveCorrectAnswerA()
    {
        PlayerPrefs.SetInt("CorrectAnswer" + QuestionNumber, 1);
        Debug.Log(QuestionNumber + "Correct Answer Saved = " + PlayerPrefs.GetInt("CorrectAnswer" + QuestionNumber));
        oBoxA.SetActive(true);
        oBoxB.SetActive(false);
        oBoxC.SetActive(false);
        CorrectAnswerSelected = true;
    }

    public void SaveCorrectAnswerB()
    {
        PlayerPrefs.SetInt("CorrectAnswer" + QuestionNumber, 2);
        Debug.Log(QuestionNumber + "Correct Answer Saved = " + PlayerPrefs.GetInt("CorrectAnswer" + QuestionNumber));

        oBoxA.SetActive(false);
        oBoxB.SetActive(true);
        oBoxC.SetActive(false);
        CorrectAnswerSelected = true;
    }
    public void SaveCorrectAnswerC()
    {
        PlayerPrefs.SetInt("CorrectAnswer" + QuestionNumber, 3);
        Debug.Log(QuestionNumber + "Correct Answer Saved = " + PlayerPrefs.GetInt("CorrectAnswer" + QuestionNumber));

        oBoxA.SetActive(false);
        oBoxB.SetActive(false);
        oBoxC.SetActive(true);
        CorrectAnswerSelected = true;
    }

    public void PreviousQuestion()
    {
        ThisPanel.SetActive(false);
        PreviousPanel.SetActive(true);
    }
    
}
