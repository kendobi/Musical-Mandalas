using UnityEngine;
using System.Collections;

public class NotifyScene : MonoBehaviour {

	//public GameObject go;
	public int val;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (val == 1) {
			SceneController.a = true;
		}
		if (val == 2) {
			SceneController.b = true;
		}
		if (val == 3) {
			SceneController.c = true;
		}
	
	}
}
