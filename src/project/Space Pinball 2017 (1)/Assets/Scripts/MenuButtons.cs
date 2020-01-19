using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {
	//function NewGameBtn loads game scene
	public void NewGameBtn(string newGame) {
		SceneManager.LoadScene (newGame);
	}
	//function ExitGameBtn quits the application
	public void ExitGameBtn() {
		Application.Quit ();
	}
	//function MenuBtn loads the menu scene
	public void MenuBtn(string menu) {
		SceneManager.LoadScene (menu);
	}
}
