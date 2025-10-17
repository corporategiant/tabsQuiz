using UnityEngine;
using System.Collections.Generic;
using System.Linq; // Required for LINQ methods like Any()

public class AddStampv2 : MonoBehaviour
{
    public int StampNumber;
    public string username;
    public string StudentID;
    public string QuizMasterusername;
    public string QuizMasterStudentID;
    public GameObject[] Stamps;

    [System.Serializable]
    public class QuizMasters
    {
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

    }


    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");

        StampNumber = PlayerPrefs.GetInt(username + StudentID + "StampNumber");
        QuizMasterusername = PlayerPrefs.GetString("QuizMasterusername");
        QuizMasterStudentID = PlayerPrefs.GetString("QuizMasterStudentID");

        if (PlayerPrefs.GetInt(username + StudentID + "StampsListSaved") == 1)
        {


        }

    }
}