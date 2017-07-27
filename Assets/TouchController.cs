using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	public GameObject FingerGlow;
	public GameObject[] FingerGlows; 
	private Vector3 newPos;
	private float Energy;

	private GameObject go;

	void Start(){

		newPos = transform.position;
		Energy = 0;

	}


	void Update() {

		if (Input.GetMouseButton (0)) {	
			//Energy -= Time.deltaTime;
			//if (Energy >= 0) {
				Vector3 touchedPos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 40));
				transform.position = touchedPos;

			//}
		}

			//else if (Energy <= 10) {
			//	Energy += Time.deltaTime;
			//}

		
		//print (Energy);
			

	}
}

