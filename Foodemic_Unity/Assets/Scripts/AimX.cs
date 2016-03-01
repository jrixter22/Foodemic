using UnityEngine;
using System.Collections;

public class AimX : MonoBehaviour {
	public bool contLeft = true;
	public bool contRight = true;
	public int speed = 3;
	public int spin = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Allows the gun to turn left when the left arrow key is pressed
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if(contLeft){
				transform.Rotate(0,0,-speed);
				spin -= speed;
			}
		}

		//Allows the gun to turn right when the right arrow key is pressed
		if (Input.GetKey (KeyCode.RightArrow)) {
			if(contRight){
				transform.Rotate(0,0,speed);
				spin += speed;
			}
		}

		//Test speed values
		if (Input.GetKey (KeyCode.Keypad1)) {
			speed = 1;
		} else if (Input.GetKey (KeyCode.Keypad2)) {
			speed = 2;
		} else if (Input.GetKey (KeyCode.Keypad3)) {
			speed = 3;
		} else if (Input.GetKey (KeyCode.Keypad4)) {
			speed = 4;
		} else if (Input.GetKey (KeyCode.Keypad5)) {
			speed = 5;
		} else if (Input.GetKey (KeyCode.Keypad6)) {
			speed = 6;
		} else if (Input.GetKey (KeyCode.Keypad7)) {
			speed = 7;
		} else if (Input.GetKey (KeyCode.Keypad8)) {
			speed = 8;
		} else if (Input.GetKey (KeyCode.Keypad9)) {
			speed = 9;
		}

		//Prevents the gun from turning too far right
		if (spin >= 90) {
			contRight = false;
		} else if (spin < 90) {
			contRight = true;
		}

		//Prevents the gun from turning too far left
		if (spin <= -90) {
			contLeft = false;
		} else if (spin > -90) {
			contLeft = true;
		}
	}
}
