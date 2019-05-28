using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject coin;
	public static bool hasCompletedPuzzle = false;
	private Transform[] layers;

	void Start() {
		coin.SetActive(!coin.activeSelf);
	}

	public void OpenInventory() {

		if (!Input.GetKeyDown(KeyCode.Space)) {
			inventoryPanel.SetActive(!inventoryPanel.activeSelf);
			FindObjectOfType<AudioManager>().Play("Popup");
			if (CharacterMovement.showCoin == true)
				coin.SetActive(!coin.activeSelf);
		}
	}
}
