using NUnit;
using UnityEngine;
using UnityEngine.SceneManagement;
public class envSelect3D : MonoBehaviour
{
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

    public string SceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void NextEnv()
    {
        if (envID == 0)
        {
            env0.SetActive(false);
            env1.SetActive(true);
            envID = 1;
        }
        else if (envID == 1)
        {
            env1.SetActive(false);
            env2.SetActive(true);
            envID = 2;
        }
        if (envID == 2)
        {
            env2.SetActive(false);
            env3.SetActive(true);
            envID = 3;
        }
        else if (envID == 3)
        {
            env3.SetActive(false);
            env4.SetActive(true);
            envID = 4;
        }
        else if (envID == 4)
        {
            env4.SetActive(false);
            env5.SetActive(true);
            envID = 5;
        }
        else if (envID == 5)
        {
            env5.SetActive(false);
            env6.SetActive(true);
            envID = 6;
        }
        else if (envID == 6)
        {
            env6.SetActive(false);
            env7.SetActive(true);
            envID = 7;
        }
        if (envID == 7)
        {
            env7.SetActive(false);
            env8.SetActive(true);
            envID = 8;
        }
        else if (envID == 8)
        {
            env8.SetActive(false);
            env9.SetActive(true);
            envID = 9;
        }
        else if (envID == 9)
        {
            env9.SetActive(false);
            env10.SetActive(true);
            envID = 10;
        }
        else if (envID == 10)
        {
            env10.SetActive(false);
            env0.SetActive(true);
            envID = 0;
        }
    }


    public void PrevEnv()
    {
        if (envID == 0)
        {
            env0.SetActive(false);
            env10.SetActive(true);
            envID = 10;
        }
        else if (envID == 1)
        {
            env1.SetActive(false);
            env0.SetActive(true);
            envID = 0;
        }
        if (envID == 2)
        {
            env2.SetActive(false);
            env1.SetActive(true);
            envID = 1;
        }
        else if (envID == 3)
        {
            env3.SetActive(false);
            env2.SetActive(true);
            envID = 2;
        }
        else if (envID == 4)
        {
            env4.SetActive(false);
            env3.SetActive(true);
            envID = 3;
        }
        else if (envID == 5)
        {
            env5.SetActive(false);
            env4.SetActive(true);
            envID = 4;
        }
        else if (envID == 6)
        {
            env6.SetActive(false);
            env5.SetActive(true);
            envID = 5;
        }
        if (envID == 7)
        {
            env7.SetActive(false);
            env6.SetActive(true);
            envID = 6;
        }
        else if (envID == 8)
        {
            env8.SetActive(false);
            env7.SetActive(true);
            envID = 7;
        }
        else if (envID == 9)
        {
            env9.SetActive(false);
            env8.SetActive(true);
            envID = 8;
        }
        else if (envID == 10)
        {
            env10.SetActive(false);
            env9.SetActive(true);
            envID = 9;
        }
    }

    public void SubmitInput()
    {
        currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
        PlayerPrefs.SetInt("Level"+currentLevel+"EnvID", envID);
        Debug.Log("Level"+currentLevel+"EnvID submitted - " + envID);
    }

        public void SetLevel()
    {
        currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
        envID = PlayerPrefs.GetInt("Level"+currentLevel+"EnvID");
        Debug.Log("Level"+currentLevel+"EnvID submitted - " + envID);
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
        if (envID == 2)
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
        if (envID == 7)
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





    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
