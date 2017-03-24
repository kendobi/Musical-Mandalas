using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public static bool a;
	public static bool b;
	public static bool c;

	Animator anim;


	// Use this for initialization
	void Start () {
		a = false;
		b = false;
		c = false;

		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void ActivateBool(int holder){
		if (holder == 1) {
			anim.SetBool ("a", true);
		}
		if (holder == 2) {
			anim.SetBool ("b", true);
		}
		if (holder == 3) {
			anim.SetBool ("c", true);
		}


	}
}

