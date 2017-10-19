using UnityEngine;
using System.Collections;

public class GrowMat : MonoBehaviour {

	public GameObject obj;
	public float speedOn = 0.5f;
	public float speedOff = 0.5f;
	Renderer mat;

	private float min = 0.0f;
	public float max = 1.0f;
	private float myopacity = 0.0f;
	private float currOpacity = 0.0f;
	private float t = 0.0f;

	private bool isTriggered = false;

	// Use this for initialization
	void Start () {
		mat = obj.GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		if (isTriggered) {


			
			myopacity = Mathf.Lerp (currOpacity,max, t);
			t += speedOn * Time.deltaTime;

		} else if (!isTriggered && myopacity>0.1f) {

			
			myopacity = Mathf.Lerp (currOpacity,min, t);
			t += speedOff * Time.deltaTime;
		}

		mat.material.SetFloat ("_opacity", myopacity);

	}

	void OnTriggerEnter(Collider other){
		
		isTriggered = true;
		t = 0.0f;
		currOpacity = myopacity;

	}

	void OnTriggerExit(Collider other){
		isTriggered = false;
		t = 0.0f;
		currOpacity = myopacity;
	}


}
