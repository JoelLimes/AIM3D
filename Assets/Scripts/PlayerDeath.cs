using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			Debug.Log ("You've been Touch by.... SmoothPoliceMan");
		Destroy (this.gameObject);
		Application.LoadLevel ("LoseScene");
	}
}
