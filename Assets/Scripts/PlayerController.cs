using UnityEngine;
using System.Collections;

// Normal playercontroller for a walking player

public class PlayerController : MonoBehaviour 
{
	[SerializeField]
	private float rotationSpeed = 3.3f;

	public CollectiblesManager collectableManager;
	
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

	void OnTriggerExit(Collider other)
	{
		Debug.Log ("is er contact ??");
		if (other.transform.tag == "Collectable")
		{
			Destroy(other.gameObject);
			{
				AudioSource audio = GetComponent<AudioSource>();
				audio.Play();
			}
			collectableManager.AddCollectable();

		}
	}
}

/**
* ...
* @author Joel Limes
* ...
**/
