using UnityEngine;
using System.Collections;
using UnityEngine.Networking; // Required for UnityWebRequest
using TMPro;
public class JsonReceiver : MonoBehaviour
{
    public string phpScriptURL = "http://yourserver.com/data.php"; // Replace with your PHP script's URL
    public TextMeshProUGUI DATA_PlayerName;
    public TextMeshProUGUI DATA_Score;
    public TextMeshProUGUI DATA_Health;

    // Define a class to match your JSON structure
    [System.Serializable]
    public class MyData
    {
        public string playerName;
        public int score;
        public float health;
        // Add other fields as per your JSON
    }

    void Start()
    {
        StartCoroutine(FetchJsonData());
    }

    IEnumerator FetchJsonData()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(phpScriptURL))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string jsonString = webRequest.downloadHandler.text;
                Debug.Log("Received JSON: " + jsonString);

                // Deserialize the JSON string
                MyData data = JsonUtility.FromJson<MyData>(jsonString);

                Debug.Log("Parsed Name: " + data.playerName);
                Debug.Log("Parsed Value: " + data.score);
                Debug.Log("Parsed Value: " + data.health);

                DATA_PlayerName.text = "Name = " + data.playerName;
                DATA_Score.text = "Score = " + data.score;
                DATA_Health.text = "Health = " + data.health;

            }
            else
            {
                Debug.LogError("Error fetching JSON: " + webRequest.error);
                DATA_PlayerName.text = "Error fetching JSON: " + webRequest.error;
            }
        }
    }
}