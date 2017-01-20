using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float speed = 1;

	private void Update () {
		transform.Rotate (Vector3.forward * Time.deltaTime * speed);
	}
}
