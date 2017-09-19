using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

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
		//anim.SetBool ("isTouched", true);
	}

	//activate vfx
	void Activate(){
		
	}

	void OnTriggerEnter(Collider other){
		anim.SetBool ("isTouched", true);
		anim.SetBool ("hasBeenActivated", true);

	

	}

	void OnTriggerExit(Collider other){

		anim.SetBool ("isTouched", false);
	
	}

	//reset to off state
	void Deactivate(){
		
		anim.SetBool ("isTouched", false);
	}
}
