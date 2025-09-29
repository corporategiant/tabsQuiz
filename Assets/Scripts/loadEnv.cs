using NUnit;
using UnityEngine;


public class loadEnv : MonoBehaviour
{
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
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("EnvID") == 0)
        {
            Env0.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 1)
        {
            Env1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 2)
        {
            Env2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 3)
        {
            Env3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 4)
        {
            Env4.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 5)
        {
            Env5.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 6)
        {
            Env6.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 7)
        {
            Env7.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 8)
        {
            Env8.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 9)
        {
            Env9.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("EnvID") == 10)
        {
            Env10.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
