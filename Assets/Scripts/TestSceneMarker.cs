using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneMarker : MonoBehaviour
{
    public GameObject LoadOptions;
    public GameObject UserInput;
    public GameObject Question1;
    public GameObject PlayEdit;
    public GameObject PlayFromQR;
    public GameObject TestEditSave;
    public GameObject TestEditPublish;
    public GameObject Published;
    public String SceneToLoad;

    public int New_Quiz;
    public int Play_Edit;
    public int Play_From_QR;
    public int Test_Quiz;
    public int Test_Saved_Quiz;
    public int Play_Published;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        New_Quiz = PlayerPrefs.GetInt("NewQuiz");
        Test_Quiz = PlayerPrefs.GetInt("TestEditSave");
        Play_Edit = PlayerPrefs.GetInt("PlayEdit");
        Play_From_QR = PlayerPrefs.GetInt("PlayFromQR");
        Test_Saved_Quiz = PlayerPrefs.GetInt("TestEditPublish");
        Play_Published = PlayerPrefs.GetInt("PlayPublished");

        if (PlayerPrefs.GetInt("NewQuiz") == 1)
        {
            LoadOptions.SetActive(false);
            Question1.SetActive(true);
            PlayEdit.SetActive(false);
            PlayFromQR.SetActive(false);
            TestEditSave.SetActive(false);
            TestEditPublish.SetActive(false);
            Published.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("PlayEdit") == 1)
        {
            LoadOptions.SetActive(false);
            PlayEdit.SetActive(true);
            PlayFromQR.SetActive(false);
            TestEditSave.SetActive(false);
            TestEditPublish.SetActive(false);
            Published.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("PlayFromQR") == 1)
        {
            LoadOptions.SetActive(false);
            PlayEdit.SetActive(false);
            PlayFromQR.SetActive(true);
            TestEditSave.SetActive(false);
            TestEditPublish.SetActive(false);
            Published.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("TestEditSave") == 1)
        {
            LoadOptions.SetActive(false);
            PlayEdit.SetActive(false);
            PlayFromQR.SetActive(false);
            TestEditSave.SetActive(true);
            TestEditPublish.SetActive(false);
            Published.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("TestEditPublish") == 1)
        {
            LoadOptions.SetActive(false);
            PlayEdit.SetActive(false);
            PlayFromQR.SetActive(false);
            TestEditSave.SetActive(false);
            TestEditPublish.SetActive(true);
            Published.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("PlayPublished") == 1)
        {
            LoadOptions.SetActive(false);
            PlayEdit.SetActive(false);
            PlayFromQR.SetActive(false);
            TestEditSave.SetActive(false);
            TestEditPublish.SetActive(false);
            Published.SetActive(true);
        }
        else
        {
            LoadOptions.SetActive(true);
            PlayEdit.SetActive(false);
            PlayFromQR.SetActive(false);
            TestEditSave.SetActive(false);
            TestEditPublish.SetActive(false);
            Published.SetActive(false);
        }
    }

    public void NewQuiz()
    {
        PlayerPrefs.SetInt("NewQuiz", 1);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
    }
    public void Play()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 1);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", UserInput.GetComponent<SetLevel>().currentLevel);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
        public void PlayQR()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 1);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", UserInput.GetComponent<SetLevel>().currentLevel);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
    public void TestLocal()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 1);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", UserInput.GetComponent<SetLevel>().currentLevel);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
    public void TestLocalSaved()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 1);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", UserInput.GetComponent<SetLevel>().currentLevel);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

    public void PlayPublished()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 1);
        PlayerPrefs.SetInt("currentLevel", 1);
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
    public void RemoveMarker()
    {
        PlayerPrefs.SetInt("NewQuiz", 0);
        PlayerPrefs.SetInt("PlayEdit", 0);
        PlayerPrefs.SetInt("PlayFromQR", 0);
        PlayerPrefs.SetInt("TestEditSave", 0);
        PlayerPrefs.SetInt("TestEditPublish", 0);
        PlayerPrefs.SetInt("PlayPublished", 0);
        PlayerPrefs.SetInt("currentLevel", 1);

        Debug.Log("Remove Marker");

        New_Quiz = PlayerPrefs.GetInt("NewQuiz");
        Play_Edit = PlayerPrefs.GetInt("PlayEdit");
        Play_From_QR = PlayerPrefs.GetInt("PlayFromQR");
        Test_Quiz = PlayerPrefs.GetInt("TestEditSave");
        Test_Saved_Quiz = PlayerPrefs.GetInt("TestEditPublish");
        Play_Published = PlayerPrefs.GetInt("PlayPublished");
        
    }
}
