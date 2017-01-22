using UnityEngine;
using System.Collections;

public class TargetMandalaController : MonoBehaviour {


	private bool pressed;
	private int numBreaths = -1;
	public int bpl;

	public GameObject[] MandalaLayers;




	// Use this for initialization
	void Start () {
		pressed = false;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			pressed = true;
		}
		if (Input.GetMouseButtonUp (0)) {
			pressed = false;
			Activate (BreatheOutController.numBreaths);


		}
	}

	void Activate (int breaths){
		print (breaths);
		if ((breaths % bpl == 0) && (breaths >= 0)) {
			int currentLayer = breaths / bpl;

			for (int i = 0; i < MandalaLayers.Length; i++) {
				if (i == currentLayer) {
					MandalaLayers [i].SetActive (true);

					if (i > 0) {
						print ("turn off?");
						MandalaLayers [i - 1].SetActive (false);
					}
				}
			}
		}

	}
}

