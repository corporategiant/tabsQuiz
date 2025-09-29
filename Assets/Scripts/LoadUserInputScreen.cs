using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadUserInputScreen : MonoBehaviour
{
    public string SceneToLoad;
    public void StartLoadUserInputScreen()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
        Debug.Log("Loading User Input Screen");
    }

        public void StartLoadUIS()
    {
        SceneManager.LoadSceneAsync(4);
        Debug.Log("SceneID 4");
    }
}
