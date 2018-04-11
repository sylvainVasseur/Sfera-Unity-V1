using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMonster : MonoBehaviour {
	[SerializeField] private int Hit;
	[SerializeField] private GameObject MonsterObject;
	[SerializeField] private GameObject TextObject;
	[SerializeField] private GameObject ShowInstruction;
	[SerializeField] private GameObject NeedToolsObject;

	private static int count = 0;
	public void OnMouseDown () {
		Debug.Log ("clic" + count);
		if(NeedToolsObject.activeSelf){		
			count++;
			if(count > Hit){
				Destroy(MonsterObject);
				TextObject.SetActive(true);
			}
		}
		else{
			ShowInstruction.SetActive(true);
		}
	}
}
