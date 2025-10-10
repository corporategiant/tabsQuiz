using UnityEngine;
using System.Collections.Generic;

public class clickChangeProfessor : MonoBehaviour
{
    public List<GameObject> Professors;
    public List<Color> ProfessorBodyColors;
    public List<Color> ProfessorLegColors;
    public List<Color> ProfessorSkinColors;
    public Material ProfessorLegMat;
    public Material ProfessorBodyMat;
    public Material ProfessorSkinMat;
    public GameObject UserInput;
    public int currentLevel;
  
    public int currentIndex = 0;


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
        PlayerPrefs.SetInt("Level"+currentLevel+"ProfessorID", currentIndex);
            

    }
}
