using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour 
{

	public void SceneButton (string Level){
		SceneManager.LoadScene (Level);
	}

}
