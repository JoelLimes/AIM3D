using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
public class MotorScript : MonoBehaviour 
{
	public Transform centerOfMass;
	public float enginePower = 400f;
	public float turnPower = 10f;

	public Wheel[] wheel;

	Rigidbody rbody;


	void Awake()
	{
		rbody = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () 
	{
		rbody.centerOfMass = centerOfMass.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float torque = Input.GetAxis ("Vertical") * enginePower;
		float turnSpeed = Input.GetAxis ("Horizontal") * turnPower;

		if (torque != 0) {

			//front wheel drive  Select kind of drive
			wheel[0].Move (torque);
			wheel[1].Move (torque);

			//rear wheel drive
			wheel[2].Move(torque);
			wheel[3].Move(torque);
		}

		//front wheel steering Select kind of drive
		wheel [0].Turn (turnSpeed);
		wheel [1].Turn (turnSpeed);

		//rear wheel steering
//		wheel [2].Turn (turnSpeed);
//		wheel [3].Turn (turnSpeed);

	}
}


/**
* ...
* @author Joel Limes
* ...
**/