using UnityEngine;
using System.Collections;

public class NotifyScene : MonoBehaviour {

	public GameObject go;
	public string val;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		go.SendMessage ("ActivateBool", val);
	
	}
}
