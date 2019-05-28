using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TriggerExploration : MonoBehaviour {

	void OnCollisionEnter2D(UnityEngine.Collision2D c) {

		string caseSwitch = c.gameObject.tag;

		switch (caseSwitch) {
			case "Player":
				SceneManager.LoadScene("MainScene");
				Debug.Log("Should switch scenes");
				break;
			default:
				break;
		}
	}
}
