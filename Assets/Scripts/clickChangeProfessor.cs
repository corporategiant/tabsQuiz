using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class clickChangeProfessor : MonoBehaviour
{
    public string username;
    public string StudentID;

    public List<GameObject> Professors;
    public List<Color> ProfessorBodyColors;
    public List<Color> ProfessorLegColors;
    public List<Color> ProfessorSkinColors;
    public Material ProfessorLegMat;
    public Material ProfessorBodyMat;
    public Material ProfessorSkinMat;
    public GameObject UserInput;
    public int currentLevel;
    public int ProfessorID;

    public int currentIndex = 0;

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        SetProfessor();
    }



    void OnMouseDown()
    {
        foreach (GameObject Professor in Professors)
        {
            Professor.SetActive(false);
        }

        currentIndex++;
        if (currentIndex >= Professors.Count)
        {
            currentIndex = 0; // Wrap around to beginning
        }
        // Select the next/previous input field
        Professors[currentIndex].SetActive(true);
        ProfessorBodyMat.SetColor("_Color", ProfessorBodyColors[currentIndex]);
        ProfessorLegMat.SetColor("_Color", ProfessorLegColors[currentIndex]);
        ProfessorSkinMat.SetColor("_Color", ProfessorSkinColors[currentIndex]);
        currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
        PlayerPrefs.SetInt(username + StudentID + "Level" + currentLevel + "ProfessorID", currentIndex);
        ProfessorID = PlayerPrefs.GetInt(username + StudentID + "Level" + currentLevel + "ProfessorID");


    }

    public void SetProfessor()
    {
        currentLevel = UserInput.GetComponent<SetLevel>().currentLevel;
        ProfessorID = PlayerPrefs.GetInt(username + StudentID + "Level" + currentLevel + "ProfessorID");
        Debug.Log("Level"+currentLevel+" Professor ID = " + PlayerPrefs.GetInt(username + StudentID + "Level" + currentLevel + "ProfessorID"));
        foreach (GameObject Professor in Professors)
        {
            Professor.SetActive(false);
        }
        Professors[ProfessorID].SetActive(true);
        ProfessorBodyMat.SetColor("_Color", ProfessorBodyColors[ProfessorID]);
        ProfessorLegMat.SetColor("_Color", ProfessorLegColors[ProfessorID]);
        ProfessorSkinMat.SetColor("_Color", ProfessorSkinColors[ProfessorID]); 
    }

}
