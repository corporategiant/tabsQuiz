using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting; // Required for LINQ extension methods like Contains()


public class AddStampv7 : MonoBehaviour
{
    public int StampNumber;
    public string username;
    public string StudentID;
    public GameObject[] Stamps;
    public TextMeshProUGUI usernametext;
    public string SaveStampsPHPUrl;
    public string GetStampsPHPUrl;
    public string currentQuizMaster;
    public string lastQuizMaster;
    public List<string> QuizMastersList;
    public string currentQuizMasterusername;
    public string currentQuizMasterStudentID;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //For testing
        PlayerPrefs.SetString("QuizMasterusername","Howie");
        PlayerPrefs.SetString("QuizMasterStudentID","POKO3311");
        StartAddStamp();
    }
    public void StartAddStamp()
    {
        LoadList();
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        currentQuizMasterusername = PlayerPrefs.GetString("QuizMasterusername");
        currentQuizMasterStudentID = PlayerPrefs.GetString("QuizMasterStudentID");
        currentQuizMaster = currentQuizMasterusername + currentQuizMasterStudentID;

        StampNumber = PlayerPrefs.GetInt(username + StudentID + "StampNumber");
        usernametext.text = username;

        if (currentQuizMaster != "")
        {

            if (QuizMastersList.Contains(currentQuizMaster))
            {
                UnityEngine.Debug.Log(currentQuizMaster + " is already in the list.");
            }
            else
            {

                UnityEngine.Debug.Log(currentQuizMaster + " is NOT in the list. Adding it now.");
                QuizMastersList.Add(currentQuizMaster);
                for (int i = 0; i < QuizMastersList.Count && i < Stamps.Length; i++)
                {

                    if (Stamps[i] != null) // Check if the element is not null
                    {
                        Stamps[i].SetActive(true);
                    }
                }
                PlayerPrefs.SetInt(username + StudentID + "StampNumber", QuizMastersList.Count);
                StampNumber = PlayerPrefs.GetInt(username + StudentID + "StampNumber");
                PlayerPrefs.SetString(username + StudentID + "QuizMaster" + QuizMastersList.Count, currentQuizMaster);
                this.gameObject.GetComponent<CharacterDataPublish>().startPublishCharacterData();

                SaveList();
            }
        }
    }
    public void SaveList()
    {
        // Convert the list to a single string, separated by a delimiter
        string listString = string.Join(",", QuizMastersList);
        PlayerPrefs.SetString(username + StudentID + "QuizMastersList", listString);
        PlayerPrefs.Save(); // Ensure data is written to disk
        Debug.Log("QuizMastersList saved: " + PlayerPrefs.GetString(username + StudentID + "QuizMastersList"));
    }

    public void LoadList()
    {
        // Split the string back into individual elements
        QuizMastersList = PlayerPrefs.GetString(username + StudentID + "QuizMastersList").Split(',').ToList();
        Debug.Log("QuizMastersList loaded: " + PlayerPrefs.GetString(username + StudentID + "QuizMastersList"));
    }
}
