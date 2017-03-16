using UnityEngine;
using System.Collections;

public class RaycastTest : MonoBehaviour {

	public GameObject FingerGlow;
	private Vector3 newPosition;

	void Start(){
		newPosition = transform.position;
	}


	void Update() {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit ();
		if (Input.GetMouseButton (0)) {
			
			if (Physics.Raycast (ray, out hit)) {
				print (hit.collider.name);
				hit.collider.gameObject.SendMessage ("Touched");
			}

			newPosition = hit.point;
			FingerGlow.transform.position = newPosition;
		} 
		else {

			newPosition.y = 1000;
			FingerGlow.transform.position = newPosition;
		}

	}
}