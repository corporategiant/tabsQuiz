using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	GameObject[] Pages;

	public void ChangeToScene (string sceneToChangeTo) {

		//iTween.ResetTweens ();
		Pages = GameObject.FindGameObjectsWithTag("Page");
		foreach (GameObject Page in Pages)
		{
			Page.SetActive(false);
		}
		Application.LoadLevel (sceneToChangeTo);
		
	}
}
