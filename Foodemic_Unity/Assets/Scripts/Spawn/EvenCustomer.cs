using UnityEngine;
using System.Collections;

public class EvenCustomer : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, the side of the street they're on, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool odd;
	public bool die;
	public int targetNum;
	public GameObject target;
	public GameObject target2;
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		//Check the ID number of the customer's spawner to determine which side of the street they're on
		//Code to figure out the ID of spawn point
		odd = false;
		//Use random number generator to determine which spawner on the other side of the street to go to
		if (odd) {
			targetNum = RandomEven ();
		} else {
			targetNum = RandomOdd();
		}

		if (targetNum == 1) {
			target = GameObject.Find ("Empty1");
		} 
		else if (targetNum == 2) {
			target = GameObject.Find ("Empty2");
		}
		else if (targetNum == 3) {
			target = GameObject.Find ("Empty3");
		}
		else if (targetNum == 4) {
			target = GameObject.Find ("Empty4");
		}
		else if (targetNum == 5) {
			target = GameObject.Find ("Empty5");
		}
		else if (targetNum == 6) {
			target = GameObject.Find ("Empty6");
		}
		else if (targetNum == 7) {
			target = GameObject.Find ("Empty7");
		}
		else if (targetNum == 8) {
			target = GameObject.Find ("Empty8");
		}
		else if (targetNum == 9) {
			target = GameObject.Find ("Empty9");
		}
		else if (targetNum == 10) {
			target = GameObject.Find ("Empty10");
		}
	}
	
	int RandomOdd()
	{
		//Generates a random odd number
		int randint = Random.Range (1, 10);
		while(randint % 2 == 0) {
			randint = Random.Range (1, 10);
		} 
		return randint;
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
		if (targetNum == 1) {
			target = GameObject.Find ("Empty1");
			speed = 0.1f;
		} 
		else if (targetNum == 3) {
			target = GameObject.Find ("Empty3");
			speed = 0.1f;
		}
		else if (targetNum == 5) {
			target = GameObject.Find ("Empty5");
			speed = 0.1f;
		}
		else if (targetNum == 7) {
			target = GameObject.Find ("Empty7");
			speed = 0.1f;
		}
		else if (targetNum == 9) {
			target = GameObject.Find ("Empty9");
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
		//FindStand ();
		if (distance < 1f) {
			die = true;
		}*/
		
		if (die) {
			numCustomers--;
			Destroy (gameObject);
		}
	}
}
