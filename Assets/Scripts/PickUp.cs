using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			Debug.Log ("player has touched gun");
		Destroy (this.gameObject);
		Debug.Log ("HA, no more miniGun for you !!!");
	}
}
/**
* ...
* @author Joel Limes
* ...
**/