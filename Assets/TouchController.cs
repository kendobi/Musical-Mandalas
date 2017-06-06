using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public GameObject FingerGlow;
	private Vector3[] newPositions;
	public GameObject[] FingerGlows; 

	private GameObject go;

	void Start(){
		
		for (int i = 0; i < newPositions.Length; i++) {
		
			newPositions[i] = transform.position;
		}

	}


	void Update() {
		if(Input.touchCount >= 1){

			Touch[] myTouches = Input.touches;
			//for (int i = 0; i < Input.touchCount; i++) {
				if (Input.GetTouch (0).phase == TouchPhase.Began || Input.GetTouch (0).phase != TouchPhase.Ended)
 {		//	if (Input.GetMouseButton(0))


					Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
					RaycastHit hit = new RaycastHit ();
			
					if (Physics.Raycast (ray, out hit)) {
						print (hit.collider.name);
						go = hit.transform.gameObject;
						go.SendMessage ("Touched");
					}

					newPositions[0] = hit.point;
					newPositions[0].z = 0;
					FingerGlows[0].transform.position = newPositions[0];
				} 

				if (Input.GetTouch (0).phase == TouchPhase.Ended || Input.GetTouch (0).phase == TouchPhase.Canceled) {
					//if (Input.GetMouseButtonUp(0)){
					if (go != null) {
						go.SendMessage ("Untouched");
						Debug.Log ("Touch Released from : " + go.name);
					}

				}
			}

	}
}

