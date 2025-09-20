using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UserInputTextManager : MonoBehaviour
{

    public TextMeshProUGUI TextA;
    public TextMeshProUGUI PlaceholderTextA;
    public TextMeshProUGUI TextA1;
    public TextMeshProUGUI TextA2;
    public TextMeshProUGUI TextA3;
    public GameObject TextBoxA;
    public GameObject TextBoxA1;
    public GameObject TextBoxA2;
    public GameObject TextBoxA3;
    public GameObject SubmitButtonA;
    public GameObject SubmitButtonA1;
    public GameObject SubmitButtonA2;
    public GameObject SubmitButtonA3;
    public GameObject OptionBoxAll;
    public GameObject xBoxA1;
    public GameObject xBoxA2;
    public GameObject xBoxA3;
    public GameObject oBoxA1;
    public GameObject oBoxA2;
    public GameObject oBoxA3;
    public GameObject PreviousA1;
    public GameObject PreviousA2;
    public GameObject PreviousA3;
    public int QuestionNo;
    public string SceneToLoad;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QuestionNo = PlayerPrefs.GetInt("QuestionNo");
        string savedText = PlayerPrefs.GetString(QuestionNo + "TextA");
        Debug.Log("Loaded Text" + savedText);
        TextA.text = savedText;
        TextA1.text = PlayerPrefs.GetString(QuestionNo + "TextA1");
        TextA2.text = PlayerPrefs.GetString(QuestionNo + "TextA2");
        TextA3.text = PlayerPrefs.GetString(QuestionNo + "TextA3");
        PlaceholderTextA.text = ("Enter question" + QuestionNo);
    }
    public void SaveTextALocal()
    {
        PlayerPrefs.SetString(QuestionNo + "TextA", TextA.text);
        PlayerPrefs.Save();
        Debug.Log("Text Saved" + PlayerPrefs.GetString(QuestionNo + "TextA"));
        TextBoxA.SetActive(false);
        TextBoxA1.SetActive(true);
        SubmitButtonA.SetActive(false);
        SubmitButtonA1.SetActive(true);
        OptionBoxAll.SetActive(true);
        PreviousA1.SetActive(true);

    }
    public void SaveTextA1Local()
    {
        PlayerPrefs.SetString(QuestionNo + "TextA1", TextA1.text);
        TextBoxA1.SetActive(false);
        TextBoxA2.SetActive(true);
        SubmitButtonA1.SetActive(false);
        SubmitButtonA2.SetActive(true);
        PreviousA1.SetActive(false);
        PreviousA2.SetActive(true);
    }
    public void SaveTextA2Local()
    {
        PlayerPrefs.SetString(QuestionNo + "TextA2", TextA2.text);
        TextBoxA2.SetActive(false);
        TextBoxA3.SetActive(true);
        SubmitButtonA2.SetActive(false);
        SubmitButtonA3.SetActive(true);
        PreviousA2.SetActive(false);
        PreviousA3.SetActive(true);
    }
    public void LoadTextA3Local()
    {
        TextA1.text = PlayerPrefs.GetString(QuestionNo + "TextA1");
        TextA2.text = PlayerPrefs.GetString(QuestionNo + "TextA2");
        TextA3.text = PlayerPrefs.GetString(QuestionNo + "TextA3");
        PlayerPrefs.SetInt("QuestionNo", QuestionNo + 1);

        if (PlayerPrefs.GetInt("QuestionNo") == 5)
        {
            SceneManager.LoadSceneAsync("SceneA");
        }
        else
        {
            SceneManager.LoadSceneAsync("UserInputScreen");
        }

    }

    public void SaveCorrectAnswerA1()
    {
        PlayerPrefs.SetInt(QuestionNo + "CorrectAnswerA1", 1);
        oBoxA1.SetActive(true);
        oBoxA2.SetActive(false);
        oBoxA3.SetActive(false);

    }

    public void SaveCorrectAnswerA2()
    {
        PlayerPrefs.SetInt(QuestionNo + "CorrectAnswerA2", 2);
        oBoxA1.SetActive(false);
        oBoxA2.SetActive(true);
        oBoxA3.SetActive(false);
    }
    public void SaveCorrectAnswerA3()
    {
        PlayerPrefs.SetInt(QuestionNo + "CorrectAnswerA3", 3);
        oBoxA1.SetActive(false);
        oBoxA2.SetActive(false);
        oBoxA3.SetActive(true);
    }

    public void PreviousFieldA1()
    {
        TextBoxA.SetActive(true);
        TextBoxA1.SetActive(false);
        SubmitButtonA.SetActive(true);
        SubmitButtonA1.SetActive(false);
        OptionBoxAll.SetActive(false);
        PreviousA1.SetActive(false);
    }

    public void PreviousFieldA2()
    {
        TextBoxA1.SetActive(true);
        TextBoxA2.SetActive(false);
        SubmitButtonA1.SetActive(true);
        SubmitButtonA2.SetActive(false);
        PreviousA2.SetActive(false);
    }

    public void PreviousFieldA3()
    {
        TextBoxA2.SetActive(true);
        TextBoxA3.SetActive(false);
        SubmitButtonA2.SetActive(true);
        SubmitButtonA3.SetActive(false);
        PreviousA3.SetActive(false);
    }


}
