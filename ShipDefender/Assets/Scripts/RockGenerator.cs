using UnityEngine;
using System.Collections;

public class RockGenerator : MonoBehaviour 
{
	public GameObject rock;
	public GameObject Sky;
	public float SpawnTime;

	// Use this for initialization
	void Awake () 
	{
		SpawnPipe ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

	}
		
	void SpawnPipe()
	{
		float rand = Random.Range (-7, 7);
		Instantiate (rock, new Vector3 (rand, transform.position.y), transform.rotation);
	}
}
