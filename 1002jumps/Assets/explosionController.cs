﻿using UnityEngine;
using System.Collections;

public class explosionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
