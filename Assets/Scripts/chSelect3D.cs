using NUnit;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chSelect3D : MonoBehaviour
{
    public string username;
    public string StudentID;
    public int currentLevel;
    public int chID;
    public GameObject UserInput;
    public GameObject[] ch;
    public GameObject ch0;
    public GameObject ch1;


    public string SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");

        if (PlayerPrefs.GetInt("NewQuiz") == 1)

        {
            chID = 0;
            ch1.SetActive(false);
            ch0.SetActive(true);
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"ChID", chID);
        }
    }

    public void NextCh()
    {
        if (chID == 0)
        {
            ch0.SetActive(false);
            ch1.SetActive(true);
            chID = 1;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "ChID", chID);
        }
        else if (chID == 1)
        {
            ch1.SetActive(false);
            ch0.SetActive(true);
            chID = 0;
            PlayerPrefs.SetInt(username+StudentID+"Level" + currentLevel + "ChID", chID);
        }

    }


    public void PrevCh()
    {
        if (chID == 0)
        {
            ch0.SetActive(false);
            ch1.SetActive(true);
            chID = 1;
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"ChID", chID);
        }
        else if (chID == 1)
        {
            ch1.SetActive(false);
            ch0.SetActive(true);
            chID = 0;
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"ChID", chID);
        }
       
    }

    public void SubmitInput()
    {
        currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
        PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"ChID", chID);
        Debug.Log(username+StudentID+"Level"+currentLevel+"ChID submitted - " + chID);
    }

        public void SetLevel()
    {
        if (PlayerPrefs.GetInt("NewQuiz") == 1)

        {
            chID = 0;
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"ChID", chID);
        }

        if (PlayerPrefs.GetInt("NewQuiz") == 0)
        
        {
            currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
            chID = UserInput.GetComponent<showChID>().chID;
        }

        //Debug.Log(username+StudentID+"Level"+currentLevel+"ChID submitted - " + chID);
        foreach (GameObject ch in ch){
            ch.SetActive(false);
        }

                if (chID == 0)
        {
            ch0.SetActive(true);         
        }
        else if (chID == 1)
        {  
            ch1.SetActive(true);
        }

    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
