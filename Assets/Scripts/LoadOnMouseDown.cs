using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnMouseDown : MonoBehaviour {
	[SerializeField] int sceneNumber;

	public void OnMouseDown () {
		SceneManager.LoadScene (sceneNumber);
	}
}
