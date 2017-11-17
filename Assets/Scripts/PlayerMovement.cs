using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speedMultiplier;
	private float initSpeedMultiplier;

	private void Awake(){
		initSpeedMultiplier = speedMultiplier;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Vertical") && Input.GetButton ("Horizontal")) {
			speedMultiplier = initSpeedMultiplier * 0.25f;
			Vector3 pfv = transform.forward;
			transform.position += pfv * Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
			Vector3 prv = transform.right;
			transform.position += prv * Input.GetAxis("Horizontal") * speedMultiplier * Time.deltaTime;
		}

		if(Input.GetButton("Vertical")){
			speedMultiplier = initSpeedMultiplier;
			Vector3 pfv = transform.forward;
			transform.position += pfv * Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
		}
		if(Input.GetButton("Horizontal")){
			speedMultiplier = initSpeedMultiplier;
			Vector3 prv = transform.right;
			transform.position += prv * Input.GetAxis("Horizontal") * speedMultiplier * Time.deltaTime;
		}



	}
}