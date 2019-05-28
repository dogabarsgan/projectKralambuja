using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour {

	public void PlayGame(){

		SceneManager.LoadScene("MainScene");

	}

	public void GameOptions(){

		SceneManager.LoadScene("OptionsScene");

	}

	public void BackToMain(){

		// SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex)+1);
		SceneManager.LoadScene("MainMenu");

	}


	public void QuitGame(){

		Debug.Log("QUIT!");
		Application.Quit();

	}



}
