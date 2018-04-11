using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAfter3s : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (gameObject.activeInHierarchy) {
			gameObject.SetActive (false);
		}

		StartCoroutine (LateCall ());
	}

	IEnumerator LateCall () {
		yield return new WaitForSeconds (3);
		gameObject.SetActive (true);
	}
}
