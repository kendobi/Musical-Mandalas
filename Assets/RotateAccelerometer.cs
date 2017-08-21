using UnityEngine;
using System.Collections;

public class RotateAccelerometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		Vector3 dir = Vector3.zero;
		dir = Input.acceleration.normalized;
		dir.y = 0;
		dir.z = 0;
		if (dir.x >= 0.3) {
			dir.x = 0.3f;
		} else if (dir.x <= -0.3) {
			dir.x = -0.3f;
		}
		Debug.Log (dir);
		transform.up = dir.normalized;
	}
}
