﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public CollectiblesManager collectableManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Collectable")
        {
            collectableManager.AddCollectable();
            Destroy(other.gameObject);
        }
    }
}
