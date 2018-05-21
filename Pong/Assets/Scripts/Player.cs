using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
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