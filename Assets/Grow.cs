﻿using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

	public GameObject myVFX;
	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//trigger on state
	void Touched () {
		print ("GROW");
		anim.SetBool ("isTouched", true);
	}
	//activate vfx
	void Activate(){
		myVFX.SetActive(true);
	}

	//reset to off state
	void Deactivate(){
		myVFX.SetActive (false);
		anim.SetBool ("isTouched", false);
	}
}
