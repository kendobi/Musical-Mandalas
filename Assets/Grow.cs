using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

	public GameObject myVFX;
	Animator anim;

	public float emissionRate;

	ParticleSystem myPS;
	ParticleSystem.EmissionModule emissionModule;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myPS = myVFX.GetComponent<ParticleSystem> ();
		emissionModule = myPS.emission;
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
		emissionModule.rate = emissionRate;
	}

	void OnTriggerEnter(Collider other){
		anim.SetBool ("isTouched", true);

	

	}

	void OnTriggerExit(Collider other){
		
		anim.SetBool ("isTouched", false);
	
	}

	//reset to off state
	void Deactivate(){
		emissionModule.rate = 0f;
		anim.SetBool ("isTouched", false);
	}
}
