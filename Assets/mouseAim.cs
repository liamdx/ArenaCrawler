using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseAim : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		float rx = Input.GetAxis ("Right_Horizontal");
		float ry = Input.GetAxis ("Right_Vertical");

		float angle = Mathf.Atan2 (rx, ry);
		angle *= 180f / Mathf.PI;
		transform.rotation = Quaternion.Euler (0, angle, 0);
	}
}
