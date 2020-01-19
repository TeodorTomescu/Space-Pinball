#pragma strict

var lives : int = 3;

function OnCollision(other : Collision)
{
	while (lives > 0) 
	{
	    if(other.gameObject.name == "RestartBar")
		{
			lives = lives - 1;
			Application.LoadLevel("Game Scene");
		}
	}

}