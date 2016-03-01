using UnityEngine;
using System.Collections;

public class turnY : MonoBehaviour {
	
	//float mouseX;
	//float mouseY;
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition = Input.mousePosition;
		//float mouseX = mousePosition.x;
		float mouseY = mousePosition.y;
		
		//transform.Rotate (Vector3.right, mouseY);
		transform.eulerAngles = new Vector3(0, 0, mouseY);
	}
}
