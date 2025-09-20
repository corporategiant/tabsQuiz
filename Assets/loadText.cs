using UnityEngine;
using TMPro;

public class loadText : MonoBehaviour
{
    public TextMeshProUGUI TextBoxA;
    public TextMeshProUGUI TextBoxA1;
    public TextMeshProUGUI TextBoxA2;
    public TextMeshProUGUI TextBoxA3;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextBoxA.text = PlayerPrefs.GetString("TextA");
        TextBoxA.ForceMeshUpdate(true);
        Debug.Log("TextA : " + PlayerPrefs.GetString("TextA"));
        TextBoxA1.text = PlayerPrefs.GetString("TextA1");
        TextBoxA2.text = PlayerPrefs.GetString("TextA2");
        TextBoxA3.text = PlayerPrefs.GetString("TextA3");
    }


}
