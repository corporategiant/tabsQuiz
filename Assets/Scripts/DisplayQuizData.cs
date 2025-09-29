using UnityEngine;
using System.Collections;
using UnityEngine.Networking; // Required for UnityWebRequest

public class DisplayQuizData : MonoBehaviour
{
    public string phpScriptURL;
    public string username;
    public string StudentID;
    // Define a class to match your JSON structure
    [System.Serializable]
    public class MyData
    {
        public string userName;
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
        // Add other fields as per your JSON
    }

    void Start()
    {
       username = PlayerPrefs.GetString("username");
       StudentID = PlayerPrefs.GetString("StudentID");    
       phpScriptURL = "https://www.corporategiant.co.uk/tabsQuizData/"+username+StudentID+"/get_data.php";
    
    }

    public void StartDisplayQuizData()
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

                Debug.Log("Parsed Name: " + data.userName);
                Debug.Log("Parsed Value: " + data.Question1);
                Debug.Log("Parsed Value: " + data.Answer1A);
                Debug.Log("Parsed Value: " + data.Answer1B);
                Debug.Log("Parsed Value: " + data.Answer1C);
            }
            else
            {
                Debug.LogError("Error fetching JSON: " + webRequest.error);
            }
        }
    }
}