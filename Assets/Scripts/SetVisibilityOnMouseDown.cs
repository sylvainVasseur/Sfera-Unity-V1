using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVisibilityOnMouseDown : MonoBehaviour {
	[SerializeField] private GameObject obj;
	[SerializeField] private bool shown;

	public void OnMouseDown () {
		Debug.Log ("clic");
		obj.SetActive (shown);
	}
}
