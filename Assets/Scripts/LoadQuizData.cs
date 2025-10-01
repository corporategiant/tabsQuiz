using UnityEngine;
using System.Collections;
using UnityEngine.Networking; // Required for UnityWebRequest

public class LoadQuizData : MonoBehaviour
{
    public string phpUrl;
    public string SceneToLoad;
    public string username;
    public string StudentID;
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

    // Example data structure to serialize to JSON
    [System.Serializable]
    public class MyData
    {
    public string username;
    public string StudentID;

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


    }



    public void StartLoadQuizData()
    {
        phpUrl = PlayerPrefs.GetInt("QRQuizURL")+"/get_data.php";
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

                PlayerPrefs.SetString("QuizMasterName", data.username);
                PlayerPrefs.SetString("Level1Question1", data.Level1Question1);
                PlayerPrefs.SetString("Level1Answer1A", data.Level1Answer1A);
                PlayerPrefs.SetString("Level1Answer1B", data.Level1Answer1B);
                PlayerPrefs.SetString("Level1Answer1C", data.Level1Answer1C);
                PlayerPrefs.SetInt("Level1CorrectAnswer1", data.Level1CorrectAnswer1);

                PlayerPrefs.SetString("Level1Question1", data.Level1Question2);
                PlayerPrefs.SetString("Level1Answer1A", data.Level1Answer2A);
                PlayerPrefs.SetString("Level1Answer1B", data.Level1Answer2B);
                PlayerPrefs.SetString("Level1Answer1C", data.Level1Answer2C);
                PlayerPrefs.SetInt("Level1CorrectAnswer1", data.Level1CorrectAnswer2);

                PlayerPrefs.SetString("Level1Question1", data.Level1Question3);
                PlayerPrefs.SetString("Level1Answer1A", data.Level1Answer3A);
                PlayerPrefs.SetString("Level1Answer1B", data.Level1Answer3B);
                PlayerPrefs.SetString("Level1Answer1C", data.Level1Answer3C);
                PlayerPrefs.SetInt("Level1CorrectAnswer1", data.Level1CorrectAnswer3);

                PlayerPrefs.SetString("Level1Question1", data.Level1Question4);
                PlayerPrefs.SetString("Level1Answer1A", data.Level1Answer4A);
                PlayerPrefs.SetString("Level1Answer1B", data.Level1Answer4B);
                PlayerPrefs.SetString("Level1Answer1C", data.Level1Answer4C);
                PlayerPrefs.SetInt("Level1CorrectAnswer1", data.Level1CorrectAnswer4);

                PlayerPrefs.SetInt("Level1EnvID", data.Level1EnvID);

                PlayerPrefs.SetString("Level2Question1", data.Level2Question1);
                PlayerPrefs.SetString("Level2Answer1A", data.Level2Answer1A);
                PlayerPrefs.SetString("Level2Answer1B", data.Level2Answer1B);
                PlayerPrefs.SetString("Level2Answer1C", data.Level2Answer1C);
                PlayerPrefs.SetInt("Level2CorrectAnswer1", data.Level2CorrectAnswer1);

                PlayerPrefs.SetString("Level2Question1", data.Level2Question2);
                PlayerPrefs.SetString("Level2Answer1A", data.Level2Answer2A);
                PlayerPrefs.SetString("Level2Answer1B", data.Level2Answer2B);
                PlayerPrefs.SetString("Level2Answer1C", data.Level2Answer2C);
                PlayerPrefs.SetInt("Level2CorrectAnswer1", data.Level2CorrectAnswer2);

                PlayerPrefs.SetString("Level2Question1", data.Level2Question3);
                PlayerPrefs.SetString("Level2Answer1A", data.Level2Answer3A);
                PlayerPrefs.SetString("Level2Answer1B", data.Level2Answer3B);
                PlayerPrefs.SetString("Level2Answer1C", data.Level2Answer3C);
                PlayerPrefs.SetInt("Level2CorrectAnswer1", data.Level2CorrectAnswer3);

                PlayerPrefs.SetString("Level2Question1", data.Level2Question4);
                PlayerPrefs.SetString("Level2Answer1A", data.Level2Answer4A);
                PlayerPrefs.SetString("Level2Answer1B", data.Level2Answer4B);
                PlayerPrefs.SetString("Level2Answer1C", data.Level2Answer4C);
                PlayerPrefs.SetInt("Level2CorrectAnswer1", data.Level2CorrectAnswer4);

                PlayerPrefs.SetInt("Level2EnvID", data.Level2EnvID);

                PlayerPrefs.SetString("Level3Question1", data.Level3Question1);
                PlayerPrefs.SetString("Level3Answer1A", data.Level3Answer1A);
                PlayerPrefs.SetString("Level3Answer1B", data.Level3Answer1B);
                PlayerPrefs.SetString("Level3Answer1C", data.Level3Answer1C);
                PlayerPrefs.SetInt("Level3CorrectAnswer1", data.Level3CorrectAnswer1);

                PlayerPrefs.SetString("Level3Question1", data.Level3Question2);
                PlayerPrefs.SetString("Level3Answer1A", data.Level3Answer2A);
                PlayerPrefs.SetString("Level3Answer1B", data.Level3Answer2B);
                PlayerPrefs.SetString("Level3Answer1C", data.Level3Answer2C);
                PlayerPrefs.SetInt("Level3CorrectAnswer1", data.Level3CorrectAnswer2);

                PlayerPrefs.SetString("Level3Question1", data.Level3Question3);
                PlayerPrefs.SetString("Level3Answer1A", data.Level3Answer3A);
                PlayerPrefs.SetString("Level3Answer1B", data.Level3Answer3B);
                PlayerPrefs.SetString("Level3Answer1C", data.Level3Answer3C);
                PlayerPrefs.SetInt("Level3CorrectAnswer1", data.Level3CorrectAnswer3);

                PlayerPrefs.SetString("Level3Question1", data.Level3Question4);
                PlayerPrefs.SetString("Level3Answer1A", data.Level3Answer4A);
                PlayerPrefs.SetString("Level3Answer1B", data.Level3Answer4B);
                PlayerPrefs.SetString("Level3Answer1C", data.Level3Answer4C);
                PlayerPrefs.SetInt("Level3CorrectAnswer1", data.Level3CorrectAnswer4);

                PlayerPrefs.SetInt("Level3EnvID", data.Level3EnvID);
                
                PlayerPrefs.SetString("Level4Question1", data.Level4Question1);
                PlayerPrefs.SetString("Level4Answer1A", data.Level4Answer1A);
                PlayerPrefs.SetString("Level4Answer1B", data.Level4Answer1B);
                PlayerPrefs.SetString("Level4Answer1C", data.Level4Answer1C);
                PlayerPrefs.SetInt("Level4CorrectAnswer1", data.Level4CorrectAnswer1);

                PlayerPrefs.SetString("Level4Question1", data.Level4Question2);
                PlayerPrefs.SetString("Level4Answer1A", data.Level4Answer2A);
                PlayerPrefs.SetString("Level4Answer1B", data.Level4Answer2B);
                PlayerPrefs.SetString("Level4Answer1C", data.Level4Answer2C);
                PlayerPrefs.SetInt("Level4CorrectAnswer1", data.Level4CorrectAnswer2);

                PlayerPrefs.SetString("Level4Question1", data.Level4Question3);
                PlayerPrefs.SetString("Level4Answer1A", data.Level4Answer3A);
                PlayerPrefs.SetString("Level4Answer1B", data.Level4Answer3B);
                PlayerPrefs.SetString("Level4Answer1C", data.Level4Answer3C);
                PlayerPrefs.SetInt("Level4CorrectAnswer1", data.Level4CorrectAnswer3);

                PlayerPrefs.SetString("Level4Question1", data.Level4Question4);
                PlayerPrefs.SetString("Level4Answer1A", data.Level4Answer4A);
                PlayerPrefs.SetString("Level4Answer1B", data.Level4Answer4B);
                PlayerPrefs.SetString("Level4Answer1C", data.Level4Answer4C);
                PlayerPrefs.SetInt("Level4CorrectAnswer1", data.Level4CorrectAnswer4);

                PlayerPrefs.SetInt("Level4EnvID", data.Level4EnvID);


            }
            else
            {
                Debug.LogError("Error fetching JSON: " + webRequest.error);
            }
        }
    }
}