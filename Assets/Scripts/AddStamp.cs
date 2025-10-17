using UnityEngine;
using System.Collections.Generic;
using System.Linq; // Required for LINQ methods like Any()

public class AddStamp : MonoBehaviour
{
    public int StampNumber;
    public List<string> QuizMasters;
    public string username;
    public string StudentID;
    public string QuizMasterusername;
    public string QuizMasterStudentID;
    public GameObject[] Stamps;
    private const string ListKey = "SavedStampsStringList";
    private const string Separator = "###";
    

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        
        StampNumber = PlayerPrefs.GetInt(username + StudentID + "StampNumber");
        QuizMasterusername = PlayerPrefs.GetString("QuizMasterusername");
        QuizMasterStudentID = PlayerPrefs.GetString("QuizMasterStudentID");

        if (PlayerPrefs.GetInt(username + StudentID + "StampsListSaved") == 1)
        {
            string combinedString = PlayerPrefs.GetString(ListKey);
            QuizMasters = combinedString.Split(new string[] { Separator }, System.StringSplitOptions.None).ToList();
            Debug.Log("List loaded. First item: " + QuizMasters[0]);



        }



        // Using Contains() for direct equality check
        if (QuizMasters.Contains(QuizMasterusername+QuizMasterStudentID))
        {
            Debug.Log(QuizMasterusername+QuizMasterStudentID+ "is in the list.");
        }
        else
        {
            QuizMasters.Add(QuizMasterusername+QuizMasterStudentID);
            Debug.Log(QuizMasterusername+QuizMasterStudentID+ "is NOT in the list.");
            Stamps[StampNumber].SetActive(true);
            StampNumber++;
            PlayerPrefs.SetInt(username + StudentID + "STAMPNumber",StampNumber);
            //Save List to PlayerPrefs
            string combinedString = string.Join(Separator, QuizMasters.ToArray());
            PlayerPrefs.SetString(ListKey, combinedString);
            PlayerPrefs.SetInt(username + StudentID + "STAMPSListSaved",1);
            // Ensure the data is written to disk immediately
            PlayerPrefs.Save(); 

            Debug.Log("List saved: " + combinedString);

        }

    }
}
