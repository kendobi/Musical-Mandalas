﻿using UnityEngine;
using System.Collections;

public class ParticleSortLayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Front";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
