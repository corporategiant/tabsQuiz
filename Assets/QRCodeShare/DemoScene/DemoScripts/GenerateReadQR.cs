using System;
using System.Runtime.InteropServices;
using AOT;
using QRCodeShareMain;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Toggle = UnityEngine.UI.Toggle;
using System.Collections;
using UnityEngine.Networking;
using System.IO;


namespace QRCodeShareDemo
{
    public class GenerateReadQR : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern void DownloadFile(string fileName, string content);
        [DllImport("__Internal")]
        private static extern void UploadFile(Action<string> callbackMethodName);
        

        [Header("Panels References")]
        [SerializeField] private GameObject panelGenerate;
        [SerializeField] private GameObject panelRead;
        [Header("Style Settings References")] 

        [Header("Generate QR Code References")]
        
        [SerializeField] private Image showImageGenerate;
        [SerializeField] private Button generateQRCode;
        [SerializeField] private Button downloadImage;
        [Header("Read QR Code References")] 
        
        [SerializeField] private Image showImageRead;
        [SerializeField] private Button uploadImage;
        [SerializeField] private Button readQRCode;
        [Header("Content")]


        public string username;
        public string StudentID;
        //public TextMeshProUGUI URL;

        private Texture2D currentQRCodeGenerate = null;
        private Texture2D currentQRCodeRead = null;
        
        void Start()
        {
            username = PlayerPrefs.GetString("username");
            StudentID = PlayerPrefs.GetString("StudentID");
            if (PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + PlayerPrefs.GetString("StudentID") + "QRCodePNGSaved") == 0)
            {
                Debug.Log("Starting GenerateOwnQRCode");
                GenerateOwnQRCode();
            }

        }
        
        private Texture2D HelloWorldQRCode(string content)
        {
            QRImageProperties properties = new QRImageProperties(500, 500,50);
            Texture2D QRCodeImage = QRCodeShare.CreateQRCodeImage(content, properties);
            return QRCodeImage;
        }



 
        
        private void ShowImage(Image showImage, Texture2D image)
        {
            showImage.sprite = ImageProcessing.ConvertTexture2DToSprite(image);
            float imageSize = Mathf.Max(showImage.GetComponent<RectTransform>().sizeDelta.x, showImage.GetComponent<RectTransform>().sizeDelta.y);

            showImage.GetComponent<RectTransform>().sizeDelta = image.width <= image.height ? 
                new Vector2(imageSize / image.height * image.width, imageSize) : 
                new Vector2(imageSize, imageSize * image.height / image.width);
        }

        private void OnSwitchTabs(bool isOn)
        {
            panelGenerate.SetActive(isOn);
            panelRead.SetActive(!isOn);
            
           
        }

        public void GenerateQRCode()
        {
 
            string content = "https://www.corporategiant.co.uk/tabsQuizData/"+username+StudentID+"/";
            currentQRCodeGenerate = HelloWorldQRCode(content);
            

            if (currentQRCodeGenerate != null)
            {
                ShowImage(showImageGenerate, currentQRCodeGenerate);
                // Enable the download image button if the texture is not null
                downloadImage.interactable = true;
            }
            
        }

            public void GenerateOwnQRCode()
        {
 
            string content = "https://www.corporategiant.co.uk/tabsQuizData/"+username+StudentID+"/";
            currentQRCodeGenerate = HelloWorldQRCode(content);
            Debug.Log("Starting SaveQRCodetoURL");
            SaveQRCodetoURL();
        }

        public void ReadQRCode()
        {
            if (currentQRCodeRead != null)
            {
                
                PlayerPrefs.SetString("QRQuizURL",QRCodeShare.ReadQRCodeImage(currentQRCodeRead));
                //URL.text = PlayerPrefs.GetString("QRQuizURL");

            }
            else
            {
                Debug.LogError("There is no uploaded image to read.");
            }
        }
        public void DownloadQRCode()
        {
            if (currentQRCodeGenerate != null)
            {
                string fileName = "QRCode" + PlayerPrefs.GetString("username") + PlayerPrefs.GetString("StudentID") + ".png";
                string content = Convert.ToBase64String(currentQRCodeGenerate.EncodeToPNG());
                DownloadFile(fileName, content);
            }
            else
            {
                Debug.LogError("There is no generated QR code to download.");
            }
        }

        public void SaveQRCodetoURL()
        {
            if (currentQRCodeGenerate != null)
            {
                string fileName = "QR.png";
                string content = Convert.ToBase64String(currentQRCodeGenerate.EncodeToPNG());
                string uploadUrl = "https://corporategiant.co.uk/tabsQuizData/" + username + StudentID + "/upload.php";
                Debug.Log("Starting SaveFiletoURL: " + uploadUrl);
                StartCoroutine (SaveFiletoURL(uploadUrl, fileName, content));
            }
            else
            {
                Debug.LogError("There is no generated QR code to save to url.");
            }
        }

        public IEnumerator SaveFiletoURL(string fileName, string uploadUrl, string content)
        {
            Debug.Log("Starting Convert to bytes");

            byte[] fileData = Convert.FromBase64String(content);

            Debug.Log("Starting Create a form to send the file data");

            // Create a form to send the file data
            WWWForm form = new WWWForm();
            form.AddBinaryData("fileToUpload", fileData, fileName, "application/octet-stream");

            Debug.Log("Starting Send web request");
            // Send web request
            using (UnityWebRequest www = UnityWebRequest.Post(uploadUrl, form))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    Debug.LogError("File upload failed: " + www.error);
                }
                else
                {
                    Debug.Log("File upload complete! Server response: " + www.downloadHandler.text);
                    PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + PlayerPrefs.GetString("StudentID") + "QRCodePNGSaved",1);
                }
            }
            
        }
    
        public void UploadQRCode()
        {
            UploadFile(OnFileUploaded);
        }
        
        [MonoPInvokeCallback(typeof(Action<string>))]
        public static void OnFileUploaded(string base64Data)
        {
            // remove the beginning "data:image/png;base64," part
            base64Data = base64Data.Substring(22);
            byte[] imageBytes = Convert.FromBase64String(base64Data);
            Texture2D texture = new Texture2D(2, 2); 
            if (texture.LoadImage(imageBytes))
            {
                // To access a non-static method, you need an instance of this class
                GenerateReadQR instance = FindAnyObjectByType<GenerateReadQR>();
                if (instance != null)
                {
                    instance.currentQRCodeRead = texture;
                    // Show the uploaded image
                    instance.ShowImage(instance.showImageRead, texture);
                    // Enable the read QR code button if the texture is not null
                    instance.readQRCode.interactable = true;
                }
            }
        }
        
    }
}
    
