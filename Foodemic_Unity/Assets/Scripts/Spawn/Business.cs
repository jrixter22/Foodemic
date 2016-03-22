using UnityEngine;
using System.Collections;

public class Business : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, the side of the street they're on, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool odd;
	public bool die;
	public int targetNum;
	public GameObject target;
	public GameObject target2;
	public float speed/* = 0.1f*/;
	
	// Use this for initialization
	void Start () {
		//This will effectively tell you if the object being spawned is on the left or the right side of the screen. Alternatively you could create a Game Object variable called spawner and use the same transform.position.x logic on it to figure out what side the spawner is on.
		if (gameObject.transform.position.x > 0) {
			odd = false;
		} else if (gameObject.transform.position.x < 0) {
			odd = true;
		}

		//Sets a random speed
		speed = Random.Range(0.085f, 0.115f);

		//Gets random number based what side of the map they're on
		if (odd) {
			targetNum = RandomEven();
		} 
		else {
			targetNum = RandomOdd();
		}

		//Sets the target based on the target number
		switch (targetNum){
		case 1:
			target = GameObject.Find ("Empty1");
			break;
		case 2:
			target = GameObject.Find ("Empty2");
			break;
		case 3:
			target = GameObject.Find ("Empty3");
			break;
		case 4:
			target = GameObject.Find ("Empty4");
			break;
		case 5:
			target = GameObject.Find ("Empty5");
			break;
		case 6:
			target = GameObject.Find ("Empty6");
			break;
		case 7:
			target = GameObject.Find ("Empty7");
			break;
		case 8:
			target = GameObject.Find ("Empty8");
			break;
		case 9:
			target = GameObject.Find ("Empty9");
			break;
		case 10:
			target = GameObject.Find ("Empty10");
			break;
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
	
	void FindStand()
	{
		//Use the foodstand array to find the food stands
		GameObject temp = GameObject.FindGameObjectWithTag ("Stand");
		if (temp != null) {
			target2 = temp;
		}	
	}

	// Update is called once per frame
	void Update () {
		//The customer moves towards the target and they're destroyed when they reach the target
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		
		//FindStand ();
		
		if (distance < 1.0f) {
			die = true;
		}

		if (die) {
			numCustomers--;
			Destroy (gameObject);
		}
	}
	
}

