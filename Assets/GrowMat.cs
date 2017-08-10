using UnityEngine;
using System.Collections;

public class GrowMat : MonoBehaviour {

	public GameObject obj;
	Renderer mat;

	// Use this for initialization
	void Start () {
		mat = obj.GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		mat.material.color = new Color(0f, 0f, 0f, 1f);

	}


}
