#pragma strict

var ball : Transform;
//declare starting position
private var startingPos : Vector3;
//assign startingPos to be the position the ball is in on the game scene
function Start() {
	
	startingPos = ball.position;
}
//Function OnCollissionEnter checks if the lower boundary collides with the ball then transform it to the starting position
function OnCollisionEnter(_other : Collision) {

	if(_other.gameObject.tag == "Ball") {
		_other.rigidbody.velocity = Vector3.zero;
		_other.transform.position = startingPos;
	}

}