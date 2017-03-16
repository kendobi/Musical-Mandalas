using UnityEngine;
using System.Collections;

public class LeveLoader : MonoBehaviour 
{
	public void LoadLevel(int index)
	{
		Application.LoadLevel(index);
	}

	public void LoadLevel(string levelName)
	{
		Application.LoadLevel(levelName);
	}
}