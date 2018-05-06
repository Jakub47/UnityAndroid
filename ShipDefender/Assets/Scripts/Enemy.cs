using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float rotationSpeed = 100;
	public GameObject pl;

	// Use this for initialization
	void Start () {
	
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Blast") {
			pl.SendMessage ("Generate");
			Destroy (col.gameObject);
			Destroy (gameObject);
		}

		if(col.gameObject.tag == "Player")
		{
			pl = col.gameObject;
			col.SendMessage ("LoadNewImage");
			col.SendMessage ("PlayAnimation");
			col.SendMessage ("Generate");
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.Rotate(new Vector3(0,0,rotationSpeed * Time.deltaTime));
	}
}
