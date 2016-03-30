using UnityEngine;
using System.Collections;

public class Tourist : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, if the customer is hungry, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool check1 = true;
	public bool check2 = false;
	public bool check3 = false;
	public bool hungry = true;
	public bool odd;
	public bool die;
	public int targetNum;
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	public float speed;
	public float originalSpeed;

	// Use this for initialization
	void Start () {
		//Determines on what side of the map the customer is on and assign a targetNum based on that
		if (gameObject.transform.position.x < 0) {
			odd = true;
			targetNum = RandomEven();
		} else if (gameObject.transform.position.x > 0) {
			odd = false;
			targetNum = RandomOdd();
		}

		//Sets the speed and keeps track of the original speed
		speed = Random.Range(0.04f, 0.06f);
		originalSpeed = speed;

		//Sets path of the Tourist
		int randint = Random.Range (0, 20);
		if (randint <= 10) {
			normalTourist ();
		} else {
			lostTourist();
		}
	}

	int RandomOdd()
	{
		//Generates a random even number
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
		if (odd) {
			target2 = GameObject.Find ("Midpoint1");
			speed = originalSpeed;
		} else {
			target2 = GameObject.Find ("MidpointE");
			speed = originalSpeed;
		}
	}

	void FindStand()
	{
		//Use the foodstand array to find the food stands
		GameObject temp = GameObject.FindGameObjectWithTag ("Mascot");
		if (temp != null) {
			target2 = temp;
		} else {
			temp = GameObject.FindGameObjectWithTag ("Stand");
			if (temp != null) {
				target2 = temp;
				speed = originalSpeed * 2;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		//The customer moves towards the target and they're destroyed when they reach the target
		try{
			if (check1) {
				Vector3 direction = (target1.transform.position - transform.position).normalized;
				float distance = (target1.transform.position - transform.position).magnitude;
				Vector3 move = transform.position + (direction * speed);
				transform.position = move;
				FindStand();
				if(distance < 1f){
					check1 = false;
					check2 = true;
				}
			}
		}catch(MissingReferenceException){
			CorrectCourse();
		}
		try{
			if (check2) {
				Vector3 direction = (target2.transform.position - transform.position).normalized;
				float distance = (target2.transform.position - transform.position).magnitude;
				Vector3 move = transform.position + (direction * speed);
				transform.position = move;
				FindStand();
				if(distance < 1f){
					if(target2.gameObject.tag == "Stand"){
						/*check2 = false;
						check3 = true;
						Destroy(gameObject.GetComponent<Collider>());*/
						Destroy(gameObject);
					}else{
						check2 = false;
						check3 = true;
					}
				}
			}
		}catch(MissingReferenceException){
			CorrectCourse();
		}
		if (check3) {
			Vector3 direction = (target3.transform.position - transform.position).normalized;
			float distance = (target3.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			if(distance < 1f){
				die = true;
			}
		}
		
		if (die) {
			Destroy (gameObject);
		}
	}

	void normalTourist(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty1");
			break;
		case 2:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty2");
			break;
		case 3:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty3");
			break;
		case 4:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty4");
			break;
		case 5:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty5");
			break;
		case 6:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty6");
			break;
		case 7:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty7");
			break;
		case 8:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty8");
			break;
		case 9:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty9");
			break;
		case 10:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty10");
			break;
		}
	}

	void lostTourist(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty1");
			break;
		case 2:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty2");
			break;
		case 3:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty3");
			break;
		case 4:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty4");
			break;
		case 5:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty5");
			break;
		case 6:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty6");
			break;
		case 7:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty7");
			break;
		case 8:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty8");
			break;
		case 9:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty9");
			break;
		case 10:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty10");
			break;
		}
	}
}
