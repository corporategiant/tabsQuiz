using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadUserInputScreen : MonoBehaviour
{
    public string SceneToLoad;
    public void StartLoadUserInputScreen()
    {
        SceneManager.LoadScene(SceneToLoad);
        Debug.Log("Loading User Input Screen");
    }
}
