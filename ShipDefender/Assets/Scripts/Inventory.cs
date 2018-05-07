using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public Sprite[] healthStatus;
	public SpriteRenderer currentImage;
	public float resetTime;
	public ParticleSystem explosion;
	public GameObject placeToCreate;

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
		if (counter == 7) {
			TextScore.ResetText ();
			currentImage.sprite = healthStatus [0];
			counter = 0;
		}
		else
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

	void Generate() 
	{
		placeToCreate.SendMessage ("SpawnPipe");
	}
}
