using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFollowCamera : MonoBehaviour {

	[SerializeField]
	private float xMin;

	[SerializeField]
	private float xMax;

	[SerializeField]
	private float yMin;

	[SerializeField]
	private float yMax;

	private Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("Character").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(Mathf.Clamp(target.position.x,xMin,xMax), Mathf.Clamp(target.position.y,yMin,yMax), transform.position.z);
	}
}
