using NUnit;
using UnityEngine;


public class loadEnv : MonoBehaviour
{
    public string username;
    public string StudentID;
    public GameObject Env0;
    public GameObject Env1;
    public GameObject Env2;
    public GameObject Env3;
    public GameObject Env4;
    public GameObject Env5;
    public GameObject Env6;
    public GameObject Env7;
    public GameObject Env8;
    public GameObject Env9;
    public GameObject Env10;
    public GameObject Env11;
    public GameObject Env12;
    
    public int Level;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        Level = PlayerPrefs.GetInt("currentLevel");
        Env0.SetActive(false);
        Debug.Log(username + StudentID + "Level" + Level + "EnvID = " + PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID"));
        if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 0)
        {
            Env0.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 1)
        {
            Env1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 2)
        {
            Env2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 3)
        {
            Env3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 4)
        {
            Env4.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 5)
        {
            Env5.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 6)
        {
            Env6.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 7)
        {
            Env7.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 8)
        {
            Env8.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 9)
        {
            Env9.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 10)
        {
            Env10.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 11)
        {
            Env11.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(username + StudentID + "Level" + Level + "EnvID") == 12)
        {
            Env12.SetActive(true);
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
