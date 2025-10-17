using NUnit;
using UnityEngine;
using UnityEngine.SceneManagement;
public class envSelect3D : MonoBehaviour
{
    public string username;
    public string StudentID;
    public int currentLevel;
    public int envID;
    public GameObject UserInput;
    public GameObject[] env;
    public GameObject env0;
    public GameObject env1;
    public GameObject env2;
    public GameObject env3;
    public GameObject env4;
    public GameObject env5;
    public GameObject env6;
    public GameObject env7;
    public GameObject env8;
    public GameObject env9;
    public GameObject env10;
    public GameObject env11;
    public GameObject env12;
    

    public string SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        if (PlayerPrefs.GetInt("NewQuiz") == 1)

        {
            envID = 0;
            env1.SetActive(false);
            env0.SetActive(true);
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"EnvID", envID);
        }
    }

    public void NextEnv()
    {
        if (envID == 0)
        {
            env0.SetActive(false);
            env1.SetActive(true);
            envID = 1;
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"EnvID", envID);
        }
        else if (envID == 1)
        {
            env1.SetActive(false);
            env2.SetActive(true);
            envID = 2;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 2)
        {
            env2.SetActive(false);
            env3.SetActive(true);
            envID = 3;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 3)
        {
            env3.SetActive(false);
            env4.SetActive(true);
            envID = 4;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 4)
        {
            env4.SetActive(false);
            env5.SetActive(true);
            envID = 5;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 5)
        {
            env5.SetActive(false);
            env6.SetActive(true);
            envID = 6;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 6)
        {
            env6.SetActive(false);
            env7.SetActive(true);
            envID = 7;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 7)
        {
            env7.SetActive(false);
            env8.SetActive(true);
            envID = 8;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 8)
        {
            env8.SetActive(false);
            env9.SetActive(true);
            envID = 9;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 9)
        {
            env9.SetActive(false);
            env10.SetActive(true);
            envID = 10;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 10)
        {
            env10.SetActive(false);
            env11.SetActive(true);
            envID = 11;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 11)
        {
            env11.SetActive(false);
            env12.SetActive(true);
            envID = 12;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 12)
        {
            env12.SetActive(false);
            env0.SetActive(true);
            envID = 0;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }

    }


    public void PrevEnv()
    {
        if (envID == 0)
        {
            env0.SetActive(false);
            env12.SetActive(true);
            envID = 12;
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"EnvID", envID);
        }
        else if (envID == 1)
        {
            env1.SetActive(false);
            env0.SetActive(true);
            envID = 0;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 2)
        {
            env2.SetActive(false);
            env1.SetActive(true);
            envID = 1;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 3)
        {
            env3.SetActive(false);
            env2.SetActive(true);
            envID = 2;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 4)
        {
            env4.SetActive(false);
            env3.SetActive(true);
            envID = 3;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 5)
        {
            env5.SetActive(false);
            env4.SetActive(true);
            envID = 4;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 6)
        {
            env6.SetActive(false);
            env5.SetActive(true);
            envID = 5;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 7)
        {
            env7.SetActive(false);
            env6.SetActive(true);
            envID = 6;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 8)
        {
            env8.SetActive(false);
            env7.SetActive(true);
            envID = 7;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 9)
        {
            env9.SetActive(false);
            env8.SetActive(true);
            envID = 8;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 10)
        {
            env10.SetActive(false);
            env9.SetActive(true);
            envID = 9;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 11)
        {
            env11.SetActive(false);
            env10.SetActive(true);
            envID = 10;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }
        else if (envID == 12)
        {
            env12.SetActive(false);
            env11.SetActive(true);
            envID = 11;
            PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "EnvID", envID);
        }

    }

    public void SubmitInput()
    {
        currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
        PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"EnvID", envID);
        Debug.Log(username+StudentID+"Level"+currentLevel+"EnvID submitted - " + envID);
    }

        public void SetLevel()
    {
        if (PlayerPrefs.GetInt("NewQuiz") == 1)

        {
            Debug.Log("NewQuiz");
            envID = 0;
            PlayerPrefs.SetInt(username+StudentID+"Level"+currentLevel+"EnvID", envID);
        }

        if (PlayerPrefs.GetInt("NewQuiz") == 0)

        {
            currentLevel = PlayerPrefs.GetInt("currentLevel");
            envID = UserInput.GetComponent<showEnvID>().envID;
            Debug.Log(username+StudentID+"Level"+currentLevel+"EnvID loaded " + envID);
        }
        
        foreach (GameObject env in env){
            env.SetActive(false);
        }

        if (envID == 0)
        {
            env0.SetActive(true);         
        }
        else if (envID == 1)
        {  
            env1.SetActive(true);
        }
        else if (envID == 2)
        {
            env2.SetActive(true);

        }
        else if (envID == 3)
        {
            env3.SetActive(true);
        }
        else if (envID == 4)
        {
            env4.SetActive(true);

        }
        else if (envID == 5)
        {
            env5.SetActive(true);

        }
        else if (envID == 6)
        {
            env6.SetActive(true);

        }
        else if (envID == 7)
        {
            env7.SetActive(true);

        }
        else if (envID == 8)
        {
            env8.SetActive(true);

        }
        else if (envID == 9)
        {
            env9.SetActive(true);

        }
        else if (envID == 10)
        {
            env10.SetActive(true);

        }
        else if (envID == 11)
        {
            env11.SetActive(true);

        }
        else if (envID == 12)
        {
            env12.SetActive(true);

        }





    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
