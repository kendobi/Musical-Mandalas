using UnityEngine;
using System.Collections;

public class FXemission : MonoBehaviour {

	public float emissionRate;

	ParticleSystem myPS;
	ParticleSystem.EmissionModule emissionModule;

	// Use this for initialization
	void Start () {
		myPS = GetComponent<ParticleSystem> ();
		emissionModule = myPS.emission;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Emit(){
	
		emissionModule.rate = emissionRate;
	
	}

	void DontEmit(){

		emissionModule.rate = 0f;
	
	}
}
