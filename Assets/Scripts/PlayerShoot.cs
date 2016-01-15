using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Minigun shooting script

public class PlayerShoot : MonoBehaviour {

	[SerializeField]
	private GameObject Shot;

	[SerializeField]
	private Transform[] ShotSpawner;

	[SerializeField]
	private float fireRate;

	[SerializeField]
	private float nextFire;

	[SerializeField]
	private float spinning;



	void Start () 
	{

	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
			
		{
			transform.Rotate(Vector3.up, spinning);
			nextFire = Time.time + fireRate;

			int spawnPointIndex = Random.Range (0, ShotSpawner.Length);

			Instantiate (Shot, ShotSpawner[spawnPointIndex].position, ShotSpawner[spawnPointIndex].rotation);
//			AudioSource audio = GetComponent<AudioSource>();
//			audio.Play();
		}
	}
}

/**
* ...
* @author Joel Limes
* ...
**/
