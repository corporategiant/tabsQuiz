using UnityEngine;
using System.Collections.Generic;
using System.Linq; // Required for LINQ methods like Any()

public class AddStamp : MonoBehaviour
{
    public int StampNumber;
    public List<string> QuizMasters;
    public string QuizMaster;
    public GameObject[] Stamps;
    private const string ListKey = "SavedStampsStringList";
    private const string Separator = "###";
    

    void Start()
    {
        
        StampNumber = PlayerPrefs.GetInt("StampNumber");
        QuizMaster = PlayerPrefs.GetString("QuizMaster");

        if (PlayerPrefs.GetInt("StampsListSaved")==1){
            string combinedString = PlayerPrefs.GetString(ListKey);
            QuizMasters = combinedString.Split(new string[] { Separator }, System.StringSplitOptions.None).ToList();
            Debug.Log("List loaded. First item: " + QuizMasters[0]);



        }



        // Using Contains() for direct equality check
        if (QuizMasters.Contains(QuizMaster))
        {
            Debug.Log(QuizMaster+ "is in the list.");
        }
        else
        {
            QuizMasters.Add(QuizMaster);
            Debug.Log(QuizMaster+ "is NOT in the list.");
            Stamps[StampNumber].SetActive(true);
            StampNumber++;
            PlayerPrefs.SetInt("STAMPNumber",StampNumber);
            //Save List to PlayerPrefs
            string combinedString = string.Join(Separator, QuizMasters.ToArray());
            PlayerPrefs.SetString(ListKey, combinedString);
            PlayerPrefs.SetInt("STAMPSListSaved",1);
            // Ensure the data is written to disk immediately
            PlayerPrefs.Save(); 

            Debug.Log("List saved: " + combinedString);

        }

    }
}
