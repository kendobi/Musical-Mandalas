using UnityEngine;
using System.Collections;

public class GrowFX : MonoBehaviour {

	public GameObject myVFX;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//trigger on state
	void Touched () {
		//myVFX.SetActive(true);
	}

	void OnTriggerEnter(Collider other){

		myVFX.SetActive (true);
	
	}

	void Untouched () {
		//myVFX.SetActive (false);
	}
}
