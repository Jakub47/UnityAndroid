﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {


	public Rigidbody2D ship;
	public float speed;
	public GameObject blast;
	public float speedForBlast;

	// Use this for initialization
	void Start () 
	{
		
	}


	
	// Update is called once per frame
	void FixedUpdate () {
		float hInput = CrossPlatformInputManager.GetAxis ("Horizontal") * speed * Time.deltaTime;
		ship.AddForce (new Vector2 (hInput, 0.0f));
	}

	public void Fire()
	{
		Instantiate (blast, ship.gameObject.transform.position, Quaternion.identity);
	}
		
}
