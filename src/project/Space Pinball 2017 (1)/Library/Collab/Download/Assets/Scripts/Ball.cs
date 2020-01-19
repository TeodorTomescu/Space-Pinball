using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public AudioSource noise;
	// Use this for initialization
	void Start () {
		noise = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "bumper1") {
			noise.Play ();
		}
	
	}
}
