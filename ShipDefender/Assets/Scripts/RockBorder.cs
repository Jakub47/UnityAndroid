using UnityEngine;
using System.Collections;

public class RockBorder : MonoBehaviour 
{
	public GameObject placeToCreate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Rock") 
		{
			
			Destroy (col.gameObject);
		}
	}
}
