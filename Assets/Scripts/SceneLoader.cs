using UnityEngine;
using System.Collections;


public class SceneLoader : MonoBehaviour 
{
	public void Change(int scene) 
	{
		Application.LoadLevel (scene);
	}
}

/**
* ...
* @author Joel Limes
* ...
**/