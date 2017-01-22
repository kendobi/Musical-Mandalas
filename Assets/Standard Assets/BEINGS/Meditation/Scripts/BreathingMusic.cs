using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;

public class BreathingMusic : MonoBehaviour {

	//private float distToGround;
	private Vector3 normal;
	private Vector3 myLastPos;

	private int numBreaths = 0;

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
	public string BreatheIn1 = "event:/BreatheIn_1";

	[FMODUnity.EventRef]
	public string BreatheOut1 = "event:/BreatheOut_1";


	[FMODUnity.EventRef]
	public string BreatheOut2 = "event:/BreatheOut_2";



	[FMODUnity.EventRef]
	public string BreatheOut3 = "event:/BreatheOut_3";


	[FMODUnity.EventRef]
	public string BreatheOut4 = "event:/BreatheOut_4";

	[FMODUnity.EventRef]
	public string BreatheOut5 = "event:/BreatheOut_5";

	[FMODUnity.EventRef]
	public string BreatheOut6 = "event:/BreatheOut_6";

	[FMODUnity.EventRef]
	public string BreatheOut7 = "event:/BreatheOut_7";

	[FMODUnity.EventRef]
	public string BreatheOut8 = "event:/BreatheOut_8";

	[FMODUnity.EventRef]
	public string BreatheOut9 = "event:/BreatheOut_7";

	[FMODUnity.EventRef]
	public string BreatheOut10 = "event:/BreatheOut_8";

	public GameObject prefab;

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
		//Track1Event.start();

		Track2Event = FMODUnity.RuntimeManager.CreateInstance(chords);
		//Track2Event.start();

		Track3Event = FMODUnity.RuntimeManager.CreateInstance(track3);
		//Track3Event.start();

		myOneShot = FMODUnity.RuntimeManager.CreateInstance(BreatheIn1);


		beatOn = false;

	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			PlayIn (BreatheOutController.numBreaths);

		}
		if (Input.GetMouseButtonUp (0)) {
			PlayOut (BreatheOutController.numBreaths);
			//numBreaths++;
		}

	}

	void PlayIn (int numBreaths){
		
			FMODUnity.RuntimeManager.PlayOneShot (BreatheIn1, transform.position);

	}

	void PlayOut (int numBreaths){
		FMODUnity.RuntimeManager.PlayOneShot (BreatheOut1, transform.position);
		switch (numBreaths) {
		case 0:
			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut2, transform.position);
			break;
		case 2:
			
			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut3, transform.position);
			break;
		case 4:
			
			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut4, transform.position);
			break;
		case 6:

			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut5, transform.position);
			break;
		case 8:
			
			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut6, transform.position);
			break;
		case 10:
			
			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut7, transform.position);
			break;
		case 12:

			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut8, transform.position);
			break;
		case 14:

			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut9, transform.position);
			break;
		case 16:
	
			FMODUnity.RuntimeManager.PlayOneShot (BreatheOut10, transform.position);
			break;
		}
	}
		

	public FMOD.RESULT StudioEventCallback(FMOD.Studio.EVENT_CALLBACK_TYPE type, IntPtr eventInstance, IntPtr parameters)
	{
		if (type == FMOD.Studio.EVENT_CALLBACK_TYPE.TIMELINE_BEAT) {
			FMOD.Studio.TIMELINE_BEAT_PROPERTIES beat = (FMOD.Studio.TIMELINE_BEAT_PROPERTIES)Marshal.PtrToStructure (parameters, typeof(FMOD.Studio.TIMELINE_BEAT_PROPERTIES));
			print ("beat");
			beatOn = true;



		} 
		else
			beatOn = false;
		return FMOD.RESULT.OK;
	}
		
}