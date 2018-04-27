using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Player : MonoBehaviour 
{
	//private
	Rigidbody rb;
	private int points;

	//public
	public float speed;
	public Text text;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		points = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float hInput = CrossPlatformInputManager.GetAxis ("Horizontal") * speed;
		float vInput = CrossPlatformInputManager.GetAxis ("Vertical") * speed;

		rb.AddForce (hInput,0.0f,vInput);
	}

	void Increase()
	{
		points++;
		text.text = points.ToString();
	}
}
