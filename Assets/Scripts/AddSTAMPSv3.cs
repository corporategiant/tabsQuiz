using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.InputSystem.Interactions;
using System.Collections;
using UnityEngine.Networking;
using System.Text;
using System.Collections.Generic; // For List<T>


public class AddSTAMPSv3 : MonoBehaviour
{
    public string username;
    public string StudentID;
    public string SaveStampsPHPUrl = "https://www.corporategiant.co.uk/tabsQuizData/stampsData/SaveStampsData.php";
    public string GetStampsPHPUrl = "https://www.corporategiant.co.uk/tabsQuizData/stampsData/get_stamps_data.php";
    public GameObject Stamp1;
    public GameObject Stamp2;
    public GameObject Stamp3;
    public string currentQuizMasterusername;
    public string currentQuizMasterStudentID;
    public string quizMasterusername;
    public string quizMasterStudentID;
    public List<string> quizMasters;
    public List<GameObject> Stamps;
    public bool getStampsAtStart;
    public string filename;

    public StampsData[] allData;


    [System.Serializable]
    public class StampsData
    {
        public string filename;
        public string quizMasterusername;
        public string quizMasterStudentID;

    }

    void Start()
    {
       username = PlayerPrefs.GetString("username");
       StudentID = PlayerPrefs.GetString("StudentID");
        // For testing

        PlayerPrefs.SetString("QuizMasterusername", "Guest");
        PlayerPrefs.SetString("QuizMasterStudentID", "KOKO3311");


        currentQuizMasterusername = PlayerPrefs.GetString("QuizMasterusername");
        currentQuizMasterStudentID = PlayerPrefs.GetString("QuizMasterStudentID");
        filename = PlayerPrefs.GetString("username") + PlayerPrefs.GetString("StudentID");
        if (getStampsAtStart == true)
        {
            Debug.Log("Start GetStamps");
            StartCoroutine(GetStamps(filename));
        }
    }

    public void StartGetStamps()
    {
        StartCoroutine(GetStamps(filename));
    }

    private IEnumerator GetStamps(string filename)
    {
        // Create the form data
        WWWForm form = new WWWForm();
        form.AddField("filename", filename);

        // Create the request
        using (UnityWebRequest www = UnityWebRequest.Post(GetStampsPHPUrl, form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Error: " + www.error);
            }
            else
            {
                Debug.Log("Server response: " + www.downloadHandler.text);

                // Deserialize the JSON string into a C# object
                StampsData stampsData = JsonUtility.FromJson<StampsData>(www.downloadHandler.text);

                if (stampsData != null)
                {
                    Debug.Log("Successfully parsed JSON data:");
                    Debug.Log("Username: " + stampsData.quizMasterusername);
                    Debug.Log("Score: " + stampsData.quizMasterStudentID);
                }
                else
                {
                    Debug.LogError("Failed to deserialize JSON data.");
                }
            }
        }
    }

    public void AddUniqueString(string quizMaster)
    {
        if (!quizMasters.Contains(quizMaster))
        {
            quizMasters.Add(quizMaster);
            Debug.Log($"Added: {quizMaster}");
        }
        else
        {
            Debug.Log($"{quizMaster} already exists in the list.");
        }
    }


    IEnumerator SaveStamps()
    {
        yield return new WaitForSeconds(0f);
        //Send data to json

        // Create a new data object and populate it
        StampsData data = new StampsData();
        data.filename = filename;
        data.quizMasterusername = currentQuizMasterusername;
        data.quizMasterStudentID = currentQuizMasterStudentID;


        // Convert the object to a JSON string
        string jsonData = JsonUtility.ToJson(data);

        // Create the web request
        using (UnityWebRequest request = new UnityWebRequest(GetStampsPHPUrl, "POST"))
        {
            byte[] jsonToSend = new UTF8Encoding().GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(jsonToSend);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            // Send the request
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Successfully sent STAMPS data to server: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Error sending data: " + request.error);
            }
        }
        UpdateGameObjectStates();
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

