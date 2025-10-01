using UnityEngine;
using TMPro;
using System;

public class loadText : MonoBehaviour
{
    public int Level;
    [Header("Q1")]
    public TextMeshProUGUI TextQ1;
    public TextMeshProUGUI Text1A_O;
    public TextMeshProUGUI Text1A_X;
    public TextMeshProUGUI Text1B_O;
    public TextMeshProUGUI Text1B_X;
    public TextMeshProUGUI Text1C_O;
    public TextMeshProUGUI Text1C_X;
    [Header("Q2")]
    public TextMeshProUGUI TextQ2;
    public TextMeshProUGUI Text2A_O;
    public TextMeshProUGUI Text2A_X;
    public TextMeshProUGUI Text2B_O;
    public TextMeshProUGUI Text2B_X;
    public TextMeshProUGUI Text2C_O;
    public TextMeshProUGUI Text2C_X;
    [Header("Q3")]
    public TextMeshProUGUI TextQ3;
    public TextMeshProUGUI Text3A_O;
    public TextMeshProUGUI Text3A_X;
    public TextMeshProUGUI Text3B_O;
    public TextMeshProUGUI Text3B_X;
    public TextMeshProUGUI Text3C_O;
    public TextMeshProUGUI Text3C_X;
    [Header("Q4")]
    public TextMeshProUGUI TextQ4;
    public TextMeshProUGUI Text4A_O;
    public TextMeshProUGUI Text4A_X;
    public TextMeshProUGUI Text4B_O;
    public TextMeshProUGUI Text4B_X;
    public TextMeshProUGUI Text4C_O;
    public TextMeshProUGUI Text4C_X;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Level = PlayerPrefs.GetInt("currentLevel");
        //Q1
        TextQ1.text = PlayerPrefs.GetString("Level" + Level + "Question1");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Question1 : " + PlayerPrefs.GetString("Level" + Level + "Question1"));
        Text1A_O.text = PlayerPrefs.GetString("Level" + Level + "Answer1A");
        Text1A_X.text = PlayerPrefs.GetString("Level" + Level + "Answer1A");
        Text1B_O.text = PlayerPrefs.GetString("Level" + Level + "Answer1B");
        Text1B_X.text = PlayerPrefs.GetString("Level" + Level + "Answer1B");
        Text1C_O.text = PlayerPrefs.GetString("Level" + Level + "Answer1C");
        Text1C_X.text = PlayerPrefs.GetString("Level" + Level + "Answer1C");
 
        //Q2
        TextQ2.text = PlayerPrefs.GetString("Level" + Level + "Question2");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Level" + Level + "Question2 : " + PlayerPrefs.GetString("Level" + Level + "Question2"));
        Text2A_O.text = PlayerPrefs.GetString("Level" + Level + "Answer2A");
        Text2A_X.text = PlayerPrefs.GetString("Level" + Level + "Answer2A");
        Text2B_O.text = PlayerPrefs.GetString("Level" + Level + "Answer2B");
        Text2B_X.text = PlayerPrefs.GetString("Level" + Level + "Answer2B");
        Text2C_O.text = PlayerPrefs.GetString("Level" + Level + "Answer2C");
        Text2C_X.text = PlayerPrefs.GetString("Level" + Level + "Answer2C");
        //Q3
        TextQ3.text = PlayerPrefs.GetString("Level" + Level + "Question3");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Level" + Level + "Question3 : " + PlayerPrefs.GetString("Level" + Level + "Question3"));
        Text3A_O.text = PlayerPrefs.GetString("Level" + Level + "Answer3A");
        Text3A_X.text = PlayerPrefs.GetString("Level" + Level + "Answer3A");
        Text3B_O.text = PlayerPrefs.GetString("Level" + Level + "Answer3B");
        Text3B_X.text = PlayerPrefs.GetString("Level" + Level + "Answer3B");
        Text3C_O.text = PlayerPrefs.GetString("Level" + Level + "Answer3C");
        Text3C_X.text = PlayerPrefs.GetString("Level" + Level + "Answer3C");
        //Q4
        TextQ4.text = PlayerPrefs.GetString("Level" + Level + "Question3");
        //TextQ.ForceMeshUpdate(true);
        Debug.Log("Level" + Level + "Question3 : " + PlayerPrefs.GetString("Level" + Level + "Question3"));
        Text4A_O.text = PlayerPrefs.GetString("Level" + Level + "Answer3A");
        Text4A_X.text = PlayerPrefs.GetString("Level" + Level + "Answer3A");
        Text4B_O.text = PlayerPrefs.GetString("Level" + Level + "Answer3B");
        Text4B_X.text = PlayerPrefs.GetString("Level" + Level + "Answer3B");
        Text4C_O.text = PlayerPrefs.GetString("Level" + Level + "Answer3C");
        Text4C_X.text = PlayerPrefs.GetString("Level" + Level + "Answer3C");


    }



}
