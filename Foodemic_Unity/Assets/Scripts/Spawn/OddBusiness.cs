using UnityEngine;
using System.Collections;

public class OddBusiness : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool die;
	public int targetNum;
	public GameObject target;
	public float speed = 0.1f;
	
	// Use this for initialization
	void Start () {
		//Sets business person's final destination
		targetNum = RandomEven ();

		//Sets path of the business person
		if (targetNum == 2) {
			target = GameObject.Find ("Empty2");
		}
		else if (targetNum == 4) {
			target = GameObject.Find ("Empty4");
		}
		else if (targetNum == 6) {
			target = GameObject.Find ("Empty6");
		}
		else if (targetNum == 8) {
			target = GameObject.Find ("Empty8");
		}
		else if (targetNum == 10) {
			target = GameObject.Find ("Empty10");
		}
	}
	
	int RandomEven()
	{
		//Generates a random even number
		int randint = Random.Range (1, 10);
		while(randint % 2 != 0) {
			randint = Random.Range (1, 10);
		} 
		return randint;
	}

	void CorrectCourse()
	{
		//returns the customer on their path when the stand is destroyed
		if (targetNum == 2) {
			target = GameObject.Find ("Empty2");
			speed = 0.1f;
		}
		else if (targetNum == 4) {
			target = GameObject.Find ("Empty4");
			speed = 0.1f;
		}
		else if (targetNum == 6) {
			target = GameObject.Find ("Empty6");
			speed = 0.1f;
		}
		else if (targetNum == 8) {
			target = GameObject.Find ("Empty8");
			speed = 0.1f;
		}
		else if (targetNum == 10) {
			target = GameObject.Find ("Empty10");
			speed = 0.1f;
		}
	}

	/*void FindStand()
	{
		//Use the foodstand array to find the food stands
		GameObject temp = GameObject.FindGameObjectWithTag ("Stand");
		if (temp != null) {
			target = temp;
			speed = 0.2f;
		} 
	}*/
	
	// Update is called once per frame
	void Update () {
		//The customer moves towards the target and they're destroyed when they reach the target
		try{
			Vector3 direction = (target.transform.position - transform.position).normalized;
			float distance = (target.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			//FindStand();
			if (distance < 1f) {
				die = true;
			}
		}catch(MissingReferenceException){
			CorrectCourse();
		}
		/*Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		
		if (distance < 1f) {
			die = true;
		}*/
		
		if (die) {
			Destroy (gameObject);
		}
	}
}
