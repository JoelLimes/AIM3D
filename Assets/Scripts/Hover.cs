using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour 
{
	private Vector3 originalScale;
	new protected Collider collider;

	[SerializeField]
	public float rotationSpeed = 25.0f;
	public float hover = 0.3f;
	public float scaleSpeed = 2.0f;
	public float minSpawnTime = 5.0f;
	public float maxSpawnTime  = 15.0f;


	// Use this for initialization
	void Start () 
	{
		originalScale = transform.localScale;
		collider = GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	protected void Update () 
	{
		transform.Rotate (new Vector3 (0, Time.deltaTime * rotationSpeed, 0));
		Vector3 position = transform.position;
		position.y -= Mathf.Sin (Time.timeSinceLevelLoad) * Time.deltaTime * hover;
		position.y += Mathf.Sin (Time.timeSinceLevelLoad) *  hover;

		transform.position = position;
	}
}

/**
* ...
* @author Joel Limes
* ...
**/
