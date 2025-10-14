using UnityEngine;
using System.Collections.Generic;


public class ProfessorSelector : MonoBehaviour
{
    public GameObject Manager;
    public List<GameObject> Professors;
    public List<Color> ProfessorBodyColors;
    public List<Color> ProfessorLegColors;
    public List<Color> ProfessorSkinColors;
    public Material ProfessorLegMat;
    public Material ProfessorBodyMat;
    public Material ProfessorSkinMat;
    public int Level;
    public int ProfessorID;
    public string username;
    public string StudentID;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");

        Level = Manager.GetComponent<loadText>().Level;
        ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level" + Level + "ProfessorID");
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
