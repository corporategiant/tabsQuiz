using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.Networking; // Required for UnityWebRequest

public class LoadQuizData : MonoBehaviour
{
    public string phpUrl;
    //public TextMeshProUGUI Question1;
    public string SceneToLoad;
    public string username;
    public string StudentID;
    public string QuizMasterusername;
    public string QuizMasterStudentID;
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

    [Header("Level 2")]

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
    
    [Header("Level 3")]
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

    [Header("Level 4")]
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

    // Example data structure to serialize to JSON
    [System.Serializable]
    public class MyData
    {
        public string Quizusername;
        public string QuizStudentID;
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
    }


    



    public void StartLoadQuizData()
    {
        phpUrl = PlayerPrefs.GetString("QRQuizURL") + "get_data.php";
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        StartCoroutine(FetchJsonData());
    }

    IEnumerator FetchJsonData()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(phpUrl))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string jsonString = webRequest.downloadHandler.text;
                Debug.Log("Received JSON: " + jsonString);

                // Deserialize the JSON string
                MyData data = JsonUtility.FromJson<MyData>(jsonString);

                Debug.Log("Question 1 : " + data.Level1Question1);
                QuizMasterusername = data.Quizusername;
                QuizMasterStudentID = data.QuizStudentID;
                Level1Question1 = data.Level1Question1;
                Level1Answer1A = data.Level1Answer1A;
                Level1Answer1B = data.Level1Answer1B;
                Level1Answer1C = data.Level1Answer1C;
                Level1CorrectAnswer1 = data.Level1CorrectAnswer1;

                Level1Question2 = data.Level1Question2;
                Level1Answer2A = data.Level1Answer2A;
                Level1Answer2B = data.Level1Answer2B;
                Level1Answer2C = data.Level1Answer2C;
                Level1CorrectAnswer2 = data.Level1CorrectAnswer2;

                Level1Question3 = data.Level1Question3;
                Level1Answer3A = data.Level1Answer3A;
                Level1Answer3B = data.Level1Answer3B;
                Level1Answer3C = data.Level1Answer3C;
                Level1CorrectAnswer3 = data.Level1CorrectAnswer3;

                Level1Question4 = data.Level1Question4;
                Level1Answer4A = data.Level1Answer4A;
                Level1Answer4B = data.Level1Answer4B;
                Level1Answer4C = data.Level1Answer4C;
                Level1CorrectAnswer4 = data.Level1CorrectAnswer4;

                Level1EnvID = data.Level1EnvID;
                Level1ChID = data.Level1ChID;
                Level1ProfessorID = data.Level1ProfessorID;

                Level2Question1 = data.Level2Question1;
                Level2Answer1A = data.Level2Answer1A;
                Level2Answer1B = data.Level2Answer1B;
                Level2Answer1C = data.Level2Answer1C;
                Level2CorrectAnswer1 = data.Level2CorrectAnswer1;

                Level2Question2 = data.Level2Question2;
                Level2Answer2A = data.Level2Answer2A;
                Level2Answer2B = data.Level2Answer2B;
                Level2Answer2C = data.Level2Answer2C;
                Level2CorrectAnswer2 = data.Level2CorrectAnswer2;

                Level2Question3 = data.Level2Question3;
                Level2Answer3A = data.Level2Answer3A;
                Level2Answer3B = data.Level2Answer3B;
                Level2Answer3C = data.Level2Answer3C;
                Level2CorrectAnswer3 = data.Level2CorrectAnswer3;

                Level2Question4 = data.Level2Question4;
                Level2Answer4A = data.Level2Answer4A;
                Level2Answer4B = data.Level2Answer4B;
                Level2Answer4C = data.Level2Answer4C;
                Level2CorrectAnswer4 = data.Level2CorrectAnswer4;

                Level2EnvID = data.Level2EnvID;
                Level2ChID = data.Level2ChID;
                Level2ProfessorID = data.Level2ProfessorID;

                Level3Question1 = data.Level3Question1;
                Level3Answer1A = data.Level3Answer1A;
                Level3Answer1B = data.Level3Answer1B;
                Level3Answer1C = data.Level3Answer1C;
                Level3CorrectAnswer1 = data.Level3CorrectAnswer1;

                Level3Question2 = data.Level3Question2;
                Level3Answer2A = data.Level3Answer2A;
                Level3Answer2B = data.Level3Answer2B;
                Level3Answer2C = data.Level3Answer2C;
                Level3CorrectAnswer2 = data.Level3CorrectAnswer2;

                Level3Question3 = data.Level3Question3;
                Level3Answer3A = data.Level3Answer3A;
                Level3Answer3B = data.Level3Answer3B;
                Level3Answer3C = data.Level3Answer3C;
                Level3CorrectAnswer3 = data.Level3CorrectAnswer3;

                Level3Question4 = data.Level3Question4;
                Level3Answer4A = data.Level3Answer4A;
                Level3Answer4B = data.Level3Answer4B;
                Level3Answer4C = data.Level3Answer4C;
                Level3CorrectAnswer4 = data.Level3CorrectAnswer4;

                Level3EnvID = data.Level3EnvID;
                Level3ChID = data.Level3ChID;
                Level3ProfessorID = data.Level3ProfessorID;

                Level4Question1 = data.Level4Question1;
                Level4Answer1A = data.Level4Answer1A;
                Level4Answer1B = data.Level4Answer1B;
                Level4Answer1C = data.Level4Answer1C;
                Level4CorrectAnswer1 = data.Level4CorrectAnswer1;

                Level4Question2 = data.Level4Question2;
                Level4Answer2A = data.Level4Answer2A;
                Level4Answer2B = data.Level4Answer2B;
                Level4Answer2C = data.Level4Answer2C;
                Level4CorrectAnswer2 = data.Level4CorrectAnswer2;

                Level4Question3 = data.Level4Question3;
                Level4Answer3A = data.Level4Answer3A;
                Level4Answer3B = data.Level4Answer3B;
                Level4Answer3C = data.Level4Answer3C;
                Level4CorrectAnswer3 = data.Level4CorrectAnswer3;

                Level4Question4 = data.Level4Question4;
                Level4Answer4A = data.Level4Answer4A;
                Level4Answer4B = data.Level4Answer4B;
                Level4Answer4C = data.Level4Answer4C;
                Level4CorrectAnswer4 = data.Level4CorrectAnswer4;

                Level4EnvID = data.Level4EnvID;
                Level4ChID = data.Level4ChID;
                Level4ProfessorID = data.Level4ProfessorID;
                
                OverwritePlayerPrefs();
            }
            else
            {
                Debug.LogError("Error fetching JSON: " + webRequest.error);
            }
        }
        
    }
    public void OverwritePlayerPrefs()
    {
        //Question1.text = PlayerPrefs.GetString("Level1Question1");
        Debug.Log("Level 1 Question 1 = " + PlayerPrefs.GetString(username + StudentID + "Level1Question1"));

        PlayerPrefs.SetString("QuizMasterusername", QuizMasterusername);
        PlayerPrefs.SetString("QuizMasterStudentID", QuizMasterStudentID);
        PlayerPrefs.SetString(username + StudentID + "Level1Question1", Level1Question1);
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