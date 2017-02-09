using UnityEngine;
using System.Collections;

public class BreatheOutController : MonoBehaviour {

	Animator animator;
	private bool pressed = false;
	public static int numBreaths = 0;
	public static int numInhales = 0;
	private float tapTime = 0.0f;
	private float timeSince = 0.0f;
	public float targetTime;
	private bool timeUp = false;

	public GameObject breatheOutObj;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			pressed = true;
			tapTime = Time.time;
			timeUp = true;
		}
		timeSince = Time.time - tapTime;
		if (Input.GetMouseButtonUp (0)) {
			pressed = false;


			if (timeSince >= targetTime) {
				numBreaths++;
				print ("full breath " + timeSince);
				}
		}
		if ((timeSince >= targetTime) && timeUp) {
			numInhales++;
			timeUp = false;
		}


		animator.SetBool ("isPressed", pressed);
		animator.SetInteger ("numBreaths", numBreaths);
	}


	void Activate (int breaths){



	}
}
