using UnityEngine;
using UnityEngine.UI;

public class SaveSlotInteractable : MonoBehaviour
{
    public string username;
    public string StudentID;
    public string SaveSlot;
    public Button SaveButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        Debug.Log("Save Slot" + SaveSlot + " Level1 Question1 : " + PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question1"));

        if (PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question1") == "")
        {
            SaveButton.interactable = false;
        }
        else
        {
            SaveButton.interactable = true;
        }

    }

    public void CheckSaveSlotInteractable()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        Debug.Log("Save Slot" + SaveSlot + " Level1 Question1 : " + PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question1"));

        if (PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question1") == "")
        {
            SaveButton.interactable = false;
        }
        else
        {
            SaveButton.interactable = true;
        }
    }
}
