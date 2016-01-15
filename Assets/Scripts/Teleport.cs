using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour 
{
	public GameObject player;
	public Transform spawnLocation;
	
	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player")
		{
			player = col.transform.gameObject;
			player.transform.position = spawnLocation.transform.position;
		}
	}
}

/**
* ...
* @author Joel Limes
* ...
**/