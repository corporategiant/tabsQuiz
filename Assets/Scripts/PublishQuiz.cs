using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class PublishQuiz : MonoBehaviour
{
    public string phpUrl;
    public string SceneToLoad;
    public string username;
    public string StudentID;

    public int NumberOfLevels;

    public GameObject PublishedPanel;
    public GameObject TestQuizPublishQuizPanel;
    public GameObject PublishErrorMessage;

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

    // Example data structure to serialize to JSON
    [System.Serializable]
    public class PlayerData
    {
        public string username;
        public string StudentID;
        public int NumberOfLevels;
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
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        Debug.Log("Publish Quiz Username Set");
        StudentID = PlayerPrefs.GetString("StudentID");
        
        phpUrl = "https://www.corporategiant.co.uk/tabsQuizData/" + username + StudentID + "/write_json.php";
    }

    public void StartPublishQuiz()
    {
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        NumberOfLevels = PlayerPrefs.GetInt(username + StudentID + "NumberOfLevels");

        Level1EnvID = PlayerPrefs.GetInt(username+StudentID+"Level1EnvID");
        Debug.Log(username+StudentID+"Level1EnvID = "+PlayerPrefs.GetInt(username+StudentID+"Level1EnvID"));

        Level1Question1 = PlayerPrefs.GetString(username+StudentID+"Level1Question1");
        Debug.Log(username+StudentID+"Level1 Question1 = "+PlayerPrefs.GetInt(username+StudentID+"Level1Question1"));
        Level1Answer1A = PlayerPrefs.GetString(username+StudentID+"Level1Answer1A");
        Level1Answer1B = PlayerPrefs.GetString(username+StudentID+"Level1Answer1B");
        Level1Answer1C = PlayerPrefs.GetString(username+StudentID+"Level1Answer1C");
        Level1CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer1");
        Level1Question2 = PlayerPrefs.GetString(username+StudentID+"Level1Question2");
        Level1Answer2A = PlayerPrefs.GetString(username+StudentID+"Level1Answer2A");
        Level1Answer2B = PlayerPrefs.GetString(username+StudentID+"Level1Answer2B");
        Level1Answer2C = PlayerPrefs.GetString(username+StudentID+"Level1Answer2C");
        Level1CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer2");
        Level1Question3 = PlayerPrefs.GetString(username+StudentID+"Level1Question3");
        Level1Answer3A = PlayerPrefs.GetString(username+StudentID+"Level1Answer3A");
        Level1Answer3B = PlayerPrefs.GetString(username+StudentID+"Level1Answer3B");
        Level1Answer3C = PlayerPrefs.GetString(username+StudentID+"Level1Answer3C");
        Level1CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer3");
        Level1Question4 = PlayerPrefs.GetString(username+StudentID+"Level1Question4");
        Level1Answer4A = PlayerPrefs.GetString(username+StudentID+"Level1Answer4A");
        Level1Answer4B = PlayerPrefs.GetString(username+StudentID+"Level1Answer4B");
        Level1Answer4C = PlayerPrefs.GetString(username+StudentID+"Level1Answer4C");
        Level1CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer4");
        Level1EnvID = PlayerPrefs.GetInt(username+StudentID+"Level1EnvID");
        Level1ChID = PlayerPrefs.GetInt(username+StudentID+"Level1ChID");
        Level1ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level1ProfessorID");
        Debug.Log(username+StudentID+"Level1 Professor ID = " + Level1ProfessorID);


        Level2Question1 = PlayerPrefs.GetString(username+StudentID+"Level2Question1");
        Level2Answer1A = PlayerPrefs.GetString(username+StudentID+"Level2Answer1A");
        Level2Answer1B = PlayerPrefs.GetString(username+StudentID+"Level2Answer1B");
        Level2Answer1C = PlayerPrefs.GetString(username+StudentID+"Level2Answer1C");
        Level2CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer1");
        Level2Question2 = PlayerPrefs.GetString(username+StudentID+"Level2Question2");
        Level2Answer2A = PlayerPrefs.GetString(username+StudentID+"Level2Answer2A");
        Level2Answer2B = PlayerPrefs.GetString(username+StudentID+"Level2Answer2B");
        Level2Answer2C = PlayerPrefs.GetString(username+StudentID+"Level2Answer2C");
        Level2CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer2");
        Level2Question3 = PlayerPrefs.GetString(username+StudentID+"Level2Question3");
        Level2Answer3A = PlayerPrefs.GetString(username+StudentID+"Level2Answer3A");
        Level2Answer3B = PlayerPrefs.GetString(username+StudentID+"Level2Answer3B");
        Level2Answer3C = PlayerPrefs.GetString(username+StudentID+"Level2Answer3C");
        Level2CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer3");
        Level2Question4 = PlayerPrefs.GetString(username+StudentID+"Level2Question4");
        Level2Answer4A = PlayerPrefs.GetString(username+StudentID+"Level2Answer4A");
        Level2Answer4B = PlayerPrefs.GetString(username+StudentID+"Level2Answer4B");
        Level2Answer4C = PlayerPrefs.GetString(username+StudentID+"Level2Answer4C");
        Level2CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer4");
        Level2EnvID = PlayerPrefs.GetInt(username+StudentID+"Level2EnvID");
        Level2ChID = PlayerPrefs.GetInt(username+StudentID+"Level2ChID");
        Level2ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level2ProfessorID");

        Level3Question1 = PlayerPrefs.GetString(username+StudentID+"Level3Question1");
        Level3Answer1A = PlayerPrefs.GetString(username+StudentID+"Level3Answer1A");
        Level3Answer1B = PlayerPrefs.GetString(username+StudentID+"Level3Answer1B");
        Level3Answer1C = PlayerPrefs.GetString(username+StudentID+"Level3Answer1C");
        Level3CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer1");
        Level3Question2 = PlayerPrefs.GetString(username+StudentID+"Level3Question2");
        Level3Answer2A = PlayerPrefs.GetString(username+StudentID+"Level3Answer2A");
        Level3Answer2B = PlayerPrefs.GetString(username+StudentID+"Level3Answer2B");
        Level3Answer2C = PlayerPrefs.GetString(username+StudentID+"Level3Answer2C");
        Level3CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer2");
        Level3Question3 = PlayerPrefs.GetString(username+StudentID+"Level3Question3");
        Level3Answer3A = PlayerPrefs.GetString(username+StudentID+"Level3Answer3A");
        Level3Answer3B = PlayerPrefs.GetString(username+StudentID+"Level3Answer3B");
        Level3Answer3C = PlayerPrefs.GetString(username+StudentID+"Level3Answer3C");
        Level3CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer3");
        Level3Question4 = PlayerPrefs.GetString(username+StudentID+"Level3Question4");
        Level3Answer4A = PlayerPrefs.GetString(username+StudentID+"Level3Answer4A");
        Level3Answer4B = PlayerPrefs.GetString(username+StudentID+"Level3Answer4B");
        Level3Answer4C = PlayerPrefs.GetString(username+StudentID+"Level3Answer4C");
        Level3CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer4");
        Level3EnvID = PlayerPrefs.GetInt(username+StudentID+"Level3EnvID");
        Level3ChID = PlayerPrefs.GetInt(username+StudentID+"Level3ChID");
        Level3ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level3ProfessorID");

        Level4Question1 = PlayerPrefs.GetString(username+StudentID+"Level4Question1");
        Level4Answer1A = PlayerPrefs.GetString(username+StudentID+"Level4Answer1A");
        Level4Answer1B = PlayerPrefs.GetString(username+StudentID+"Level4Answer1B");
        Level4Answer1C = PlayerPrefs.GetString(username+StudentID+"Level4Answer1C");
        Level4CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer1");
        Level4Question2 = PlayerPrefs.GetString(username+StudentID+"Level4Question2");
        Level4Answer2A = PlayerPrefs.GetString(username+StudentID+"Level4Answer2A");
        Level4Answer2B = PlayerPrefs.GetString(username+StudentID+"Level4Answer2B");
        Level4Answer2C = PlayerPrefs.GetString(username+StudentID+"Level4Answer2C");
        Level4CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer2");
        Level4Question3 = PlayerPrefs.GetString(username+StudentID+"Level4Question3");
        Level4Answer3A = PlayerPrefs.GetString(username+StudentID+"Level4Answer3A");
        Level4Answer3B = PlayerPrefs.GetString(username+StudentID+"Level4Answer3B");
        Level4Answer3C = PlayerPrefs.GetString(username+StudentID+"Level4Answer3C");
        Level4CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer3");
        Level4Question4 = PlayerPrefs.GetString(username+StudentID+"Level4Question4");
        Level4Answer4A = PlayerPrefs.GetString(username+StudentID+"Level4Answer4A");
        Level4Answer4B = PlayerPrefs.GetString(username+StudentID+"Level4Answer4B");
        Level4Answer4C = PlayerPrefs.GetString(username+StudentID+"Level4Answer4C");
        Level4CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer4");
        Level4EnvID = PlayerPrefs.GetInt(username+StudentID+"Level4EnvID");
        Level4ChID = PlayerPrefs.GetInt(username+StudentID+"Level4ChID");
        Level4ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level4ProfessorID");

        // Create an instance of your data
        PlayerData dataToSend = new PlayerData
        {
            username = PlayerPrefs.GetString("username"),
            StudentID = PlayerPrefs.GetString("StudentID"),

            NumberOfLevels = PlayerPrefs.GetInt(username + StudentID + "NumberOfLevels"),
            
            
            Level1Question1 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Question1")),
            Level1Answer1A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer1A")),
            Level1Answer1B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer1B")),
            Level1Answer1C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer1C")),
            Level1CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer1"),
            Level1Question2 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Question2")),
            Level1Answer2A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer2A")),
            Level1Answer2B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer2B")),
            Level1Answer2C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer2C")),
            Level1CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer2"),
            Level1Question3 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Question3")),
            Level1Answer3A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer3A")),
            Level1Answer3B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer3B")),
            Level1Answer3C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer3C")),
            Level1CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer3"),
            Level1Question4 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Question4")),
            Level1Answer4A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer4A")),
            Level1Answer4B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer4B")),
            Level1Answer4C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level1Answer4C")),
            Level1CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level1CorrectAnswer4"),
            Level1EnvID = PlayerPrefs.GetInt(username+StudentID+"Level1EnvID"),
            Level1ChID = PlayerPrefs.GetInt(username+StudentID+"Level1ChID"),
            Level1ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level1ProfessorID"),

            
            Level2Question1 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Question1")),
            Level2Answer1A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer1A")),
            Level2Answer1B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer1B")),
            Level2Answer1C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer1C")),
            Level2CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer1"),
            Level2Question2 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Question2")),
            Level2Answer2A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer2A")),
            Level2Answer2B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer2B")),
            Level2Answer2C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer2C")),
            Level2CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer2"),
            Level2Question3 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Question3")),
            Level2Answer3A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer3A")),
            Level2Answer3B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer3B")),
            Level2Answer3C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer3C")),
            Level2CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer3"),
            Level2Question4 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Question4")),
            Level2Answer4A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer4A")),
            Level2Answer4B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer4B")),
            Level2Answer4C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level2Answer4C")),
            Level2CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level2CorrectAnswer4"),
            Level2EnvID = PlayerPrefs.GetInt(username+StudentID+"Level2EnvID"),
            Level2ChID = PlayerPrefs.GetInt(username+StudentID+"Level2ChID"),
            Level2ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level2ProfessorID"),

            Level3Question1 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Question1")),
            Level3Answer1A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer1A")),
            Level3Answer1B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer1B")),
            Level3Answer1C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer1C")),
            Level3CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer1"),
            Level3Question2 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Question2")),
            Level3Answer2A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer2A")),
            Level3Answer2B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer2B")),
            Level3Answer2C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer2C")),
            Level3CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer2"),
            Level3Question3 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Question3")),
            Level3Answer3A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer3A")),
            Level3Answer3B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer3B")),
            Level3Answer3C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer3C")),
            Level3CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer3"),
            Level3Question4 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Question4")),
            Level3Answer4A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer4A")),
            Level3Answer4B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer4B")),
            Level3Answer4C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level3Answer4C")),
            Level3CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level3CorrectAnswer4"),
            Level3EnvID = PlayerPrefs.GetInt(username+StudentID+"Level3EnvID"),
            Level3ChID = PlayerPrefs.GetInt(username+StudentID+"Level3ChID"),
            Level3ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level3ProfessorID"),

            Level4Question1 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Question1")),
            Level4Answer1A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer1A")),
            Level4Answer1B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer1B")),
            Level4Answer1C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer1C")),
            Level4CorrectAnswer1 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer1"),
            Level4Question2 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Question2")),
            Level4Answer2A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer2A")),
            Level4Answer2B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer2B")),
            Level4Answer2C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer2C")),
            Level4CorrectAnswer2 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer2"),
            Level4Question3 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Question3")),
            Level4Answer3A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer3A")),
            Level4Answer3B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer3B")),
            Level4Answer3C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer3C")),
            Level4CorrectAnswer3 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer3"),
            Level4Question4 = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Question4")),
            Level4Answer4A = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer4A")),
            Level4Answer4B = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer4B")),
            Level4Answer4C = RemoveZeroWidthSpaces(PlayerPrefs.GetString(username+StudentID+"Level4Answer4C")),
            Level4CorrectAnswer4 = PlayerPrefs.GetInt(username+StudentID+"Level4CorrectAnswer4"),
            Level4EnvID = PlayerPrefs.GetInt(username+StudentID+"Level4EnvID"),
            Level4ChID = PlayerPrefs.GetInt(username+StudentID+"Level4ChID"),
            Level4ProfessorID = PlayerPrefs.GetInt(username+StudentID+"Level4ProfessorID")
        };

        // Convert the data object to a JSON string
        string json = JsonUtility.ToJson(dataToSend);
        Debug.Log("PublishQuiz : Starting SendJsonToServer");

        // Send the JSON data to the PHP script
        StartCoroutine(SendJsonToServer(json));
    }

    IEnumerator SendJsonToServer(string jsonData)
    {
        Debug.Log("PublishQuiz : SendingJsonToServer");
        // Create a UnityWebRequest for a POST request
        UnityWebRequest request = new UnityWebRequest(phpUrl, "POST");

        // Convert the JSON string to bytes
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);

        // Set the upload handler with the raw data
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);

        // Set the download handler to receive the server's response
        request.downloadHandler = new DownloadHandlerBuffer();

        // Set the Content-Type header to indicate JSON data
        request.SetRequestHeader("Content-Type", "application/json");

        // Send the request
        yield return request.SendWebRequest();


        // Check for errors
        Debug.Log("PublishQuiz : Checking errors");

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error sending JSON: " + request.error);
            PublishErrorMessage.SetActive(true);
            //PublishErrorMessage.GetComponent<TextMeshProUGUI>().text = request.error;

        }
        else
        {
            PublishErrorMessage.SetActive(false);
            TestQuizPublishQuizPanel.SetActive(false);
            PublishedPanel.SetActive(true);

            Debug.Log("JSON sent successfully. Server response: " + request.downloadHandler.text);
        }
    }

    public void PlayQuiz()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }

        public string RemoveZeroWidthSpaces(string inputString)
    {
        // The Unicode character for zero-width space is \u200b
        return inputString.Replace("\u200b", "");
    }
}
