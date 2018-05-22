using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text txt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Rect topLeft = new Rect(0, 0, Screen.width / 2, Screen.height / 2);
		Rect bottomLeft = new Rect(0, Screen.height / 2, Screen.width / 2, Screen.height / 2);
		Rect topRight = new Rect(Screen.width / 2, 0, Screen.width / 2, Screen.height / 2);
		Rect bottomRight = new Rect(Screen.width / 2, Screen.height / 2, Screen.width / 2, Screen.height / 2);

		if (Input.touchCount > 0)
		{
			var touchPos = Input.GetTouch(0).position;
			print (touchPos);
			if (topLeft.Contains(touchPos))
			{
				txt.text =  "topLeft touched";
			}
			if (bottomLeft.Contains(touchPos))
			{
				txt.text =  "bottomLeft touched";
			}
			if (topRight.Contains(touchPos))
			{
				txt.text =  "topRight touched" ;
			}  
			if (bottomRight.Contains(touchPos))
			{
				txt.text =  "bottomRight touched";
			}
		}
	}
}


/* Mobile ver.
if (Input.touchCount > 0)
          {
              Touch touch = Input.GetTouch (0);
              if (touch.position.x < Screen.width/2)
              {
                  //Move Player Left
              }
              else if (touch.position.x > Screen.width/2)
              {
                  //Move Player Right
              }
          }
          else 
              //Do nothing for now
          }

*/

/* Com ver
if(Input.GetMouseButtonDown(0))
{
	if (Input.mousePosition.x < Screen.width/2)
	{
		Debug.Log ("left");
	}
	else if (Input.mousePosition.x > Screen.width/2)
	{
		Debug.Log ("right");
	}
}
else {
	//Do nothing for now
}

*/