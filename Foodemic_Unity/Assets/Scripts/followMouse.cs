using UnityEngine;
using System.Collections;

public class followMouse:MonoBehaviour
{
	//sets up the camera distance
	public float distance = 10f;
	public bool useCameraDistance = false;
	
	/*private float actualDistance;

	//sets up the objects camera distance
	void Start ()
	{
		if(useCameraDistance)
		{
			actualDistance = (transform.position - Camera.main.transform.position).magnitude;
		}
		else
		{
			actualDistance = distance;
		}
	}*/

	//moves the object with the mouse cursor
	void Update ()
	{
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = distance;
		transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
	}
}
