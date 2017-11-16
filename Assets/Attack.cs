using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	private float damage;

	public ParticleSystem attack01;

	// Use this for initialization
	void Start () {
		damage = 1f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetButtonDown("Fire1")){
			PlayAttack ();
			damage = damage;
		}
	}

	void PlayAttack(){
		if (attack01.isPlaying) {
			
		} else {
			attack01.Play ();
		}

	}

	void DoDamage(){
		
	}
}
