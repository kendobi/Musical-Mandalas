using UnityEngine;
using System.Collections;

public class ActivateVFX : MonoBehaviour {

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
