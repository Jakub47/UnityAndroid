using UnityEngine;
using System.Collections;

public class RockGenerator : MonoBehaviour 
{
	public GameObject rock;
	public GameObject Sky;
	public float setTime = 3f;

	private float timer;

	// Use this for initialization
	void Awake () 
	{
		SpawnPipe ();
		timer = 0.0f;
	}
	
	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= setTime) {
			setTime--;
			Debug.Log (setTime);
			timer = 0.0f;
			SpawnPipe ();
		}

		if (setTime < 1) {
			setTime = 3f;
		}
	}

	IEnumerator CreateRandomRocks()
	{
		yield return new WaitForSeconds (7);
		SpawnPipe ();
	}

		
	void SpawnPipe()
	{
		float rand = Random.Range (-7, 7);
		Instantiate (rock, new Vector3 (rand, transform.position.y), transform.rotation);
	}



}
