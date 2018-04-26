using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class detectObject : MonoBehaviour {

	public GameObject touching;

	// Use this for initialization
	void Start () {
		touching = gameObject.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
	}
	
	// Update is called once per frame
	void Update () {
		if (touching != null) {
			touching = gameObject.GetComponent<VRTK_InteractTouch> ().GetTouchedObject ();
			Debug.Log (touching.name);
		}
	}
}
