﻿using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;

public class Music : MonoBehaviour {

	//private float distToGround;
	private Vector3 normal;
	private Vector3 myLastPos;

	//events
	FMOD.Studio.EventInstance soundSystem;
	[FMODUnity.EventRef]
	public string music = "event:/GrooveForest";

	FMOD.Studio.EventInstance Track1Event;
	[FMODUnity.EventRef]
	public string drums = "event:/Track1";

	FMOD.Studio.EventInstance Track2Event;
	[FMODUnity.EventRef]
	public string chords = "event:/Track2";

	FMOD.Studio.EventInstance Track3Event;
	[FMODUnity.EventRef]
	public string track3 = "event:/Track3";

	FMOD.Studio.EventInstance Track4Event;
	[FMODUnity.EventRef]
	public string track4 = "event:/Track4";

	//volume paramters
	FMOD.Studio.ParameterInstance track1VolParam;
	FMOD.Studio.ParameterInstance track2VolParam;
	FMOD.Studio.ParameterInstance track3VolParam;
	FMOD.Studio.ParameterInstance track4VolParam;
	FMOD.Studio.ParameterInstance track5VolParam;
	FMOD.Studio.ParameterInstance track6VolParam;
	FMOD.Studio.ParameterInstance track7VolParam;
	FMOD.Studio.ParameterInstance track8VolParam;
	FMOD.Studio.ParameterInstance track9VolParam;

	//event callback
	FMOD.Studio.EVENT_CALLBACK cb;

	[FMODUnity.EventRef]
	FMOD.Studio.EventInstance myOneShot;
	public string oneShot = "event:/OneShot";

	public GameObject prefab;

	public string track1Tag;
	public string track2Tag;
	public string track3Tag;
	public string track4Tag;
	public string track5Tag;
	public string track6Tag;
	public string track7Tag;
	public string track8Tag;
	public string track9Tag;

	public bool beatOn;

	// Use this for initialization
	void Start () {

		//distToGround = GetComponent<Collider> ().bounds.size.y - GetComponent<Collider>();

		//start music
		Track4Event = FMODUnity.RuntimeManager.CreateInstance(track4);
		Track4Event.start();

		Track1Event = FMODUnity.RuntimeManager.CreateInstance(drums);
		cb = new FMOD.Studio.EVENT_CALLBACK(StudioEventCallback);
		Track1Event.setCallback(cb, FMOD.Studio.EVENT_CALLBACK_TYPE.TIMELINE_MARKER | FMOD.Studio.EVENT_CALLBACK_TYPE.TIMELINE_BEAT);
		Track1Event.start();

		Track2Event = FMODUnity.RuntimeManager.CreateInstance(chords);
		Track2Event.start();

		Track3Event = FMODUnity.RuntimeManager.CreateInstance(track3);
		Track3Event.start();

		myOneShot = FMODUnity.RuntimeManager.CreateInstance(oneShot);

		//setup parameters
		/*Track1Event.getParameter("Track1Vol", out track1VolParam);
		track1VolParam.setValue (0);

		Track2Event.getParameter("Track1Vol", out track2VolParam);
		track2VolParam.setValue (0);

		Track3Event.getParameter("Track1Vol", out track3VolParam);
		track3VolParam.setValue (0);

		Track4Event.getParameter("Track1Vol", out track4VolParam);
		track4VolParam.setValue (0);

		soundSystem.getParameter("Track5Vol", out track5VolParam);
		track5VolParam.setValue (0);
		soundSystem.getParameter("Track6Vol", out track6VolParam);
		track6VolParam.setValue (0);
		soundSystem.getParameter("Track7Vol", out track7VolParam);
		track7VolParam.setValue (0);
		soundSystem.getParameter("Track8Vol", out track8VolParam);
		track8VolParam.setValue (0);
		soundSystem.getParameter("Track9Vol", out track9VolParam);
		track9VolParam.setValue (0);*/

		beatOn = false;

	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		//Vector3 position = other.gameObject.transform.position;
		//FMOD_VECTOR pos = position;
		if (beatOn) {
			if (other.gameObject.CompareTag (track1Tag)) {
				Track1Event.set3DAttributes (FMODUnity.RuntimeUtils.To3DAttributes (other.transform.position));
				//TriggerTrack (track1VolParam);
				print ("stone trigger");
			}
			if (other.gameObject.CompareTag (track2Tag)) {
				Track2Event.set3DAttributes (FMODUnity.RuntimeUtils.To3DAttributes (other.transform.position));
				//TriggerTrack (track2VolParam);
				print ("grass trigger");
			}
			if (other.gameObject.CompareTag (track3Tag)) {
				Track3Event.set3DAttributes (FMODUnity.RuntimeUtils.To3DAttributes (other.transform.position));
				//TriggerTrack (track3VolParam);
				print ("tree trigger");
			}
			if (other.gameObject.CompareTag (track4Tag)) {
				//TriggerTrack (track4VolParam);
				print ("tree trigger");
			}
			if (other.gameObject.CompareTag (track5Tag)) {
				//TriggerTrack (track5VolParam);
				print ("tree trigger");
			}
			if (other.gameObject.CompareTag (track6Tag)) {
				//TriggerTrack (track6VolParam);
				print ("tree trigger");
			}
			if (other.gameObject.CompareTag (track7Tag)) {
				//TriggerTrack (track7VolParam);
				print ("tree trigger");
			}
			if (other.gameObject.CompareTag (track8Tag)) {
				//TriggerTrack (track8VolParam);
				print ("tree trigger");
			}
			if (other.gameObject.CompareTag (track9Tag)) {
				//TriggerTrack (track9VolParam);
				print ("tree trigger");
			}
		} 
		else beatOn = false;

	}

	/*void TriggerTrack(FMOD.Studio.ParameterInstance param){
		FadeIn (param);
	}

	void FadeIn(FMOD.Studio.ParameterInstance param){
		param.setValue (1);
	}

	void FadeOut(FMOD.Studio.ParameterInstance param){
		param.setValue (0);
	}*/

	public FMOD.RESULT StudioEventCallback(FMOD.Studio.EVENT_CALLBACK_TYPE type, IntPtr eventInstance, IntPtr parameters)
	{
		if (type == FMOD.Studio.EVENT_CALLBACK_TYPE.TIMELINE_BEAT) {
			FMOD.Studio.TIMELINE_BEAT_PROPERTIES beat = (FMOD.Studio.TIMELINE_BEAT_PROPERTIES)Marshal.PtrToStructure (parameters, typeof(FMOD.Studio.TIMELINE_BEAT_PROPERTIES));
			print ("beat");
			beatOn = true;
			//Vector3 newPosition = transform.position;
			SpawnObject(prefab);



		} 
		else
			beatOn = false;
		return FMOD.RESULT.OK;
	}

	void SpawnObject(GameObject obj){
		Vector3 myPos = transform.position;

		RaycastHit hit;
		if (Physics.Raycast(transform.position, -transform.up, out hit, 10)){
			normal = hit.normal;
			if(Vector3.Distance(myPos,myLastPos) > 0.5){
				GameObject go = (GameObject)Instantiate (prefab, hit.point, Quaternion.identity);
				go.transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * go.transform.rotation;
			}

			myLastPos = myPos;
		}
	}
		
}