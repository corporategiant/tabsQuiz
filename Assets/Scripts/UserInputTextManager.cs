using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class UserInputTextManager : MonoBehaviour
{
    public int Level;
    //public GameObject UserInput;
    public TextMeshProUGUI LevelText;
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
    public GameObject chSelect3D;
    public GameObject ErrorMessage;
    public bool lastPanel;
    public int QuestionNumber;
    public string SceneToLoad;
    public bool CorrectAnswerSelected;



    public void Start()
    {
        Level = PlayerPrefs.GetInt("currentLevel");
        LevelText.text = "Level " + Level;
    }
    public void LoadQuiz()
    {
        Level = PlayerPrefs.GetInt("currentLevel");
        LevelText.text = "Level " + Level;
        string savedText = PlayerPrefs.GetString("Level" + Level + "Question" + QuestionNumber);
        Debug.Log("Loaded Text" + savedText);
        InputQ.text = savedText;
        InputA.text = PlayerPrefs.GetString("Level" + Level + "Answer" + QuestionNumber + "A");
        InputB.text = PlayerPrefs.GetString("Level" + Level + "Answer" + QuestionNumber + "B");
        InputC.text = PlayerPrefs.GetString("Level" + Level + "Answer" + QuestionNumber + "C");
        if (PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber) == 1)
        {
            oBoxA.SetActive(true);
            oBoxB.SetActive(false);
            oBoxC.SetActive(false);
            CorrectAnswerSelected = true;
        }
        else if (PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber) == 2)
        {
            oBoxA.SetActive(false);
            oBoxB.SetActive(true);
            oBoxC.SetActive(false);
            CorrectAnswerSelected = true;
        }
        else if (PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber) == 3)
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
            PlayerPrefs.SetString("Level" + Level + "Question" + QuestionNumber, TextQ.text);
            PlayerPrefs.SetString("Level" + Level + "Answer" + QuestionNumber + "A", TextA.text);
            PlayerPrefs.SetString("Level" + Level + "Answer" + QuestionNumber + "B", TextB.text);
            PlayerPrefs.SetString("Level" + Level + "Answer" + QuestionNumber + "C", TextC.text);
            PlayerPrefs.Save();
            Debug.Log("Text Saved" + PlayerPrefs.GetString("Level" + Level + "Question" + QuestionNumber));
            Debug.Log(PlayerPrefs.GetString("Level" + Level + "Answer" + QuestionNumber + "A"));
            Debug.Log(PlayerPrefs.GetString("Level" + Level + "Answer" + QuestionNumber + "B"));
            Debug.Log(PlayerPrefs.GetString("Level" + Level + "Answer" + QuestionNumber + "C"));
            ThisPanel.SetActive(false);
            NextPanel.SetActive(true);
            if (lastPanel == true)
            {
                envSelect3D.SetActive(true);
            }
        }
        else
        {
            ErrorMessage.SetActive(true);
        }

    }

    public void SaveCorrectAnswerA()
    {
        PlayerPrefs.SetInt("Level" + Level + "CorrectAnswer" + QuestionNumber, 1);
        Debug.Log("Level" + Level + QuestionNumber + "Correct Answer Saved = " + PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber));
        oBoxA.SetActive(true);
        oBoxB.SetActive(false);
        oBoxC.SetActive(false);
        CorrectAnswerSelected = true;
    }

    public void SaveCorrectAnswerB()
    {
        PlayerPrefs.SetInt("Level" + Level + "CorrectAnswer" + QuestionNumber, 2);
        Debug.Log("Level" + Level + QuestionNumber + "Correct Answer Saved = " + PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber));

        oBoxA.SetActive(false);
        oBoxB.SetActive(true);
        oBoxC.SetActive(false);
        CorrectAnswerSelected = true;
    }
    public void SaveCorrectAnswerC()
    {
        PlayerPrefs.SetInt("Level" + Level + "CorrectAnswer" + QuestionNumber, 3);
        Debug.Log("Level" + Level + QuestionNumber + "Correct Answer Saved = " + PlayerPrefs.GetInt("Level" + Level + "CorrectAnswer" + QuestionNumber));

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
