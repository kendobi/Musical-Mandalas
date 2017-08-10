using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

	public GameObject myVFX;
	Animator anim;

	bool TimerStarted = false;
	private float timer = 0f;
	public float TimeToTrigger = 10f;

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
		if (TimerStarted) {
			timer += Time.deltaTime;
		}

		if (timer >= TimeToTrigger) {
			
			emissionModule.rate = emissionRate;
		}
	
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
		if (!TimerStarted)
			TimerStarted = true;
	

	}

	void OnTriggerExit(Collider other){
		emissionModule.rate = 0f;
		anim.SetBool ("isTouched", false);
	
	}

	//reset to off state
	void Deactivate(){
		
		anim.SetBool ("isTouched", false);
	}
}
