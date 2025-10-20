    using UnityEngine;
    using UnityEngine.Networking;
    using System.Collections;
    using System.Collections.Generic; // For List<T>

[System.Serializable]
public class StampsData // Define a class matching your JSON structure
{
    public string username;
    public string StudentID;
    public List<string> quizMastersData; // Example: a list of strings
    

}

public class AddStampv2 : MonoBehaviour
{
    public string username;
    public string StudentID;
    private const string JsonUrl = "https://corporategiant.co.uk/tabsQuizData/stampsData.php"; // Replace with your PHP endpoint
    public List<GameObject> Stamps;
    public List<string> quizMasters;
    public bool checkAddStampsAtStart;
    public string quizMaster;
    public StampsData dataContainer;

    void Start()
    {
        // PlayerPrefs.SetString("QuizMasterusername", "Ayako");
        // PlayerPrefs.SetString("QuizMasterStudentID", "KOKO3311");
        username = PlayerPrefs.GetString("username");
        StudentID = PlayerPrefs.GetString("StudentID");
        quizMaster = PlayerPrefs.GetString("QuizMasterusername") + PlayerPrefs.GetString("QuizMasterStudentID");



        if (checkAddStampsAtStart == true)
        {
            Debug.Log("Start GetAndModifyJson");
            StartCoroutine(GetJson());
        }
    }
    public void AddUniqueString(string quizMaster)
    {
        if (!quizMasters.Contains(quizMaster))
        {
            quizMasters.Add(quizMaster);
            Debug.Log($"Added: {quizMaster}");
            StartCoroutine(PublishJson());
        }
        else
        {
            Debug.Log($"{quizMaster} already exists in the list.");
            StartCoroutine(PublishJson());
        }

    }
    public void CheckStamps()
    {
        GetJson();
    }

    public IEnumerator GetJson()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(JsonUrl))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string jsonText = webRequest.downloadHandler.text;
                StampsData currentList = JsonUtility.FromJson<StampsData>(jsonText); // Deserialize JSON

                if (currentList == null) // Handle empty or invalid JSON
                {
                    currentList = new StampsData { quizMastersData = new List<string>() };
                    Debug.Log("JSON Empty");
                    CopyList();
                    AddUniqueString(quizMaster);
                }

                if (currentList != null)
                {
                    Debug.Log("Retrieved JSON"+ webRequest.downloadHandler.text);
                    CopyList();
                    AddUniqueString(quizMaster);
                }
            }
            else
            {
                Debug.LogError("Error retrieving JSON: " + webRequest.error);
            }
        }
    }
    public void CopyList()
    {
        dataContainer.quizMastersData = quizMasters;
    }

    public IEnumerator PublishJson()
    {
        // Create a new data object and populate it
        StampsData data = new StampsData();
        
        data.username = username;
        data.StudentID = StudentID;
        data.quizMastersData = quizMasters;
        

        string jsonString = JsonUtility.ToJson(data); // Serialize back to JSON

        using (UnityWebRequest webRequest = UnityWebRequest.PostWwwForm(JsonUrl, "POST")) // Use POST
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonString);
            webRequest.uploadHandler = new UploadHandlerRaw(bodyRaw);
            webRequest.downloadHandler = new DownloadHandlerBuffer();
            webRequest.SetRequestHeader("Content-Type", "application/json");

            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("JSON published successfully!"+ webRequest.downloadHandler.text);
                UpdateGameObjectStates();
            }
            else
            {
                Debug.LogError("Error publishing JSON: " + webRequest.error);
            }
        }
    }
    public void UpdateGameObjectStates()
    {
        Debug.Log("Deactivate all GameObjects first");
        // Deactivate all GameObjects first
        foreach (GameObject obj in Stamps)
        {
            obj.SetActive(false);
        }
        Debug.Log("Activate GameObjects up to the count of dataValues");

        // Activate GameObjects up to the count of dataValues
        for (int i = 0; i < quizMasters.Count && i < Stamps.Count; i++)
        {
            Stamps[i].SetActive(true);
        }
    }
}