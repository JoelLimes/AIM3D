using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour 
{
	void Update() {
		
		if (Input.GetKey(KeyCode.Q))
		{
			Application.Quit();
			
		}
	}
}