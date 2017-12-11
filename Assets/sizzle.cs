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
		//StartCoroutine ("waiting function");
		//InvokeRepeating ("WaitingFunction", 0f, 4f);

	}


	//private IEnumerator WaitingFunction(){
	//	yield return new WaitForSeconds(4);
	//	saw.Play ();
	//}


	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag("grillheat"))
			{
				startGrill();
			}
	}
}
