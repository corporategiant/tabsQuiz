using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Linq;

public class AddStampv2 : MonoBehaviour
{
    public int StampNumber;
    public int StampNumberAdd1;
    public int QuizMaster;
    public string username;
    public string StudentID;
    public GameObject[] Stamps;
    public TextMeshProUGUI usernametext;
    public string SaveStampsPHPUrl;
    public string GetStampsPHPUrl;
    public string currentQuizMaster;
    public string lastQuizMaster;
    public List<string> QuizMastersList;
    public string QuizMaster1;
    public string QuizMaster2;
    public string QuizMaster3;
    public string QuizMaster4;
    public string QuizMaster5;
    public string QuizMaster6;
    public string QuizMaster7;
    public string QuizMaster8;
    public string QuizMaster9;
    public string QuizMaster10;
    public string QuizMaster11;
    public string QuizMaster12;
    public string QuizMaster13;
    public string QuizMaster14;
    public string QuizMaster15;
    public string QuizMaster16;
    public string QuizMaster17;
    public string QuizMaster18;
    public string QuizMaster19;
    public string QuizMaster20;


    public string currentQuizMasterusername;
    public string currentQuizMasterStudentID;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartAddStamp();
    }
    public void StartAddStamp()
    {

        //For testing
       PlayerPrefs.SetString("QuizMasterusername", "Guest");
       PlayerPrefs.SetString("QuizMasterStudentID", "KOKO3311");


        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        currentQuizMasterusername = PlayerPrefs.GetString("QuizMasterusername");
        currentQuizMasterStudentID = PlayerPrefs.GetString("QuizMasterStudentID");
        currentQuizMaster = currentQuizMasterusername + currentQuizMasterStudentID;
        lastQuizMaster = PlayerPrefs.GetString("lastQuizMaster");

        StampNumber = PlayerPrefs.GetInt(username + StudentID + "StampNumber");
        StampNumberAdd1 = PlayerPrefs.GetInt(username + StudentID + "StampNumber") + 1;
        usernametext.text = username;

        



        LoadQuizMasterList();


        for (int i = 0; i < StampNumberAdd1 && i < Stamps.Length; i++)
        {
            if (Stamps[i] != null) // Check if the element is not null
            {
                Stamps[i].SetActive(true);
            }
        }



        if (currentQuizMaster != lastQuizMaster)
        {
            if (!QuizMastersList.Contains(currentQuizMaster))
            {

                for (int i = 0; i < StampNumberAdd1 && i < Stamps.Length; i++)
                {
                    if (Stamps[i] != null) // Check if the element is not null
                    {
                        Stamps[i].SetActive(true);
                    }
                }
                lastQuizMaster = currentQuizMaster;
                PlayerPrefs.SetString("lastQuizMaster", lastQuizMaster);
                PlayerPrefs.SetInt(username + StudentID + "StampNumber", StampNumberAdd1);
                PlayerPrefs.SetString(username + StudentID + "QuizMaster" + StampNumberAdd1, currentQuizMaster);
                this.gameObject.GetComponent<CharacterDataPublish>().startPublishCharacterData();
                PlayerPrefs.Save();
            }
        }

    }
    public void LoadQuizMasterList()
    {
        QuizMastersList.Clear();
        QuizMaster1 = PlayerPrefs.GetString(username + StudentID + "QuizMaster1");
        QuizMaster2 = PlayerPrefs.GetString(username + StudentID + "QuizMaster2");
        QuizMaster3 = PlayerPrefs.GetString(username + StudentID + "QuizMaster3");
        QuizMaster4 = PlayerPrefs.GetString(username + StudentID + "QuizMaster4");
        QuizMaster5 = PlayerPrefs.GetString(username + StudentID + "QuizMaster5");
        QuizMaster6 = PlayerPrefs.GetString(username + StudentID + "QuizMaster6");
        QuizMaster7 = PlayerPrefs.GetString(username + StudentID + "QuizMaster7");
        QuizMaster8 = PlayerPrefs.GetString(username + StudentID + "QuizMaster8");
        QuizMaster9 = PlayerPrefs.GetString(username + StudentID + "QuizMaster9");
        QuizMaster10 = PlayerPrefs.GetString(username + StudentID + "QuizMaster10");
        QuizMaster11 = PlayerPrefs.GetString(username + StudentID + "QuizMaster11");
        QuizMaster12 = PlayerPrefs.GetString(username + StudentID + "QuizMaster12");
        QuizMaster13 = PlayerPrefs.GetString(username + StudentID + "QuizMaster13");
        QuizMaster14 = PlayerPrefs.GetString(username + StudentID + "QuizMaster14");
        QuizMaster15 = PlayerPrefs.GetString(username + StudentID + "QuizMaster15");
        QuizMaster16 = PlayerPrefs.GetString(username + StudentID + "QuizMaster16");
        QuizMaster17 = PlayerPrefs.GetString(username + StudentID + "QuizMaster17");
        QuizMaster18 = PlayerPrefs.GetString(username + StudentID + "QuizMaster18");
        QuizMaster19 = PlayerPrefs.GetString(username + StudentID + "QuizMaster19");
        QuizMaster20 = PlayerPrefs.GetString(username + StudentID + "QuizMaster20");

        int count = StampNumber; // Default to 0 if key not found
        for (int i = 0; i < count; i++)
        {
                QuizMastersList.Add(PlayerPrefs.GetString(username + StudentID + "QuizMaster" + i));            
        }
        Debug.Log("QuizMaster List Loaded: " + string.Join(", ", QuizMastersList));
    }
}
