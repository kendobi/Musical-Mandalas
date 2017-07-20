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
		//if(Input.touchCount >= 1){

			//Touch[] myTouches = Input.touches;
			//Touch touch = Input.GetTouch (0);
			//for (int i = 0; i < Input.touchCount; i++) {
			//if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
			if (Input.GetMouseButton(0))
 				{		//	if (Input.GetMouseButton(0))


					/*Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
					RaycastHit hit = new RaycastHit ();
			
					if (Physics.Raycast (ray, out hit)) {
						print (hit.collider.name);
						go = hit.transform.gameObject;
						go.SendMessage ("Touched");
					}

					newPos = hit.point;
					//newPos.z = 0;
					FingerGlows[0].transform.position = newPos;*/


				Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40));
					// lerp and set the position of the current object to that of the touch, but smoothly over time.
				transform.position = touchedPos;
				}
				

				/*if (Input.GetTouch (0).phase == TouchPhase.Ended || Input.GetTouch (0).phase == TouchPhase.Canceled) {
					//if (Input.GetMouseButtonUp(0)){
					if (go != null) {
						go.SendMessage ("Untouched");
						Debug.Log ("Touch Released from : " + go.name);
					}

				}*/
			//}

	}
}

