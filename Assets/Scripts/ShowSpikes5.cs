using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpikes5 : MonoBehaviour {

	private bool hasMoved = false;

	// Update is called once per frame
	void Update () {
		if (CharacterMovement.moveSpikes5 == true && !hasMoved) {
			transform.Translate(Vector3.up);
			hasMoved = true;
		}
	}
}
