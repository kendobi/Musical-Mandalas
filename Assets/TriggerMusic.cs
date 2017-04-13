using UnityEngine;
using System.Collections;

public class TriggerMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		GetComponent<FMODUnity.StudioParameterTrigger>().TriggerParameters();
		print ("HIT");
	}
}
