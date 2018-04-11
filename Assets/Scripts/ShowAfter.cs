using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAfter : MonoBehaviour {
	[SerializeField] private float delay;
	[SerializeField] private GameObject obj;

	// Use this for initialization
	void Start () {
		if (obj.activeInHierarchy) {
			obj.SetActive (false);
		}

		StartCoroutine (LateCall ());
	}

	IEnumerator LateCall () {
		yield return new WaitForSeconds (delay);
		obj.SetActive (true);
	}
}
