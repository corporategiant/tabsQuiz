using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PublishQuiz : MonoBehaviour
{
    public string phpUrl = "https://www.corporategiant.co.uk/tabsQuizData/write_json.php"; // Replace with your PHP script URL
        public string username;
        public string Question1;
        public string Answer1A;
        public string Answer1B;
        public string Answer1C;
        public int CorrectAnswer1;
        public string Question2;
        public string Answer2A;
        public string Answer2B;
        public string Answer2C;
        public int CorrectAnswer2;
        public string Question3;
        public string Answer3A;
        public string Answer3B;
        public string Answer3C;
        public int CorrectAnswer3;
        public string Question4;
        public string Answer4A;
        public string Answer4B;
        public string Answer4C;
        public int CorrectAnswer4;
        public int EnvID;
    // Example data structure to serialize to JSON
    [System.Serializable]
    public class PlayerData
    {
        public string username;
        public string Question1;
        public string Answer1A;
        public string Answer1B;
        public string Answer1C;
        public int CorrectAnswer1;
        public string Question2;
        public string Answer2A;
        public string Answer2B;
        public string Answer2C;
        public int CorrectAnswer2;
        public string Question3;
        public string Answer3A;
        public string Answer3B;
        public string Answer3C;
        public int CorrectAnswer3;
        public string Question4;
        public string Answer4A;
        public string Answer4B;
        public string Answer4C;
        public int CorrectAnswer4;
        public int EnvID;

        
    }

    public void StartPublishQuiz()
    {
        username = PlayerPrefs.GetString("username");
        EnvID = PlayerPrefs.GetInt("EnvID");
        Question1 = PlayerPrefs.GetString("Question1");
        Answer1A = PlayerPrefs.GetString("Answer1A");
        Answer1B = PlayerPrefs.GetString("Answer1B");
        Answer1C = PlayerPrefs.GetString("Answer1C");
        CorrectAnswer1 = PlayerPrefs.GetInt("CorrectAnswer1");
        Question2 = PlayerPrefs.GetString("Question2");
        Answer2A = PlayerPrefs.GetString("Answer2A");
        Answer2B = PlayerPrefs.GetString("Answer2B");
        Answer2C = PlayerPrefs.GetString("Answer2C");
        CorrectAnswer2 = PlayerPrefs.GetInt("CorrectAnswer2");
        Question3 = PlayerPrefs.GetString("Question3");
        Answer3A = PlayerPrefs.GetString("Answer3A");
        Answer3B = PlayerPrefs.GetString("Answer3B");
        Answer3C = PlayerPrefs.GetString("Answer3C");
        CorrectAnswer3 = PlayerPrefs.GetInt("CorrectAnswer3");    
        Question4 = PlayerPrefs.GetString("Question4");
        Answer4A = PlayerPrefs.GetString("Answer4A");
        Answer4B = PlayerPrefs.GetString("Answer4B");
        Answer4C = PlayerPrefs.GetString("Answer4C");
        CorrectAnswer4 = PlayerPrefs.GetInt("CorrectAnswer4");
            
        // Create an instance of your data
        PlayerData dataToSend = new PlayerData
        {
            username = PlayerPrefs.GetString("username"),
            EnvID = PlayerPrefs.GetInt("EnvID"),
            Question1 = PlayerPrefs.GetString("Question1"),
            Answer1A = PlayerPrefs.GetString("Answer1A"),
            Answer1B = PlayerPrefs.GetString("Answer1B"),
            Answer1C = PlayerPrefs.GetString("Answer1C"),
            CorrectAnswer1 = PlayerPrefs.GetInt("CorrectAnswer1"),
            Question2 = PlayerPrefs.GetString("Question2"),
            Answer2A = PlayerPrefs.GetString("Answer2A"),
            Answer2B = PlayerPrefs.GetString("Answer2B"),
            Answer2C = PlayerPrefs.GetString("Answer2C"),
            CorrectAnswer2 = PlayerPrefs.GetInt("CorrectAnswer2"),
            Question3 = PlayerPrefs.GetString("Question3"),
            Answer3A = PlayerPrefs.GetString("Answer3A"),
            Answer3B = PlayerPrefs.GetString("Answer3B"),
            Answer3C = PlayerPrefs.GetString("Answer3C"),
            CorrectAnswer3 = PlayerPrefs.GetInt("CorrectAnswer3"),    
            Question4 = PlayerPrefs.GetString("Question4"),
            Answer4A = PlayerPrefs.GetString("Answer4A"),
            Answer4B = PlayerPrefs.GetString("Answer4B"),
            Answer4C = PlayerPrefs.GetString("Answer4C"),
            CorrectAnswer4 = PlayerPrefs.GetInt("CorrectAnswer4"),                
        };

        // Convert the data object to a JSON string
        string json = JsonUtility.ToJson(dataToSend);

        // Send the JSON data to the PHP script
        StartCoroutine(SendJsonToServer(json));
    }

    IEnumerator SendJsonToServer(string jsonData)
    {
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
        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error sending JSON: " + request.error);
        }
        else
        {
            Debug.Log("JSON sent successfully. Server response: " + request.downloadHandler.text);
        }
    }
}
