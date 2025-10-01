using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleLoad : MonoBehaviour
{
    
    public string SceneToLoad;

public void LoadLevelSimple()
{
    PlayerPrefs.SetInt("currentLevel", 1);
    SceneManager.LoadScene(SceneToLoad);

}
}
