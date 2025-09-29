using UnityEngine;
using TMPro;

public class loadText : MonoBehaviour
{
    [Header("Q1")]
    public TextMeshProUGUI TextQ1;
    public TextMeshProUGUI Text1A;
    public TextMeshProUGUI Text1B;
    public TextMeshProUGUI Text1C;
    [Header("Q2")]
    public TextMeshProUGUI TextQ2;
    public TextMeshProUGUI Text2A;
    public TextMeshProUGUI Text2B;
    public TextMeshProUGUI Text2C;
    [Header("Q3")]
    public TextMeshProUGUI TextQ3;
    public TextMeshProUGUI Text3A;
    public TextMeshProUGUI Text3B;
    public TextMeshProUGUI Text3C;
    [Header("Q4")]
    public TextMeshProUGUI TextQ4;
    public TextMeshProUGUI Text4A;
    public TextMeshProUGUI Text4B;
    public TextMeshProUGUI Text4C;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Q1
        TextQ1.text = PlayerPrefs.GetString("Question1");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Question1 : " + PlayerPrefs.GetString("Question1"));
        Text1A.text = PlayerPrefs.GetString("Answer1A");
        Text1B.text = PlayerPrefs.GetString("Answer1B");
        Text1C.text = PlayerPrefs.GetString("Answer1C");
 
        //Q2
        TextQ2.text = PlayerPrefs.GetString("Question2");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Question2 : " + PlayerPrefs.GetString("Question2"));
        Text2A.text = PlayerPrefs.GetString("Answer2A");
        Text2B.text = PlayerPrefs.GetString("Answer2B");
        Text2C.text = PlayerPrefs.GetString("Answer2C");
        //Q3
        TextQ3.text = PlayerPrefs.GetString("Question3");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Question3 : " + PlayerPrefs.GetString("Question3"));
        Text3A.text = PlayerPrefs.GetString("Answer3A");
        Text3B.text = PlayerPrefs.GetString("Answer3B");
        Text3C.text = PlayerPrefs.GetString("Answer3C");
        //Q4
        TextQ4.text = PlayerPrefs.GetString("Question3");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Question3 : " + PlayerPrefs.GetString("Question3"));
        Text4A.text = PlayerPrefs.GetString("Answer3A");
        Text4B.text = PlayerPrefs.GetString("Answer3B");
        Text4C.text = PlayerPrefs.GetString("Answer3C");


    }



}
