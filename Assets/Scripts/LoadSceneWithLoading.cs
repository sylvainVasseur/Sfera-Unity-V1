using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneWithLoading : MonoBehaviour {
	[SerializeField] private GameObject loadingObject;
	// [SerializeField] private int sceneId;

	// Use this for initialization
	void Start () {
		Debug.Log ("button initr");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadSceneWithLoad (int sceneId) {
		Debug.Log ("button clicked");
		loadingObject.SetActive (true);
		SceneManager.LoadScene (sceneId);
	}

	/*
	IEnumerator LoadNewSceneCoroutine () {
		Debug.Log ("LoadNewSceneCoroutine");
		AsyncOperation async = SceneManager.LoadSceneAsync (sceneId);
		while (!async.isDone) {
			yield return null;
		}
	}
	*/
}
