using UnityEngine;

public class SetQuizMastertoLocal : MonoBehaviour
{
    public void SetQuizMasterLocal()
    {
        PlayerPrefs.SetString("QuizMasterusername", PlayerPrefs.GetString("username"));
        PlayerPrefs.SetString("QuizMasterStudentID", PlayerPrefs.GetString("StudentID"));
    }
}
