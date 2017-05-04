﻿using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public GameObject FingerGlow;
	private Vector3[] newPositions;
	public GameObject[] FingerGlows; 

	private GameObject go;

	void Start(){
		
		for (int i = 0; i < newPositions.Length; i++) {
		
			newPositions[i] = transform.position;
		}

	}


	void Update() {
		if(Input.touchCount >= 1){

			Touch[] myTouches = Input.touches;
			for (int i = 0; i < Input.touchCount; i++) {
				if (Input.GetTouch (i).phase != TouchPhase.Canceled || Input.GetTouch (i).phase != TouchPhase.Ended)
 {		//	if (Input.GetMouseButton(0))


					Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(i).position);
					RaycastHit hit = new RaycastHit ();
			
					if (Physics.Raycast (ray, out hit)) {
						print (hit.collider.name);
						go = hit.transform.gameObject;
						go.SendMessage ("Touched");
					}

					newPositions[i] = hit.point;
					newPositions[i].z = 0;
					FingerGlows[i].transform.position = newPositions[i];
				} 

				if (Input.GetTouch (i).phase == TouchPhase.Ended || Input.GetTouch (i).phase == TouchPhase.Canceled) {
					//if (Input.GetMouseButtonUp(0)){
					if (go != null) {
						go.SendMessage ("Untouched");
						Debug.Log ("Touch Released from : " + go.name);
					}

				}
			}

	}
}
}
