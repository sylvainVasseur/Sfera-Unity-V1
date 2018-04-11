using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnMarkerFound : MonoBehaviour {
	[SerializeField] private GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMarkerFound(ARMarker marker) {
		target.SetActive (true);
	}
}
