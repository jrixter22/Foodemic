using UnityEngine;
using System.Collections;

public class Eco : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool die;
	public int targetNum = 1;
	public GameObject target;
	public float speed = 0.075f;

	// Use this for initialization
	void Start () {
		//Decides where to go
		Decide ();
	}

	GameObject Decide(){
		//Sets path to the specific Empty
		if (targetNum == 1) {
			target = GameObject.Find ("Post1");
			targetNum = 2;
		}
		else if (targetNum == 2) {
			target = GameObject.Find ("Post2");
			targetNum = 1;
		}
		
		return target;
	}
	
	// Update is called once per frame
	void Update () {
		//The Environmentalist move back and forth
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		
		if (distance < 1f) {
			Decide ();
		}
	}
}
