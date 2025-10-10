using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string SceneToLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Reset()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);


    }
}
