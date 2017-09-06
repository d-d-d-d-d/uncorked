using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour {




	private Transform trans;

	public float speed = 10f;
	public Transform rotationTarget;


	void Start () {
		transform.LookAt (rotationTarget.position);
	}
	
	void FixedUpdate () {
		transform.RotateAround (rotationTarget.position, Vector3.up, speed * Time.deltaTime);

	
	}
}
