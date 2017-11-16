using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speedMultiplier;

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Vertical") && Input.GetButton ("Horizontal")) {
			
		}

		if(Input.GetButton("Vertical")){
			Vector3 pfv = transform.forward;
			transform.position += pfv * Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
		}
		if(Input.GetButton("Horizontal")){
			Vector3 pfv = transform.right;
			transform.position += pfv * Input.GetAxis("Horizontal") * speedMultiplier * Time.deltaTime;
		}
	}
}
