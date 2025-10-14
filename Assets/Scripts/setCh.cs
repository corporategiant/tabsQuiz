using UnityEngine;

public class setCh : MonoBehaviour
{
    public GameObject Manager;
    public GameObject ch0;
    public GameObject ch1;
    public int Level;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ch0.SetActive(false);
        ch1.SetActive(false);
        Level = Manager.GetComponent<loadText>().Level;

        if (PlayerPrefs.GetInt("Level" + Level + "ChID") == 0)
        {
            ch0.SetActive(true);
        }
        
            if (PlayerPrefs.GetInt("Level" + Level + "ChID") == 1){
            ch1.SetActive(true);
        }
    }


    
}
