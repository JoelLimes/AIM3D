using UnityEngine;
using System.Collections;

	
public class CamControl : MonoBehaviour 
{	
	private bool change;
	public Transform currentMount; 

	[SerializeField]
	private Transform NextMount;
	public float SpeedFactor = 0.1f;
		
	// Use this for initialization
	void Start () 
	{

	}
		
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.P)) 
		{
			change = !change;
		}

		if (change) {
			transform.position = Vector3.Lerp (transform.position, currentMount.position, SpeedFactor);
			transform.rotation = Quaternion.Slerp (transform.rotation, currentMount.rotation, SpeedFactor);
		} else {
			transform.position = Vector3.Lerp (transform.position, NextMount.position, SpeedFactor);
			transform.rotation = Quaternion.Slerp (transform.rotation, NextMount.rotation, SpeedFactor);
		}
	}
	
	public void setmount (Transform newMount)
	{
		currentMount = newMount;
	}
}

/**
* ...
* @author Joel Limes
* ...
**/
