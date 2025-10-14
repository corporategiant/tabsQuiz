using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class CharacterDataLoadQuizMaster : MonoBehaviour
{

    // The URL where your PHP script is hosted
    public string username;
    public string StudentID;
    private const string phpUrl = "https://www.corporategiant.co.uk/tabsBookData/GetCharacterData.php";
    public string fileName;
    public int ChLook;
    public int SnorkelAddOn;
    public int SpaceHelmetAddOn;
    public int MothWingsAddOn;
    public int SnorkelIsOn;
    public int MothWingsIsOn;
    public int SpaceHelmetIsOn;
    public int GlassesRoundIsOn;
    public int GlassesSquareIsOn;
    public int TShirtIsOn;
    public int ColourBody;
    public int ColourLegs;
    public int ColourHair;
    public int ColourSkin;    

    // Mark the class as serializable to work with JsonUtility
    [System.Serializable]
    public class CharacterData
    {
        public string fileName;
        public int ChLook;
        public int SnorkelAddOn;
        public int SpaceHelmetAddOn;
        public int MothWingsAddOn;
        public int SnorkelIsOn;
        public int MothWingsIsOn;
        public int SpaceHelmetIsOn;
        public int GlassesRoundIsOn;
        public int GlassesSquareIsOn;
        public int TShirtIsOn;
        public int ColourBody;
        public int ColourLegs;
        public int ColourHair;
        public int ColourSkin;

    }


    void Start()
    {
        fileName = PlayerPrefs.GetString("QuizMasterusername") + PlayerPrefs.GetString("QuizMasterStudentID");
        StartCoroutine(GetJsonData());
        
    }

        IEnumerator GetJsonData()
    {
        string url = phpUrl + "?filename=" + fileName;

        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string jsonString = webRequest.downloadHandler.text;
                Debug.Log("Received JSON: " + jsonString);

                // Now, parse the JSON string using Unity's JsonUtility or a third-party library
                // Example with JsonUtility (requires a serializable class matching your JSON structure)
                CharacterData data = JsonUtility.FromJson<CharacterData>(jsonString);
                Debug.Log("Parsed data CHLook : " + data.ChLook);

                // Use the data        

                SnorkelAddOn = data.SnorkelAddOn;
                SpaceHelmetAddOn = data.SpaceHelmetAddOn;
                MothWingsAddOn = data.MothWingsAddOn;
                SnorkelIsOn = data.SnorkelIsOn;
                MothWingsIsOn = data.MothWingsIsOn;
                SpaceHelmetIsOn = data.SpaceHelmetIsOn;
                ChLook = data.ChLook;
                GlassesRoundIsOn = data.GlassesRoundIsOn;
                GlassesSquareIsOn = data.GlassesSquareIsOn;
                TShirtIsOn = data.TShirtIsOn;
                ColourBody = data.ColourBody;
                ColourLegs = data.ColourLegs;
                ColourHair = data.ColourHair;
                ColourSkin = data.ColourSkin;


                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "SnorkelAddOn", SnorkelAddOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "SpaceHelmetAddOn", SpaceHelmetAddOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "MothWingsAddOn", MothWingsAddOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "SnorkelIsOn", SnorkelIsOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "MothWingsIsOn", MothWingsIsOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "SpaceHelmetIsOn", SpaceHelmetIsOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "ChLook", ChLook);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "TShirtIsOn", TShirtIsOn);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "ColourBody", ColourBody);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "ColourLegs", ColourLegs);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "ColourHair", ColourHair);
                PlayerPrefs.SetInt("QuizMaster" + username + StudentID + "ColourSkin",ColourSkin);
            
            }
            else
            {
                Debug.LogError("Error fetching JSON: " + webRequest.error);
            }
        }
                     


                


            }
        }

