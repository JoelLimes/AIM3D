using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// instantiate multiple enemies

public class SpawnEnemy : MonoBehaviour 
{
	public GameObject[] waypoints;
	
	
	[SerializeField]
	private List<GameObject> Bots;
	
	[SerializeField]
	private float spawnTime;
	
	
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnEnemies", spawnTime, spawnTime);
		GetComponent<MoveEnemy>().waypoints = waypoints;
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	
	void SpawnEnemies()
	{
		Instantiate(Bots[Random.Range(0,Bots.Count)]);
	}
}

/**
* ...
* @author Joel Limes
* ...
**/