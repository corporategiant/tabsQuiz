using UnityEngine;



public class SaveLocal : MonoBehaviour
{
    public string username;
    public string StudentID;
    public string SaveSlot;

    [Header("Level 1")]
    public string Level1Question1;
    public string Level1Answer1A;
    public string Level1Answer1B;
    public string Level1Answer1C;
    public int Level1CorrectAnswer1;
    public string Level1Question2;
    public string Level1Answer2A;
    public string Level1Answer2B;
    public string Level1Answer2C;
    public int Level1CorrectAnswer2;
    public string Level1Question3;
    public string Level1Answer3A;
    public string Level1Answer3B;
    public string Level1Answer3C;
    public int Level1CorrectAnswer3;
    public string Level1Question4;
    public string Level1Answer4A;
    public string Level1Answer4B;
    public string Level1Answer4C;
    public int Level1CorrectAnswer4;
    public int Level1EnvID;
    public int Level1ChID;
    public int Level1ProfessorID;
    public string Level2Question1;
    public string Level2Answer1A;
    public string Level2Answer1B;
    public string Level2Answer1C;
    public int Level2CorrectAnswer1;
    public string Level2Question2;
    public string Level2Answer2A;
    public string Level2Answer2B;
    public string Level2Answer2C;
    public int Level2CorrectAnswer2;
    public string Level2Question3;
    public string Level2Answer3A;
    public string Level2Answer3B;
    public string Level2Answer3C;
    public int Level2CorrectAnswer3;
    public string Level2Question4;
    public string Level2Answer4A;
    public string Level2Answer4B;
    public string Level2Answer4C;
    public int Level2CorrectAnswer4;
    public int Level2EnvID;
    public int Level2ChID;
    public int Level2ProfessorID;
    public string Level3Question1;
    public string Level3Answer1A;
    public string Level3Answer1B;
    public string Level3Answer1C;
    public int Level3CorrectAnswer1;
    public string Level3Question2;
    public string Level3Answer2A;
    public string Level3Answer2B;
    public string Level3Answer2C;
    public int Level3CorrectAnswer2;
    public string Level3Question3;
    public string Level3Answer3A;
    public string Level3Answer3B;
    public string Level3Answer3C;
    public int Level3CorrectAnswer3;
    public string Level3Question4;
    public string Level3Answer4A;
    public string Level3Answer4B;
    public string Level3Answer4C;
    public int Level3CorrectAnswer4;
    public int Level3EnvID;
    public int Level3ChID;
    public int Level3ProfessorID;
    public string Level4Question1;
    public string Level4Answer1A;
    public string Level4Answer1B;
    public string Level4Answer1C;
    public int Level4CorrectAnswer1;
    public string Level4Question2;
    public string Level4Answer2A;
    public string Level4Answer2B;
    public string Level4Answer2C;
    public int Level4CorrectAnswer2;
    public string Level4Question3;
    public string Level4Answer3A;
    public string Level4Answer3B;
    public string Level4Answer3C;
    public int Level4CorrectAnswer3;
    public string Level4Question4;
    public string Level4Answer4A;
    public string Level4Answer4B;
    public string Level4Answer4C;
    public int Level4CorrectAnswer4;
    public int Level4EnvID;
    public int Level4ChID;
    public int Level4ProfessorID;



    

    public void StartSaveLocal(string SaveSlot)
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        //Get Player Prefs

        Level1Question1 = PlayerPrefs.GetString(username + StudentID + "Level1Question1");
        Level1Answer1A = PlayerPrefs.GetString(username + StudentID + "Level1Answer1A");
        Level1Answer1B = PlayerPrefs.GetString(username + StudentID + "Level1Answer1B");
        Level1Answer1C = PlayerPrefs.GetString(username + StudentID + "Level1Answer1C");
        Level1CorrectAnswer1 = PlayerPrefs.GetInt(username + StudentID + "Level1CorrectAnswer1");
        Level1Question2 = PlayerPrefs.GetString(username + StudentID + "Level1Question2");
        Level1Answer2A = PlayerPrefs.GetString(username + StudentID + "Level1Answer2A");
        Level1Answer2B = PlayerPrefs.GetString(username + StudentID + "Level1Answer2B");
        Level1Answer2C = PlayerPrefs.GetString(username + StudentID + "Level1Answer2C");
        Level1CorrectAnswer2 = PlayerPrefs.GetInt(username + StudentID + "Level1CorrectAnswer2");
        Level1Question3 = PlayerPrefs.GetString(username + StudentID + "Level1Question3");
        Level1Answer3A = PlayerPrefs.GetString(username + StudentID + "Level1Answer3A");
        Level1Answer3B = PlayerPrefs.GetString(username + StudentID + "Level1Answer3B");
        Level1Answer3C = PlayerPrefs.GetString(username + StudentID + "Level1Answer3C");
        Level1CorrectAnswer3 = PlayerPrefs.GetInt(username + StudentID + "Level1CorrectAnswer3");
        Level1Question4 = PlayerPrefs.GetString(username + StudentID + "Level1Question4");
        Level1Answer4A = PlayerPrefs.GetString(username + StudentID + "Level1Answer4A");
        Level1Answer4B = PlayerPrefs.GetString(username + StudentID + "Level1Answer4B");
        Level1Answer4C = PlayerPrefs.GetString(username + StudentID + "Level1Answer4C");
        Level1CorrectAnswer4 = PlayerPrefs.GetInt(username + StudentID + "Level1CorrectAnswer4");
        Level1EnvID = PlayerPrefs.GetInt(username + StudentID + "Level1EnvID");
        Level1ChID = PlayerPrefs.GetInt(username + StudentID + "Level1ChID");
        Level1ProfessorID = PlayerPrefs.GetInt(username + StudentID + "Level1ProfessorID");


        Level2Question1 = PlayerPrefs.GetString(username + StudentID + "Level2Question1");
        Level2Answer1A = PlayerPrefs.GetString(username + StudentID + "Level2Answer1A");
        Level2Answer1B = PlayerPrefs.GetString(username + StudentID + "Level2Answer1B");
        Level2Answer1C = PlayerPrefs.GetString(username + StudentID + "Level2Answer1C");
        Level2CorrectAnswer1 = PlayerPrefs.GetInt(username + StudentID + "Level2CorrectAnswer1");
        Level2Question2 = PlayerPrefs.GetString(username + StudentID + "Level2Question2");
        Level2Answer2A = PlayerPrefs.GetString(username + StudentID + "Level2Answer2A");
        Level2Answer2B = PlayerPrefs.GetString(username + StudentID + "Level2Answer2B");
        Level2Answer2C = PlayerPrefs.GetString(username + StudentID + "Level2Answer2C");
        Level2CorrectAnswer2 = PlayerPrefs.GetInt(username + StudentID + "Level2CorrectAnswer2");
        Level2Question3 = PlayerPrefs.GetString(username + StudentID + "Level2Question3");
        Level2Answer3A = PlayerPrefs.GetString(username + StudentID + "Level2Answer3A");
        Level2Answer3B = PlayerPrefs.GetString(username + StudentID + "Level2Answer3B");
        Level2Answer3C = PlayerPrefs.GetString(username + StudentID + "Level2Answer3C");
        Level2CorrectAnswer3 = PlayerPrefs.GetInt(username + StudentID + "Level2CorrectAnswer3");
        Level2Question4 = PlayerPrefs.GetString(username + StudentID + "Level2Question4");
        Level2Answer4A = PlayerPrefs.GetString(username + StudentID + "Level2Answer4A");
        Level2Answer4B = PlayerPrefs.GetString(username + StudentID + "Level2Answer4B");
        Level2Answer4C = PlayerPrefs.GetString(username + StudentID + "Level2Answer4C");
        Level2CorrectAnswer4 = PlayerPrefs.GetInt(username + StudentID + "Level2CorrectAnswer4");
        Level2EnvID = PlayerPrefs.GetInt(username + StudentID + "Level2EnvID");
        Level2ChID = PlayerPrefs.GetInt(username + StudentID + "Level2ChID");
        Level2ProfessorID = PlayerPrefs.GetInt(username + StudentID + "Level2ProfessorID");

        Level3Question1 = PlayerPrefs.GetString(username + StudentID + "Level3Question1");
        Level3Answer1A = PlayerPrefs.GetString(username + StudentID + "Level3Answer1A");
        Level3Answer1B = PlayerPrefs.GetString(username + StudentID + "Level3Answer1B");
        Level3Answer1C = PlayerPrefs.GetString(username + StudentID + "Level3Answer1C");
        Level3CorrectAnswer1 = PlayerPrefs.GetInt(username + StudentID + "Level3CorrectAnswer1");
        Level3Question2 = PlayerPrefs.GetString(username + StudentID + "Level3Question2");
        Level3Answer2A = PlayerPrefs.GetString(username + StudentID + "Level3Answer2A");
        Level3Answer2B = PlayerPrefs.GetString(username + StudentID + "Level3Answer2B");
        Level3Answer2C = PlayerPrefs.GetString(username + StudentID + "Level3Answer2C");
        Level3CorrectAnswer2 = PlayerPrefs.GetInt(username + StudentID + "Level3CorrectAnswer2");
        Level3Question3 = PlayerPrefs.GetString(username + StudentID + "Level3Question3");
        Level3Answer3A = PlayerPrefs.GetString(username + StudentID + "Level3Answer3A");
        Level3Answer3B = PlayerPrefs.GetString(username + StudentID + "Level3Answer3B");
        Level3Answer3C = PlayerPrefs.GetString(username + StudentID + "Level3Answer3C");
        Level3CorrectAnswer3 = PlayerPrefs.GetInt(username + StudentID + "Level3CorrectAnswer3");
        Level3Question4 = PlayerPrefs.GetString(username + StudentID + "Level3Question4");
        Level3Answer4A = PlayerPrefs.GetString(username + StudentID + "Level3Answer4A");
        Level3Answer4B = PlayerPrefs.GetString(username + StudentID + "Level3Answer4B");
        Level3Answer4C = PlayerPrefs.GetString(username + StudentID + "Level3Answer4C");
        Level3CorrectAnswer4 = PlayerPrefs.GetInt(username + StudentID + "Level3CorrectAnswer4");
        Level3EnvID = PlayerPrefs.GetInt(username + StudentID + "Level3EnvID");
        Level3ChID = PlayerPrefs.GetInt(username + StudentID + "Level3ChID");
        Level3ProfessorID = PlayerPrefs.GetInt(username + StudentID + "Level3ProfessorID");

        Level4Question1 = PlayerPrefs.GetString(username + StudentID + "Level4Question1");
        Level4Answer1A = PlayerPrefs.GetString(username + StudentID + "Level4Answer1A");
        Level4Answer1B = PlayerPrefs.GetString(username + StudentID + "Level4Answer1B");
        Level4Answer1C = PlayerPrefs.GetString(username + StudentID + "Level4Answer1C");
        Level4CorrectAnswer1 = PlayerPrefs.GetInt(username + StudentID + "Level4CorrectAnswer1");
        Level4Question2 = PlayerPrefs.GetString(username + StudentID + "Level4Question2");
        Level4Answer2A = PlayerPrefs.GetString(username + StudentID + "Level4Answer2A");
        Level4Answer2B = PlayerPrefs.GetString(username + StudentID + "Level4Answer2B");
        Level4Answer2C = PlayerPrefs.GetString(username + StudentID + "Level4Answer2C");
        Level4CorrectAnswer2 = PlayerPrefs.GetInt(username + StudentID + "Level4CorrectAnswer2");
        Level4Question3 = PlayerPrefs.GetString(username + StudentID + "Level4Question3");
        Level4Answer3A = PlayerPrefs.GetString(username + StudentID + "Level4Answer3A");
        Level4Answer3B = PlayerPrefs.GetString(username + StudentID + "Level4Answer3B");
        Level4Answer3C = PlayerPrefs.GetString(username + StudentID + "Level4Answer3C");
        Level4CorrectAnswer3 = PlayerPrefs.GetInt(username + StudentID + "Level4CorrectAnswer3");
        Level4Question4 = PlayerPrefs.GetString(username + StudentID + "Level4Question4");
        Level4Answer4A = PlayerPrefs.GetString(username + StudentID + "Level4Answer4A");
        Level4Answer4B = PlayerPrefs.GetString(username + StudentID + "Level4Answer4B");
        Level4Answer4C = PlayerPrefs.GetString(username + StudentID + "Level4Answer4C");
        Level4CorrectAnswer4 = PlayerPrefs.GetInt(username + StudentID + "Level4CorrectAnswer4");
        Level4EnvID = PlayerPrefs.GetInt(username + StudentID + "Level4EnvID");
        Level4ChID = PlayerPrefs.GetInt(username + StudentID + "Level4ChID");
        Level4ProfessorID = PlayerPrefs.GetInt(username + StudentID + "Level4ProfessorID");

        //Write Save Data

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Question1", Level1Question1);
        Debug.Log("Saved Level 1 Question 1 : " + Level1Question1 + "to" + SaveSlot);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer1A", Level1Answer1A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer1B", Level1Answer1B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer1C", Level1Answer1C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer1", Level1CorrectAnswer1);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Question2", Level1Question2);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer2A", Level1Answer2A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer2B", Level1Answer2B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer2C", Level1Answer2C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer2", Level1CorrectAnswer2);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Question3", Level1Question3);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer3A", Level1Answer3A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer3B", Level1Answer3B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer3C", Level1Answer3C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer3", Level1CorrectAnswer3);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Question4", Level1Question4);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer4A", Level1Answer4A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer4B", Level1Answer4B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level1Answer4C", Level1Answer4C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer4", Level1CorrectAnswer4);

        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1EnvID", Level1EnvID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1ChID", Level1ChID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level1ProfessorID", Level1ProfessorID);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Question1", Level2Question1);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer1A", Level2Answer1A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer1B", Level2Answer1B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer1C", Level2Answer1C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer1", Level2CorrectAnswer1);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Question2", Level2Question2);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer2A", Level2Answer2A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer2B", Level2Answer2B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer2C", Level2Answer2C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer2", Level2CorrectAnswer2);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Question3", Level2Question3);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer3A", Level2Answer3A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer3B", Level2Answer3B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer3C", Level2Answer3C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer3", Level2CorrectAnswer3);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Question4", Level2Question4);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer4A", Level2Answer4A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer4B", Level2Answer4B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level2Answer4C", Level2Answer4C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer4", Level2CorrectAnswer4);

        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2EnvID", Level2EnvID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2ChID", Level2ChID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level2ProfessorID", Level2ProfessorID);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Question1", Level3Question1);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer1A", Level3Answer1A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer1B", Level3Answer1B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer1C", Level3Answer1C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer1", Level3CorrectAnswer1);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Question2", Level3Question2);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer2A", Level3Answer2A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer2B", Level3Answer2B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer2C", Level3Answer2C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer2", Level3CorrectAnswer2);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Question3", Level3Question3);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer3A", Level3Answer3A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer3B", Level3Answer3B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer3C", Level3Answer3C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer3", Level3CorrectAnswer3);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Question4", Level3Question4);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer4A", Level3Answer4A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer4B", Level3Answer4B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level3Answer4C", Level3Answer4C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer4", Level3CorrectAnswer4);

        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3EnvID", Level3EnvID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3ChID", Level3ChID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level3ProfessorID", Level3ProfessorID);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Question1", Level4Question1);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer1A", Level4Answer1A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer1B", Level4Answer1B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer1C", Level4Answer1C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer1", Level4CorrectAnswer1);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Question2", Level4Question2);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer2A", Level4Answer2A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer2B", Level4Answer2B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer2C", Level4Answer2C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer2", Level4CorrectAnswer2);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Question3", Level4Question3);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer3A", Level4Answer3A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer3B", Level4Answer3B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer3C", Level4Answer3C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer3", Level4CorrectAnswer3);

        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Question4", Level4Question4);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer4A", Level4Answer4A);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer4B", Level4Answer4B);
        PlayerPrefs.SetString(SaveSlot + username + StudentID + "Level4Answer4C", Level4Answer4C);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer4", Level4CorrectAnswer4);

        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4EnvID", Level4EnvID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4ChID", Level4ChID);
        PlayerPrefs.SetInt(SaveSlot + username + StudentID + "Level4ProfessorID", Level4ProfessorID);
    }

    public void StartLoadLocal(string SaveSlot)
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");

        //Get Save Data

        Level1Question1 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question1");
        Level1Answer1A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer1A");
        Level1Answer1B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer1B");
        Level1Answer1C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer1C");
        Level1CorrectAnswer1 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer1");
        Level1Question2 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question2");
        Level1Answer2A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer2A");
        Level1Answer2B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer2B");
        Level1Answer2C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer2C");
        Level1CorrectAnswer2 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer2");
        Level1Question3 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question3");
        Level1Answer3A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer3A");
        Level1Answer3B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer3B");
        Level1Answer3C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer3C");
        Level1CorrectAnswer3 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer3");
        Level1Question4 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Question4");
        Level1Answer4A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer4A");
        Level1Answer4B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer4B");
        Level1Answer4C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level1Answer4C");
        Level1CorrectAnswer4 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1CorrectAnswer4");
        Level1EnvID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1EnvID");
        Level1ChID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1ChID");
        Level1ProfessorID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level1ProfessorID");


        Level2Question1 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Question1");
        Level2Answer1A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer1A");
        Level2Answer1B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer1B");
        Level2Answer1C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer1C");
        Level2CorrectAnswer1 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer1");
        Level2Question2 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Question2");
        Level2Answer2A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer2A");
        Level2Answer2B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer2B");
        Level2Answer2C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer2C");
        Level2CorrectAnswer2 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer2");
        Level2Question3 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Question3");
        Level2Answer3A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer3A");
        Level2Answer3B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer3B");
        Level2Answer3C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer3C");
        Level2CorrectAnswer3 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer3");
        Level2Question4 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Question4");
        Level2Answer4A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer4A");
        Level2Answer4B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer4B");
        Level2Answer4C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level2Answer4C");
        Level2CorrectAnswer4 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2CorrectAnswer4");
        Level2EnvID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2EnvID");
        Level2ChID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2ChID");
        Level2ProfessorID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level2ProfessorID");

        Level3Question1 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Question1");
        Level3Answer1A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer1A");
        Level3Answer1B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer1B");
        Level3Answer1C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer1C");
        Level3CorrectAnswer1 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer1");
        Level3Question2 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Question2");
        Level3Answer2A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer2A");
        Level3Answer2B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer2B");
        Level3Answer2C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer2C");
        Level3CorrectAnswer2 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer2");
        Level3Question3 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Question3");
        Level3Answer3A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer3A");
        Level3Answer3B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer3B");
        Level3Answer3C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer3C");
        Level3CorrectAnswer3 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer3");
        Level3Question4 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Question4");
        Level3Answer4A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer4A");
        Level3Answer4B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer4B");
        Level3Answer4C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level3Answer4C");
        Level3CorrectAnswer4 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3CorrectAnswer4");
        Level3EnvID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3EnvID");
        Level3ChID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3ChID");
        Level3ProfessorID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level3ProfessorID");

        Level4Question1 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Question1");
        Level4Answer1A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer1A");
        Level4Answer1B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer1B");
        Level4Answer1C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer1C");
        Level4CorrectAnswer1 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer1");
        Level4Question2 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Question2");
        Level4Answer2A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer2A");
        Level4Answer2B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer2B");
        Level4Answer2C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer2C");
        Level4CorrectAnswer2 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer2");
        Level4Question3 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Question3");
        Level4Answer3A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer3A");
        Level4Answer3B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer3B");
        Level4Answer3C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer3C");
        Level4CorrectAnswer3 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer3");
        Level4Question4 = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Question4");
        Level4Answer4A = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer4A");
        Level4Answer4B = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer4B");
        Level4Answer4C = PlayerPrefs.GetString(SaveSlot + username + StudentID + "Level4Answer4C");
        Level4CorrectAnswer4 = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4CorrectAnswer4");
        Level4EnvID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4EnvID");
        Level4ChID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4ChID");
        Level4ProfessorID = PlayerPrefs.GetInt(SaveSlot + username + StudentID + "Level4ProfessorID");

        // Overwrite PlayerPrefs

        PlayerPrefs.SetString(username + StudentID + "Level1Question1", Level1Question1);
        Debug.Log("Loaded Level 1 Question 1 : " + Level1Question1 + "from" + SaveSlot);
        Debug.Log(username + StudentID + PlayerPrefs.GetString(username + StudentID + "Level" + 1 + "Question" + 1));
        PlayerPrefs.SetString(username + StudentID + "Level1Answer1A", Level1Answer1A);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer1B", Level1Answer1B);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer1C", Level1Answer1C);
        PlayerPrefs.SetInt(username + StudentID + "Level1CorrectAnswer1", Level1CorrectAnswer1);

        PlayerPrefs.SetString(username + StudentID + "Level1Question2", Level1Question2);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer2A", Level1Answer2A);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer2B", Level1Answer2B);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer2C", Level1Answer2C);
        PlayerPrefs.SetInt(username + StudentID + "Level1CorrectAnswer2", Level1CorrectAnswer2);

        PlayerPrefs.SetString(username + StudentID + "Level1Question3", Level1Question3);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer3A", Level1Answer3A);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer3B", Level1Answer3B);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer3C", Level1Answer3C);
        PlayerPrefs.SetInt(username + StudentID + "Level1CorrectAnswer3", Level1CorrectAnswer3);

        PlayerPrefs.SetString(username + StudentID + "Level1Question4", Level1Question4);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer4A", Level1Answer4A);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer4B", Level1Answer4B);
        PlayerPrefs.SetString(username + StudentID + "Level1Answer4C", Level1Answer4C);
        PlayerPrefs.SetInt(username + StudentID + "Level1CorrectAnswer4", Level1CorrectAnswer4);

        PlayerPrefs.SetInt(username + StudentID + "Level1EnvID", Level1EnvID);
        PlayerPrefs.SetInt(username + StudentID + "Level1ChID", Level1ChID);
        PlayerPrefs.SetInt(username + StudentID + "Level1ProfessorID", Level1ProfessorID);

        PlayerPrefs.SetString(username + StudentID + "Level2Question1", Level2Question1);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer1A", Level2Answer1A);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer1B", Level2Answer1B);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer1C", Level2Answer1C);
        PlayerPrefs.SetInt(username + StudentID + "Level2CorrectAnswer1", Level2CorrectAnswer1);

        PlayerPrefs.SetString(username + StudentID + "Level2Question2", Level2Question2);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer2A", Level2Answer2A);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer2B", Level2Answer2B);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer2C", Level2Answer2C);
        PlayerPrefs.SetInt(username + StudentID + "Level2CorrectAnswer2", Level2CorrectAnswer2);

        PlayerPrefs.SetString(username + StudentID + "Level2Question3", Level2Question3);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer3A", Level2Answer3A);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer3B", Level2Answer3B);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer3C", Level2Answer3C);
        PlayerPrefs.SetInt(username + StudentID + "Level2CorrectAnswer3", Level2CorrectAnswer3);

        PlayerPrefs.SetString(username + StudentID + "Level2Question4", Level2Question4);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer4A", Level2Answer4A);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer4B", Level2Answer4B);
        PlayerPrefs.SetString(username + StudentID + "Level2Answer4C", Level2Answer4C);
        PlayerPrefs.SetInt(username + StudentID + "Level2CorrectAnswer4", Level2CorrectAnswer4);

        PlayerPrefs.SetInt(username + StudentID + "Level2EnvID", Level2EnvID);
        PlayerPrefs.SetInt(username + StudentID + "Level2ChID", Level2ChID);
        PlayerPrefs.SetInt(username + StudentID + "Level2ProfessorID", Level2ProfessorID);

        PlayerPrefs.SetString(username + StudentID + "Level3Question1", Level3Question1);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer1A", Level3Answer1A);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer1B", Level3Answer1B);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer1C", Level3Answer1C);
        PlayerPrefs.SetInt(username + StudentID + "Level3CorrectAnswer1", Level3CorrectAnswer1);

        PlayerPrefs.SetString(username + StudentID + "Level3Question2", Level3Question2);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer2A", Level3Answer2A);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer2B", Level3Answer2B);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer2C", Level3Answer2C);
        PlayerPrefs.SetInt(username + StudentID + "Level3CorrectAnswer2", Level3CorrectAnswer2);

        PlayerPrefs.SetString(username + StudentID + "Level3Question3", Level3Question3);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer3A", Level3Answer3A);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer3B", Level3Answer3B);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer3C", Level3Answer3C);
        PlayerPrefs.SetInt(username + StudentID + "Level3CorrectAnswer3", Level3CorrectAnswer3);

        PlayerPrefs.SetString(username + StudentID + "Level3Question4", Level3Question4);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer4A", Level3Answer4A);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer4B", Level3Answer4B);
        PlayerPrefs.SetString(username + StudentID + "Level3Answer4C", Level3Answer4C);
        PlayerPrefs.SetInt(username + StudentID + "Level3CorrectAnswer4", Level3CorrectAnswer4);

        PlayerPrefs.SetInt(username + StudentID + "Level3EnvID", Level3EnvID);
        PlayerPrefs.SetInt(username + StudentID + "Level3ChID", Level3ChID);
        PlayerPrefs.SetInt(username + StudentID + "Level3ProfessorID", Level3ProfessorID);

        PlayerPrefs.SetString(username + StudentID + "Level4Question1", Level4Question1);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer1A", Level4Answer1A);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer1B", Level4Answer1B);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer1C", Level4Answer1C);
        PlayerPrefs.SetInt(username + StudentID + "Level4CorrectAnswer1", Level4CorrectAnswer1);

        PlayerPrefs.SetString(username + StudentID + "Level4Question2", Level4Question2);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer2A", Level4Answer2A);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer2B", Level4Answer2B);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer2C", Level4Answer2C);
        PlayerPrefs.SetInt(username + StudentID + "Level4CorrectAnswer2", Level4CorrectAnswer2);

        PlayerPrefs.SetString(username + StudentID + "Level4Question3", Level4Question3);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer3A", Level4Answer3A);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer3B", Level4Answer3B);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer3C", Level4Answer3C);
        PlayerPrefs.SetInt(username + StudentID + "Level4CorrectAnswer3", Level4CorrectAnswer3);

        PlayerPrefs.SetString(username + StudentID + "Level4Question4", Level4Question4);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer4A", Level4Answer4A);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer4B", Level4Answer4B);
        PlayerPrefs.SetString(username + StudentID + "Level4Answer4C", Level4Answer4C);
        PlayerPrefs.SetInt(username + StudentID + "Level4CorrectAnswer4", Level4CorrectAnswer4);

        PlayerPrefs.SetInt(username + StudentID + "Level4EnvID", Level4EnvID);
        PlayerPrefs.SetInt(username+StudentID+"Level4ChID", Level4ChID);
        PlayerPrefs.SetInt(username+StudentID+"Level4ProfessorID", Level4ProfessorID);

    }


}
