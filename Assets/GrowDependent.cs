using UnityEngine;
using System.Collections;

public class GrowDependent : MonoBehaviour {

	public GameObject[] beings;
	private bool allClear;
	public GameObject transformation;
	private Animator myAnim;
	private int numActive;

	// Use this for initialization
	void Start () {
		numActive = 0;
		allClear = true;
		myAnim = transformation.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		numActive = 0;
		for(int i=0 ; i < beings.Length; i++){
			Animator anim = beings[i].GetComponent<Animator> ();
			if (anim.GetBool("hasBeenActivated")){
				numActive++;
			}
		}
		if (numActive >= beings.Length){
			myAnim.SetBool("isTouched", true);
		}
	}
}
