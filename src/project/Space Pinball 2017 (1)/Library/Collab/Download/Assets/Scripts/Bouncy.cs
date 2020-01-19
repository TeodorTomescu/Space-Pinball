using UnityEngine;
using System.Collections;


public class Bouncy : MonoBehaviour
{

	public float explosionStrength  = 2000f;

	void OnCollisionEnter (Collision other)
	{
		other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
		ScoreManager.scoreCount += 150;
	}
}

