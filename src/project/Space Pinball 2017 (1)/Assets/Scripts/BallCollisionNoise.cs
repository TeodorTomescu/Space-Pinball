using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionNoise : MonoBehaviour {
	//Add public AudioSource componenet
	public AudioSource noise;

	void Start () {
		noise = GetComponent<AudioSource> ();
	}
	

	void Update () {
		
	}

	//Function onCollisionEnter plays our AudioSource if collision detected between Ball and Bumper
	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "bumper1") {
			noise.Play ();
		}
	}
}
