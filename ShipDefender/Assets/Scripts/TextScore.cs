using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextScore : MonoBehaviour {


	private static Text txt; 
	private static  int score;
	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void UpdateText()
	{
		score++;
		txt.text = "Score " + score;
	}

	public static void ResetText()
	{
		score = 0;
		txt.text = "Score " + score;
	}
}
