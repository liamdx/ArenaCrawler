using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	private Rigidbody rib;
	public float speedMultiplier;

	private void Awake() {
		rib = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {

		float vav = Input.GetAxis ("Vertical");
		float hav = Input.GetAxis ("Horizontal");
		Vector3 pfv = transform.forward;

		if(Input.GetButton("Vertical")){
			rib.AddForce (transform.forward * vav * speedMultiplier); 
		}

		if(Input.GetButton("Horizontal")){
			rib.AddForce (transform.right * hav * speedMultiplier);
		}

		float velocity = rib.velocity.magnitude;

		if(Input.GetButtonUp("Vertical")){
			rib.AddForce ((pfv * -1f) * velocity); 
		}

		if(Input.GetButtonUp("Horizontal")){
			rib.AddForce ((pfv * -1f) * velocity);
		}
			
	}
}
