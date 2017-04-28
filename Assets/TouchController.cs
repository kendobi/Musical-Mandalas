using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public GameObject FingerGlow;
	private Vector3 newPosition;

	private GameObject go;

	void Start(){
		newPosition = transform.position;
	}


	void Update() {
		if(Input.touchCount >= 1){
			if(Input.GetTouch(0).phase == TouchPhase.Began)
		//if (Input.GetMouseButtonDown(0))
			{


				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit = new RaycastHit ();
			
				if (Physics.Raycast (ray, out hit)) {
					print (hit.collider.name);
					go = hit.transform.gameObject;
					go.SendMessage ("Touched");
				}

				newPosition = hit.point;
				newPosition.z = 0;
				FingerGlow.transform.position = newPosition;
			} 

			if(Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(0).phase == TouchPhase.Canceled){
		//if (Input.GetMouseButtonUp(0)){
			if (go != null) {
				go.SendMessage ("Untouched");
				Debug.Log ("Touch Released from : " + go.name);
			}

			}
		else {

			//newPosition.y = 100;
			//FingerGlow.transform.position = newPosition;
		}

	}
}
}