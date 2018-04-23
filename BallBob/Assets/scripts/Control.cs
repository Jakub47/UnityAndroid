using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Control : MonoBehaviour 
{
	Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float hInput = CrossPlatformInputManager.GetAxis ("Horizontal") * speed;
		float vInput = CrossPlatformInputManager.GetAxis ("Vertical") * speed;

		rb.AddForce (hInput,0.0f,vInput);
	}
}
