using Unity.VisualScripting;
using UnityEngine;

public class CheckSaved : MonoBehaviour
{
    public GameObject Saved;
    public GameObject NotSaved;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetString("Question1") != null)
        {
            Saved.SetActive(true);
            NotSaved.SetActive(false);
        }
        else
        {
            Saved.SetActive(false);
            NotSaved.SetActive(true);
        }
    }


}
