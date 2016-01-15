using UnityEngine;
using System.Collections;
/**
* ...
* @author Joel Limes
* ...
**/
public class MoveEnemy : MonoBehaviour 
{
	public GameObject[] waypoints;
	private int currentWaypoint = 0;
	private float lastWaypointSwitchTime;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () 
	{
		lastWaypointSwitchTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{

		// Step 1
		Vector3 startPosition = waypoints [currentWaypoint].transform.position;
		Vector3 endPosition = waypoints [currentWaypoint + 1].transform.position;

//		Vector3 desiredStep = endPosition - rigidbody.position;
		// step 2
		float pathLenght = Vector3.Distance (startPosition, endPosition);
		float totalTimeforPath = pathLenght / speed;
		float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
		gameObject.transform.position = Vector3.Lerp (startPosition, endPosition, currentTimeOnPath / totalTimeforPath);
		
		// step 3
		if (gameObject.transform.position.Equals (endPosition)) 
		{
			if(currentWaypoint < waypoints.Length - 2)
			{
				// step 3.A
				currentWaypoint++;
				lastWaypointSwitchTime = Time.time;
			}
			
			else 
			{
				// step 3.B
				Destroy(gameObject);
			}
			
		}
	}
}
/**
* ...
* @author Joel Limes
* ...
**/