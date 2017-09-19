using UnityEngine;
using System.Collections;

public class GrowFX : MonoBehaviour {

	public GameObject myVFX;

	bool TimerStarted = false;
	private float timer = 0f;
	public float TimeToTrigger = 10f;

	public float emissionRate;

	ParticleSystem myPS;
	ParticleSystem.EmissionModule emissionModule;

	// Use this for initialization
	void Start () {
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
		//myVFX.SetActive(true);
	}

	void OnTriggerEnter(Collider other){

		if (!TimerStarted)
			TimerStarted = true;
		
	
	}

	void OnTriggerExit(Collider other){

		emissionModule.rate = 0f;
		TimerStarted = false;
		timer = 0f;

	}

	void Untouched () {
		//myVFX.SetActive (false);
	}
}
