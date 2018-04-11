using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAfter5s : MonoBehaviour {
	void Start () {
		if (gameObject.activeInHierarchy) {
			gameObject.SetActive (true);
		}

		StartCoroutine (LateCall ());
	}

	IEnumerator LateCall () {
		yield return new WaitForSeconds (5);
		gameObject.SetActive (false);
	}
}
