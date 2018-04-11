using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnMarkerFound : MonoBehaviour {
    [SerializeField] string sceneAntiquite;
    [SerializeField] string sceneMoyenAge;
    [SerializeField] GameObject gameObject;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMarkerFound(ARMarker arMarker)
    {
        if(arMarker.GetMarkerTag == "marker01" || arMarker.GetMarkerTag == "marker02")
        {
            Debug.Log("Salle Antiquité");
            SceneManager.LoadScene(sceneAntiquite);
            gameObject.SetActive(false);
        }
        else if(arMarker.GetMarkerTag == "marker03")
        {
            Debug.Log("Salle Moyen Age");
            //SceneManager.LoadScene(sceneMoyenAge);
        }
    }
}
