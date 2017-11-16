using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speedMultiplier;

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Vertical") && Input.GetButton ("Horizontal")) {
			Vector3 pfv = transform.forward;
			transform.position += pfv * Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
			Vector3 prv = transform.right;
			transform.position += prv * Input.GetAxis("Horizontal") * speedMultiplier * Time.deltaTime;
		}

		if(Input.GetButton("Vertical")){
			Vector3 pfv = transform.forward;
			transform.position += pfv * Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
		}
		if(Input.GetButton("Horizontal")){
			Vector3 prv = transform.right;
			transform.position += prv * Input.GetAxis("Horizontal") * speedMultiplier * Time.deltaTime;
		}

		float rx = Input.GetAxis ("Right_Horizontal");
		float ry = Input.GetAxis ("Right_Vertical");

		float angle = Mathf.Atan2 (rx, ry);
		angle *= 180f / Mathf.PI;
		transform.rotation = Quaternion.Euler (0, angle, 0);
	}
}