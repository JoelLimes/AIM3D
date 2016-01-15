using UnityEngine;
using System.Collections;

public class CheckPlayer : MonoBehaviour {

  
    [SerializeField]private Transform[] enemyTransform;
    [SerializeField]
    private LayerMask layerMask;
	// Use this for initialization
    [SerializeField]private float _targetingRadius;
    public Transform destination;

    private NavMeshAgent agent;

	void Start () 
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*
        Collider[] foundColliders = Physics.OverlapSphere(enemyTransform[].position, _targetingRadius);

        bool playerFound = false;

        foreach (Collider coll in foundColliders)
        {
            if (coll == GameObject.FindGameObjectWithTag("Player"))
                playerFound = true;
        }
        */
        Collider[] colliders = Physics.OverlapSphere(transform.position, _targetingRadius, layerMask);
        int length = colliders.Length;

        Debug.Log(length);
        for (int i = 0; i < length; i++ )
        {
           
            if (colliders[i].tag == "Player")
            {
                agent.SetDestination(destination.position);
                break;
            }
        }
	}

}
