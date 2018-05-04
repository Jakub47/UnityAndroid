using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public Sprite[] healthStatus;
	public SpriteRenderer currentImage;
	public float resetTime;
	public ParticleSystem explosion;

	private int counter;
	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void LoadNewImage()
	{
		counter++;
		currentImage.sprite = healthStatus [counter];
	}

	void PlayAnimation()
	{
		StartCoroutine ("PlayAndStop");
	}

	IEnumerator PlayAndStop()
	{
		explosion.Play ();

		yield return new WaitForSeconds (resetTime);

		explosion.Stop ();
	}
}
