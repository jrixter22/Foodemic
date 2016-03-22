using UnityEngine;
using System.Collections;

public class Circles : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, if the customer is hungry, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool check1 = true;
	public bool check2 = false;
	public bool check3 = false;
	public bool check4 = false;
	public bool check5 = false;
	public bool odd;
	public bool die;
	public int spawnLocal;
	public int targetNum;
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	public GameObject target4;
	public GameObject target5;
	public float speed;
	public float originalSpeed;
	
	// Use this for initialization
	void Start () {
		//Determines on what side of the map the customer is on and assign a targetNum based on that
		if (gameObject.transform.position.x < 0) {
			odd = true;
			targetNum = RandomEven();
			if(gameObject.transform.position.z < -1){
				spawnLocal = 1;
			}else if(gameObject.transform.position.z > -1 && gameObject.transform.position.z < 4){
				spawnLocal = 3;
			}else if(gameObject.transform.position.z > 4 && gameObject.transform.position.z < 8){
				spawnLocal = 5;
			}else if(gameObject.transform.position.z > 8 && gameObject.transform.position.z < 12){
				spawnLocal = 7;
			}else{
				spawnLocal = 9;
			}
		} else if (gameObject.transform.position.x > 0) {
			odd = false;
			targetNum = RandomOdd();
			if(gameObject.transform.position.z < -1){
				spawnLocal = 2;
			}else if(gameObject.transform.position.z > -1 && gameObject.transform.position.z < 3){
				spawnLocal = 4;
			}else if(gameObject.transform.position.z > 3 && gameObject.transform.position.z < 8){
				spawnLocal = 6;
			}else if(gameObject.transform.position.z > 8 && gameObject.transform.position.z < 12){
				spawnLocal = 8;
			}else{
				spawnLocal = 10;
			}
		}
		
		//Sets the speed and keeps track of the original speed
		speed = Random.Range(0.045f, 0.075f);
		originalSpeed = speed;
		
		//Sets path of the Customer
		switch (spawnLocal) {
		case 1:
			topLeft();
			break;
		case 2:
			bottomLeft();
			break;
		case 3:
			topLeft();
			break;
		case 4:
			bottomLeft();
			break;
		case 5:
			topLeft();
			break;
		case 6:
			bottomRight();
			break;
		case 7:
			topRight();
			break;
		case 8:
			bottomRight();
			break;
		case 9:
			topRight();
			break;
		case 10:
			bottomRight();
			break;
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
			if (check2) {
				Vector3 direction = (target2.transform.position - transform.position).normalized;
				float distance = (target2.transform.position - transform.position).magnitude;
				Vector3 move = transform.position + (direction * speed);
				transform.position = move;
				FindStand();
				if(distance < 1f){
					if(target2.gameObject.tag == "Stand"){
						Destroy(gameObject);
					}else{
						check2 = false;
						check3 = true;
					}
				}
			}
			if (check3) {
				Vector3 direction = (target3.transform.position - transform.position).normalized;
				float distance = (target3.transform.position - transform.position).magnitude;
				Vector3 move = transform.position + (direction * speed);
				transform.position = move;
				FindStand();
				if(distance < 1f){
					if(target3.gameObject.tag == "Stand"){
						Destroy(gameObject);
					}else{
						check3 = false;
						check4 = true;
					}
				}
			}
			if (check4) {
				Vector3 direction = (target4.transform.position - transform.position).normalized;
				float distance = (target4.transform.position - transform.position).magnitude;
				Vector3 move = transform.position + (direction * speed);
				transform.position = move;
				FindStand();
				if(distance < 1f){
					if(target4.gameObject.tag == "Stand"){
						Destroy(gameObject);
					}else{
						check4 = false;
						check5 = true;
					}
				}
			}
		}catch(MissingReferenceException){
			CorrectCourse();
		}
		if (check5) {
			Vector3 direction = (target5.transform.position - transform.position).normalized;
			float distance = (target5.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			if(distance < 1f){
				die = true;
			}
		}

		//Destroys customer
		if (die) {
			Destroy (gameObject);
		}
	}

	void topRight(){
		target1 = GameObject.Find ("Midpoint5");
		target2 = GameObject.Find ("MidpointE");
		target3 = GameObject.Find ("MidpointA");
		target4 = GameObject.Find ("Midpoint1");
		switch (targetNum){
		case 1:
			target5 = GameObject.Find ("Empty1");
			break;
		case 2:
			target5 = GameObject.Find ("Empty2");
			break;
		case 3:
			target5 = GameObject.Find ("Empty3");
			break;
		case 4:
			target5 = GameObject.Find ("Empty4");
			break;
		case 5:
			target5 = GameObject.Find ("Empty5");
			break;
		case 6:
			target5 = GameObject.Find ("Empty6");
			break;
		case 7:
			target5 = GameObject.Find ("Empty7");
			break;
		case 8:
			target5 = GameObject.Find ("Empty8");
			break;
		case 9:
			target5 = GameObject.Find ("Empty9");
			break;
		case 10:
			target5 = GameObject.Find ("Empty10");
			break;
		}
	}

	void bottomLeft(){
		target1 = GameObject.Find ("MidpointA");
		target2 = GameObject.Find ("Midpoint1");
		target3 = GameObject.Find ("Midpoint5");
		target4 = GameObject.Find ("MidpointE");
		switch (targetNum){
		case 1:
			target5 = GameObject.Find ("Empty1");
			break;
		case 2:
			target5 = GameObject.Find ("Empty2");
			break;
		case 3:
			target5 = GameObject.Find ("Empty3");
			break;
		case 4:
			target5 = GameObject.Find ("Empty4");
			break;
		case 5:
			target5 = GameObject.Find ("Empty5");
			break;
		case 6:
			target5 = GameObject.Find ("Empty6");
			break;
		case 7:
			target5 = GameObject.Find ("Empty7");
			break;
		case 8:
			target5 = GameObject.Find ("Empty8");
			break;
		case 9:
			target5 = GameObject.Find ("Empty9");
			break;
		case 10:
			target5 = GameObject.Find ("Empty10");
			break;
		}
	}

	void topLeft(){
		target1 = GameObject.Find ("Midpoint1");
		target2 = GameObject.Find ("Midpoint5");
		target3 = GameObject.Find ("MidpointE");
		target4 = GameObject.Find ("MidpointA");
		switch (targetNum){
		case 1:
			target5 = GameObject.Find ("Empty1");
			break;
		case 2:
			target5 = GameObject.Find ("Empty2");
			break;
		case 3:
			target5 = GameObject.Find ("Empty3");
			break;
		case 4:
			target5 = GameObject.Find ("Empty4");
			break;
		case 5:
			target5 = GameObject.Find ("Empty5");
			break;
		case 6:
			target5 = GameObject.Find ("Empty6");
			break;
		case 7:
			target5 = GameObject.Find ("Empty7");
			break;
		case 8:
			target5 = GameObject.Find ("Empty8");
			break;
		case 9:
			target5 = GameObject.Find ("Empty9");
			break;
		case 10:
			target5 = GameObject.Find ("Empty10");
			break;
		}
	}

	void bottomRight(){
		target1 = GameObject.Find ("MidpointE");
		target2 = GameObject.Find ("MidpointA");
		target3 = GameObject.Find ("Midpoint1");
		target4 = GameObject.Find ("Midpoint5");
		switch (targetNum){
		case 1:
			target5 = GameObject.Find ("Empty1");
			break;
		case 2:
			target5 = GameObject.Find ("Empty2");
			break;
		case 3:
			target5 = GameObject.Find ("Empty3");
			break;
		case 4:
			target5 = GameObject.Find ("Empty4");
			break;
		case 5:
			target5 = GameObject.Find ("Empty5");
			break;
		case 6:
			target5 = GameObject.Find ("Empty6");
			break;
		case 7:
			target5 = GameObject.Find ("Empty7");
			break;
		case 8:
			target5 = GameObject.Find ("Empty8");
			break;
		case 9:
			target5 = GameObject.Find ("Empty9");
			break;
		case 10:
			target5 = GameObject.Find ("Empty10");
			break;
		}
	}
}
