using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Text;
using System.Collections.Generic; // For List<T>



public class addStampv6 : MonoBehaviour
{
    public string username;
    public string StudentID;
    public string currentQuizMasterusername;
    public string currentQuizMasterStudentID;
    public string filename;
    public bool getStampsAtStart;
    public string QuizMaster1;
    public int QuizMaster1isOn;
    public string QuizMaster2;
    public int QuizMaster2isOn;
    public string QuizMaster3;
    public int QuizMaster3isOn;
    // public string QuizMaster4;
    // public int QuizMaster4isOn;
    // public string QuizMaster5;
    // public int QuizMaster5isOn;
    // public string QuizMaster6;
    // public int QuizMaster6isOn;
    // public string QuizMaster7;
    // public int QuizMaster7isOn;
    // public string QuizMaster8;
    // public int QuizMaster8isOn;
    // public string QuizMaster9;
    // public int QuizMaster9isOn;
    // public string QuizMaster10;
    // public int QuizMaster10isOn;
    // public string QuizMaster11;
    // public int QuizMaster11isOn;
    // public string QuizMaster12;
    // public int QuizMaster12isOn;
    // public string QuizMaster13;
    // public int QuizMaster13isOn;
    // public string QuizMaster14;
    // public int QuizMaster14isOn;
    // public string QuizMaster15;
    // public int QuizMaster15isOn;
    // public string QuizMaster16;
    // public int QuizMaster16isOn;
    // public string QuizMaster17;
    // public int QuizMaster17isOn;
    // public string QuizMaster18;
    // public int QuizMaster18isOn;
    // public string QuizMaster19;
    // public int QuizMaster19isOn;
    // public string QuizMaster20;
    // public int QuizMaster20isOn;
    public GameObject Stamp1;
    public GameObject Stamp2;
    public GameObject Stamp3;
    // public GameObject Stamp4;
    // public GameObject Stamp5;
    // public GameObject Stamp6;
    // public GameObject Stamp7;
    // public GameObject Stamp8;
    // public GameObject Stamp9;
    // public GameObject Stamp10;
    // public GameObject Stamp11;
    // public GameObject Stamp12;
    // public GameObject Stamp13;
    // public GameObject Stamp14;
    // public GameObject Stamp15;
    // public GameObject Stamp16;
    // public GameObject Stamp17;
    // public GameObject Stamp18;
    // public GameObject Stamp19;
    // public GameObject Stamp20;

    // [System.Serializable]
    // public class StampsData
    // {
    //     public string filename;
    //     public string QuizMaster1;
    //     public int QuizMaster1isOn;
    //     public string QuizMaster2;
    //     public int QuizMaster2isOn;
    //     public string QuizMaster3;
    //     public int QuizMaster3isOn;
    // }
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // For testing

        PlayerPrefs.SetString("QuizMasterusername", "Guest");
        PlayerPrefs.SetString("QuizMasterStudentID", "KOKO3311");


        currentQuizMasterusername = PlayerPrefs.GetString("QuizMasterusername");
        currentQuizMasterStudentID = PlayerPrefs.GetString("QuizMasterStudentID");
        filename = PlayerPrefs.GetString("username") + PlayerPrefs.GetString("StudentID");
        if (getStampsAtStart == true)
        {
            Debug.Log("Start SetStamps");
            SetStamps();
            //AddStamps();
            //StartCoroutine(SaveStamps());
        }
    }

    public void SetStamps()
    {
        QuizMaster1 = PlayerPrefs.GetString(username + StudentID + "QuizMaster1");
        QuizMaster1isOn = PlayerPrefs.GetInt(username + StudentID + "QuizMaster1isOn");
        QuizMaster2 = PlayerPrefs.GetString(username + StudentID + "QuizMaster2");
        QuizMaster2isOn = PlayerPrefs.GetInt(username + StudentID + "QuizMaster2isOn");
        QuizMaster3 = PlayerPrefs.GetString(username + StudentID + "QuizMaster3");
        QuizMaster3isOn = PlayerPrefs.GetInt(username + StudentID + "QuizMaster3isOn");


        if (QuizMaster1isOn == 1)
        {
            Stamp1.SetActive(true);
        }
        if (QuizMaster2isOn == 1)
        {
            Stamp2.SetActive(true);
        }
        if (QuizMaster3isOn == 1)
        {
            Stamp3.SetActive(true);
        }

        AddStamps();

    }
    public void AddStamps()
    {
        if (QuizMaster1isOn == 0)
        {
            QuizMaster1 = currentQuizMasterusername;
            Stamp1.SetActive(true);
            QuizMaster1isOn = 1;
            PlayerPrefs.SetString(username + StudentID + "QuizMaster1", QuizMaster1);
            PlayerPrefs.SetInt(username + StudentID + "QuizMaster1isOn", 1);
        }
        else if (QuizMaster1isOn == 1)
        {
            if (QuizMaster1 != currentQuizMasterusername)
            {
                if (QuizMaster2isOn == 0)
                {
                    QuizMaster2 = currentQuizMasterusername;
                    Stamp2.SetActive(true);
                    QuizMaster2isOn = 1;
                    PlayerPrefs.SetString(username + StudentID + "QuizMaster2", QuizMaster2);
                    PlayerPrefs.SetInt(username + StudentID + "QuizMaster1isOn", 1);
                }
                else if (QuizMaster2isOn == 1)
                {
                    if (QuizMaster2 != currentQuizMasterusername)
                    {
                        if (QuizMaster3isOn == 0)
                        {
                            QuizMaster3 = currentQuizMasterusername;
                            Stamp3.SetActive(true);
                            QuizMaster3isOn = 1;
                            PlayerPrefs.SetString(username + StudentID + "QuizMaster3", QuizMaster3);
                            PlayerPrefs.SetInt(username + StudentID + "QuizMaster1isOn", 1);
                        }
                        // // else if (QuizMaster3isOn == 1)
                        // // {
                        // //     if (QuizMaster3 != currentQuizMasterusername)
                        // //     {
                        // //         if (QuizMaster4isOn == 0)
                        // //         {
                        // //             QuizMaster4 = currentQuizMasterusername;
                        // //             Stamp4.SetActive(true);
                        // //             QuizMaster4isOn = 1;
                        // //             PlayerPrefs.SetString(username + StudentID + "QuizMaster4", QuizMaster4);
                        // //             PlayerPrefs.SetInt(username + StudentID + "QuizMaster4isOn", 1);
                        // //         }
                        // //         else if (QuizMaster4isOn == 1)
                        // //         {
                        // //             if (QuizMaster4 != currentQuizMasterusername)
                        // //             {
                        // //                 if (QuizMaster5isOn == 0)
                        // //                 {
                        // //                     QuizMaster5 = currentQuizMasterusername;
                        // //                     Stamp5.SetActive(true);
                        // //                     QuizMaster5isOn = 1;
                        // //                     PlayerPrefs.SetString(username + StudentID + "QuizMaster4", QuizMaster5);
                        // //                     PlayerPrefs.SetInt(username + StudentID + "QuizMaster5isOn", 1);
                        // //                 }
                        // //                 else if (QuizMaster5isOn == 1)
                        // //                 {


                        // //                 }


                        // //             }
                        //         }

                        //     }
                        // }
                    }
                }
            }
            //StartCoroutine(SaveStamps());
        }
    }

    public void SaveStamps()
    {


    }

    
}