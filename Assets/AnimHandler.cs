using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using VRTK;

public class AnimHandler : MonoBehaviour {

    private PlayableDirector director;
	public bool close;
	public PlayableDirector[] toAnimate;
	//private bool isPaused;
    
	// Use this for initialization
	void Awake() {
		toAnimate = gameObject.GetComponentsInChildren<PlayableDirector> ();
		director = gameObject.GetComponent<PlayableDirector>();
		foreach (PlayableDirector dir in toAnimate) {
			dir.playOnAwake = false;
			dir.extrapolationMode = DirectorWrapMode.Loop;
		}

	}
	void Start () {


		//isPaused = false;
		//toAnimate = gameObject.GetComponentsInChildren<PlayableDirector> ();
        //director = gameObject.GetComponent<PlayableDirector>();
		foreach (PlayableDirector dir in toAnimate) {
			//dir.playOnAwake = false;
			//dir.extrapolationMode = DirectorWrapMode.Loop;
		}
    }
	
	// Update is called once per frame
	void Update () {
		if (close) {
			foreach (PlayableDirector dir in toAnimate) {
				director.enabled = true;
				director.Play ();
					}
		} else if (!close) {
			foreach (PlayableDirector dir in toAnimate) {
				//director.enabled = false;
				director.Pause ();

			}
			}
	}

	void OnTriggerEnter (Collider col) {
		//Debug.Log ("Entered: " + col.gameObject.name);
		close = true;
	}

	void OnTriggerExit (Collider col) {
		//Debug.Log ("Exited: " + col.gameObject.name);
		close = false;
	}
}
