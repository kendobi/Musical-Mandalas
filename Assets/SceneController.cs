using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public static bool a;
	public static bool b;
	public static bool c;

	Animator anim;

	public GameObject go1;
	public GameObject go2;
	public GameObject go3;
	public GameObject go4;


	// Use this for initialization
	void Start () {
		a = false;
		b = false;
		c = false;

		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a) {
			anim.SetBool ("a", true);
			go1.SetActive (true);
		}
		if (b) {
			anim.SetBool ("b", true);
			go2.SetActive (true);
		}
		if (c) {
			anim.SetBool ("c", true);
			go3.SetActive (true);
		}

		if (a && b && c) {
			go4.SetActive (true);
		}

	}
}

