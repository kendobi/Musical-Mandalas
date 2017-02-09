using UnityEngine;
using System.Collections;

public class DeActivateVFX: MonoBehaviour {

	public GameObject myVFX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Activate(bool trigger){
		myVFX.SetActive(trigger);
	}
}
