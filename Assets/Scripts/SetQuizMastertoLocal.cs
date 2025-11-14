using UnityEngine;

public class SetQuizMasterToLocal : MonoBehaviour
{
    public void SetQuizMasterLocal()
    {
        PlayerPrefs.SetString("QuizMasterusername", PlayerPrefs.GetString("username"));
        PlayerPrefs.SetString("QuizMasterStudentID", PlayerPrefs.GetString("StudentID"));
    }
}
