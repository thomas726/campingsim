using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizzle : MonoBehaviour {
	AudioSource saw;
	// Use this for initialization
	void Start () {
		saw = GameObject.FindObjectOfType<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startGrill() {
		saw.Play ();
		Debug.Log ("Nurrrr");
		saw.loop = true;
	}

	void OnCollisionEnter(Collision col) {

		if (col.gameObject) {
			startGrill ();
		}

	}
}
