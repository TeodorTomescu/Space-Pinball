using UnityEngine;
using System.Collections;


public class BumperExplosion : MonoBehaviour
{
	//Declaring the explosion force that will be added upon collision with ball (This can be modified additionally in Unity)
	public float explosionStrength  = 2000f;
	// function onCollisionEnter takes the explosionStrength and transforms the ball once it makes contact with a bumper. Also increments score by 150 points if collision occurs. 
	void OnCollisionEnter (Collision other)
	{
		other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
		ScoreManager.scoreCount += 150;
	}
}

