using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LoadAsynch : MonoBehaviour {

	public bool WaitForInput;

	public string SceneToLoad;
	public float Pause;
	public float Progress = 0;
	
	private bool _levelIsLoading;
	public bool levelIsLoading{
		get{ return _levelIsLoading;}    
	}
	
	private AsyncOperation async;


	IEnumerator Start()
	{
		yield return new WaitForSeconds(Pause);
		_levelIsLoading = true;
		async = SceneManager.LoadSceneAsync(SceneToLoad);
		if (WaitForInput == true) 
		{
			async.allowSceneActivation = false;
		}

		
	}
	
	private void Update(){
		if(_levelIsLoading){
			Progress = async.progress;    
		}
	}
	
	
	public void startLevel(){
		async.allowSceneActivation = true;    
	}    
}