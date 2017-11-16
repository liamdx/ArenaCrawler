using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	private float damage;

	public GameObject Attack01;
	public GameObject Attack02;

	private ParticleSystem attack01;
	private ParticleSystem attack02;

	// Use this for initialization
	void Start () {
		damage = 1f;
		attack01 = Attack01.GetComponent<ParticleSystem> ();
		attack02 = Attack02.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Fire1")) {
			PlayAttack01 ();
			damage = damage;
		} else {
			StopAttack01 ();
		}
	}

	void PlayAttack01(){
		if (attack01.isPlaying) {
			
		} else {
			attack01.Play ();
		}

	}

	void StopAttack01(){
		if (attack01.isPlaying) {
			attack01.Stop ();
		} else {
		}

	}

	void PlayAttack02(){
		if (attack02.isPlaying) {

		} else {
			attack02.Play ();
		}

	}

	void StopAttack02(){
		if (attack02.isPlaying) {
			attack02.Stop ();
		} else {
		}

	}
		


	void DoDamage(){
		
	}
}
