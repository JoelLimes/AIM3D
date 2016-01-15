using UnityEngine;
using System.Collections;

// Normal playercontroller for a walking player

public class PlayerController : MonoBehaviour 
{
	[SerializeField]
	private float rotationSpeed = 3.3f;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement ();
	}

	void Movement ()
	{
		float y = Input.GetAxis ("Horizontal");
		transform.Rotate (0,y * rotationSpeed * Time.deltaTime, 0);
	}
}

/**
* ...
* @author Joel Limes
* ...
**/
