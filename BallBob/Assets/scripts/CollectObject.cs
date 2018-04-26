using UnityEngine;
using System.Collections;

public class CollectObject : MonoBehaviour 
{
	public float rotateSpeed;


	// Update is called once per frame
	void FixedUpdate () 
	{
		gameObject.transform.Rotate (0.0f,rotateSpeed,0.0f);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player") {
			other.SendMessage ("Increase");
			Destroy (gameObject);
		}	
	}

}
