﻿using UnityEngine;
using System.Collections;

public class bulletSpeed : MonoBehaviour 
{
	public float speed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (new Vector3 (0,0,1) * speed * Time.deltaTime);
	}
}

/**
* ...
* @author Joel Limes
* ...
**/
