using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//class Shooter script provides the spring loaded launch functionality allowing ball to be launched into play
public class PowerSpring : MonoBehaviour {
	//variable declaration (can be modified later in unity)
	float power = 0f;
	public float powerAdd = 700f;
	public float maxPower = 2500f;
	public Slider powerSlider;
	Rigidbody ball;

	//initialization of poweSliders min and max values
	void Start () {
		powerSlider.minValue = 0f;
		powerSlider.maxValue = maxPower;
	}
	//We check every fram to see if the user is holding down the space bar for the slider and we increase the power indicator on GUI respectively. Once the user lets go apply force to ball.
	private void FixedUpdate(){
		powerSlider.value = power;
		if (ball != null){
			if (Input.GetKey(KeyCode.Space)){
				if (power <= maxPower){
					power += powerAdd * Time.deltaTime;
				}

			}
			else{
				ball.AddForce(power * 10 * Vector3.forward);
			}
		}
	}
	//once ball is resting on a power spring we activate the powerSlider and instantiate the rigid body component of the ball so we can add a force
	private void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Ball")){
			powerSlider.gameObject.SetActive(true);
			ball = other.gameObject.GetComponent<Rigidbody>();
		}
	}
	//remove powerslider and nullify the ball component instance
	private void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag("Ball")){
			powerSlider.gameObject.SetActive(false);
			ball = null;
			power = 0f;
		}
	}
}
