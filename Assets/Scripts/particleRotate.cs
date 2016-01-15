using UnityEngine;
using System.Collections;

public class particleRotate : MonoBehaviour 
{
	public float spinning;
	public float speed;
	public float criscros;
	
	void Start()
	{
		
	}
	
	
	void Update () 
	{
		transform.Rotate(Vector3.up, spinning);
		
		transform.Translate (new Vector3 (0,1,0) * speed * Time.deltaTime);
		
		transform.Rotate (new Vector3 (0, 0, 1) * criscros);
	}
}

/**
* ...
* @author Joel Limes
* ...
**/