using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 topLeft = Rect (0, 0, Screen.width / 2, Screen.height / 2);
		Vector3 bottomLeft = Rect (0, 0, Screen.width / 2, Screen.height / 2);

		if (Input.touchCount > 0) {
			if(topLeft.Contains())
		}
	}
}
