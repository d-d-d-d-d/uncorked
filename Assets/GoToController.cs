using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToController : MonoBehaviour {

	public Transform target;
	public float speed = 0.01f;

	private Rigidbody rb;
	private Vector3 direction;
	private bool stunned = false;
	private float countdown = 100f;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void FixedUpdate () {
		if (stunned == false) {
			direction = target.position - transform.position;
			rb.MoveRotation (Quaternion.LookRotation (direction));
			rb.AddForce (((transform.forward * speed) * Random.Range (1.0f, 1.25f)), ForceMode.Impulse);
		} else if (stunned == true) {
			countdown--;
			if (countdown <= 0) {
				stunned = false;
				countdown = 100f;
			}
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Controller") {
			stunned = true;
		}
	}
}
