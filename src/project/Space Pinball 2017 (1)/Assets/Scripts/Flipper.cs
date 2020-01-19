using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {
	//Declaring all variable (can be modified later in unity)
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 100000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;
	
	void Start () {
		//declare a new hinge and add spring to it
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
	}
	//void update called once per frame
	void Update () {
		//assign hitStrength to spring
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
		//activates spring launching flipper to the pressed position otherwise it is neutral
        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
