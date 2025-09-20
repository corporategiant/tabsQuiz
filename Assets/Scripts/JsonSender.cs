using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class JsonSender : MonoBehaviour
{
    public string phpUrl = "http://yourserver.com/write_json.php"; // Replace with your PHP script URL

    // Example data structure to serialize to JSON
    [System.Serializable]
    public class PlayerData
    {
        public string playerName;
        public int score;
        public float health;
    }

    void Start()
    {
        // Create an instance of your data
        PlayerData dataToSend = new PlayerData
        {
            playerName = "UnityPlayer",
            score = 12345,
            health = 98.7f
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
