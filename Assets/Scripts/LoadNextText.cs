using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextText : MonoBehaviour {
	[SerializeField] private GameObject HideObject;

	void loadObject() {
		HideObject.SetActive(false);
	}
}
