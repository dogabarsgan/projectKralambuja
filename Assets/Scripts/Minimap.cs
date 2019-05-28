using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

	public Transform target;

	[SerializeField]
	private float xMin;

	[SerializeField]
	private float xMax;

	[SerializeField]
	private float yMin;

	[SerializeField]
	private float yMax;

	void LateUpdate() {
		 transform.position = new Vector3(Mathf.Clamp(target.position.x,xMin,xMax), Mathf.Clamp(target.position.y,yMin,yMax), -10f);
	}
}
