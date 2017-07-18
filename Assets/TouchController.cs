using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public GameObject FingerGlow;
	public GameObject[] FingerGlows; 
	private Vector3 newPos;

	private GameObject go;

	void Start(){

		newPos = transform.position;

	}


	void Update() {
		if(Input.touchCount >= 1){

			Touch[] myTouches = Input.touches;
			//for (int i = 0; i < Input.touchCount; i++) {
				if (Input.GetTouch (0).phase == TouchPhase.Began)
 				{		//	if (Input.GetMouseButton(0))


					Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
					RaycastHit hit = new RaycastHit ();
			
					if (Physics.Raycast (ray, out hit)) {
						print (hit.collider.name);
						go = hit.transform.gameObject;
						go.SendMessage ("Touched");
					}

					newPos = hit.point;
					//newPos.z = 0;
					FingerGlows[0].transform.position = newPos;
				}

			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
			
				Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
				RaycastHit hit = new RaycastHit ();

				newPos = hit.point;
				//newPos.z = 0;
				FingerGlows[0].transform.position = newPos;
			
			}

				/*if (Input.GetTouch (0).phase == TouchPhase.Ended || Input.GetTouch (0).phase == TouchPhase.Canceled) {
					//if (Input.GetMouseButtonUp(0)){
					if (go != null) {
						go.SendMessage ("Untouched");
						Debug.Log ("Touch Released from : " + go.name);
					}

				}*/
			}

	}
}

