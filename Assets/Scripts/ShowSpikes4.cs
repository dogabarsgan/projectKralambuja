using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpikes4 : MonoBehaviour {

	private bool hasMoved = false;

	// Update is called once per frame
	void Update () {
		if (CharacterMovement.moveSpikes4 == true && !hasMoved) {
			transform.Translate(Vector3.up);
			hasMoved = true;
		}
	}
}
