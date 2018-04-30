using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float rotationSpeed = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate(new Vector3(0,0,rotationSpeed * Time.deltaTime));
	}
}
