using UnityEngine;
using System.Collections;
using UnityEngine.Networking; // Required for UnityWebRequest
using TMPro;

public class JsonReceiver : MonoBehaviour
{
    public string phpScriptURL = "http://yourserver.com/data.php"; // Replace with your PHP script's URL
    public TextMeshProUGUI Question1;
    
    

    // Define a class to match your JSON structure
    [System.Serializable]
    public class MyData
    {
        public string Level1Question1;
        // Add other fields as per your JSON
    }

    public void FetchData()
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

                Debug.Log("Question 1 : " + data.Level1Question1);
                Question1.text = data.Level1Question1;

            }
            else
            {
                Debug.LogError("Error fetching JSON: " + webRequest.error);
            }
        }
    }
}