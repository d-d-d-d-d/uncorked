using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHandPosition : MonoBehaviour {

	public GameObject cont;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		rb.MoveRotation (cont.transform.rotation);
		rb.MovePosition (cont.transform.position);
	}
}
