using UnityEngine;
using System.Collections;

public class Careful : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, if the customer is hungry, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool check1 = true;
	public bool check2 = false;
	public bool check3 = false;
	public bool hungry = true;
	public bool odd;
	public bool die;
	public int spawnLocal;
	public int targetNum;
	public Transform customer;
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	public float speed/* = 0.05f*/;
	public float originalSpeed;
	public float startZ;
	public bool checkers = false;
	
	// Use this for initialization
	void Start () {
		//Determines on what side of the map the customer is on and assign a targetNum based on that
		startZ = gameObject.transform.position.z;
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
		speed = Random.Range(0.05f, 0.075f);
		originalSpeed = speed;
		
		//Sets path of the Customer
		switch (spawnLocal) {
		case 1:
			spawn1();
			break;
		case 2:
			spawn2();
			break;
		case 3:
			spawn3();
			break;
		case 4:
			spawn4();
			break;
		case 5:
			spawn5();
			break;
		case 6:
			spawn6();
			break;
		case 7:
			spawn7();
			break;
		case 8:
			spawn8();
			break;
		case 9:
			spawn9();
			break;
		case 10:
			spawn10();
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
		speed = originalSpeed;
		switch(spawnLocal){
		case 1:
			if (targetNum == 2) {
				target2 = GameObject.Find ("MidpointA");
			}
			else if (targetNum == 4) {
				target2 = GameObject.Find ("MidpointB");
			}
			else if (targetNum == 6) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 8) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 10) {
				target2 = GameObject.Find ("MidpointD");
			}
			break;
		case 2:
			if (targetNum == 1) {
				target2 = GameObject.Find ("Midpoint1");
			}
			else if (targetNum == 3) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 5) {
				target2 = GameObject.Find ("Midpoint3");
			}
			else if (targetNum == 7) {
				target2 = GameObject.Find ("Midpoint3");
			}
			else if (targetNum == 9) {
				target2 = GameObject.Find ("Midpoint4");
			}
			break;
		case 3:
			if (targetNum == 2) {
				target2 = GameObject.Find ("MidpointA");
			}
			else if (targetNum == 4) {
				target2 = GameObject.Find ("MidpointB");
			}
			else if (targetNum == 6) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 8) {
				target2 = GameObject.Find ("MidpointD");
			}
			else if (targetNum == 10) {
				target2 = GameObject.Find ("MidpointD");
			}
			break;
		case 4:
			if (targetNum == 1) {
				target2 = GameObject.Find ("Midpoint1");
			}
			else if (targetNum == 3) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 5) {
				target2 = GameObject.Find ("Midpoint3");
			}
			else if (targetNum == 7) {
				target2 = GameObject.Find ("Midpoint4");
			}
			else if (targetNum == 9) {
				target2 = GameObject.Find ("Midpoint4");
			}
			break;
		case 5:
			if (targetNum == 2) {
				target2 = GameObject.Find ("MidpointA");
			}
			else if (targetNum == 4) {
				target2 = GameObject.Find ("MidpointB");
			}
			else if (targetNum == 6) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 8) {
				target2 = GameObject.Find ("MidpointD");
			}
			else if (targetNum == 10) {
				target2 = GameObject.Find ("MidpointE");
			}
			break;
		case 6:
			if (targetNum == 1) {
				target2 = GameObject.Find ("Midpoint1");
			}
			else if (targetNum == 3) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 5) {
				target2 = GameObject.Find ("Midpoint3");
			}
			else if (targetNum == 7) {
				target2 = GameObject.Find ("Midpoint4");
			}
			else if (targetNum == 9) {
				target2 = GameObject.Find ("Midpoint5");
			}
			break;
		case 7:
			if (targetNum == 2) {
				target2 = GameObject.Find ("MidpointB");
			}
			else if (targetNum == 4) {
				target2 = GameObject.Find ("MidpointB");
			}
			else if (targetNum == 6) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 8) {
				target2 = GameObject.Find ("MidpointD");
			}
			else if (targetNum == 10) {
				target2 = GameObject.Find ("MidpointE");
			}
			break;
		case 8:
			if (targetNum == 1) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 3) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 5) {
				target2 = GameObject.Find ("Midpoint3");
			}
			else if (targetNum == 7) {
				target2 = GameObject.Find ("Midpoint4");
			}
			else if (targetNum == 9) {
				target2 = GameObject.Find ("Midpoint5");
			}
			break;
		case 9:
			if (targetNum == 2) {
				target2 = GameObject.Find ("MidpointB");
			}
			else if (targetNum == 4) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 6) {
				target2 = GameObject.Find ("MidpointC");
			}
			else if (targetNum == 8) {
				target2 = GameObject.Find ("MidpointD");
			}
			else if (targetNum == 10) {
				target2 = GameObject.Find ("MidpointE");
			}
			break;
		case 10:
			if (targetNum == 1) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 3) {
				target2 = GameObject.Find ("Midpoint2");
			}
			else if (targetNum == 5) {
				target2 = GameObject.Find ("Midpoint3");
			}
			else if (targetNum == 7) {
				target2 = GameObject.Find ("Midpoint4");
			}
			else if (targetNum == 9) {
				target2 = GameObject.Find ("Midpoint5");
			}
			break;
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
		/*try{
			if (check1) {
				/*Quaternion rotate = Quaternion.LookRotation (target1.transform.position - customer.position);
				customer.rotation = Quaternion.Slerp (customer.rotation, rotate, Time.deltaTime*speed);*
				//transform.LookAt(target1.transform.position);
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
				//transform.LookAt(target2.transform.position);
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
		}catch(MissingReferenceException){
			CorrectCourse();
		}*/
		try{
			if (check1) {
				/*Quaternion rotate = Quaternion.LookRotation (target1.transform.position - customer.position);
				customer.rotation = Quaternion.Slerp (customer.rotation, rotate, Time.deltaTime*speed);*/
				//transform.LookAt(target1.transform.position);
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
				//transform.LookAt(target2.transform.position);
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
		}catch(MissingReferenceException){
			CorrectCourse();
		}
		if (check3) {
			//transform.LookAt(target3.transform.position);
			Vector3 direction = (target3.transform.position - transform.position).normalized;
			float distance = (target3.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			if(distance < 1f){
				die = true;
			}
		}

		/*Quaternion rotate = Quaternion.LookRotation (target1.transform.position - customer.position);
		customer.rotation = Quaternion.Slerp (customer.rotation, rotate, Time.deltaTime*speed);*/

		if (die) {
			Destroy (gameObject);
		}
	}

	//Determines path for the the customer if they spawn at Empty1
	void spawn1(){
		switch (targetNum){
		case 2:
			target1 = GameObject.Find ("Midpoint1");
			target2 = GameObject.Find ("MidpointA");
			target3 = GameObject.Find ("Empty2");
			checkers = true;
			break;
		case 4:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointB");
			target3 = GameObject.Find ("Empty4");
			checkers = true;
			break;
		case 6:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty6");
			checkers = true;
			break;
		case 8:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty8");
			checkers = true;
			break;
		case 10:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointD");
			target3 = GameObject.Find ("Empty10");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty2
	void spawn2(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("MidpointA");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty1");
			checkers = true;
			break;
		case 3:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty3");
			checkers = true;
			break;
		case 5:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty5");
			checkers = true;
			break;
		case 7:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty7");
			checkers = true;
			break;
		case 9:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty9");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty3
	void spawn3(){
		switch (targetNum){
		case 2:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointA");
			target3 = GameObject.Find ("Empty2");
			checkers = true;
			break;
		case 4:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointB");
			target3 = GameObject.Find ("Empty4");
			checkers = true;
			break;
		case 6:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty6");
			checkers = true;
			break;
		case 8:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointD");
			target3 = GameObject.Find ("Empty8");
			checkers = true;
			break;
		case 10:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointD");
			target3 = GameObject.Find ("Empty10");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty4
	void spawn4(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty1");
			checkers = true;
			break;
		case 3:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty3");
			checkers = true;
			break;
		case 5:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty5");
			checkers = true;
			break;
		case 7:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty7");
			checkers = true;
			break;
		case 9:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty9");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty5
	void spawn5(){
		switch (targetNum){
		case 2:
			target1 = GameObject.Find ("Midpoint2");
			target2 = GameObject.Find ("MidpointA");
			target3 = GameObject.Find ("Empty2");
			checkers = true;
			break;
		case 4:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointB");
			target3 = GameObject.Find ("Empty4");
			checkers = true;
			break;
		case 6:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty6");
			checkers = true;
			break;
		case 8:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointD");
			target3 = GameObject.Find ("Empty8");
			checkers = true;
			break;
		case 10:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty10");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty6
	void spawn6(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty1");
			checkers = true;
			break;
		case 3:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty3");
			checkers = true;
			break;
		case 5:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty5");
			checkers = true;
			break;
		case 7:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty7");
			checkers = true;
			break;
		case 9:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint5");
			target3 = GameObject.Find ("Empty9");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty7
	void spawn7(){
		switch (targetNum){
		case 2:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointB");
			target3 = GameObject.Find ("Empty2");
			checkers = true;
			break;
		case 4:
			target1 = GameObject.Find ("Midpoint3");
			target2 = GameObject.Find ("MidpointB");
			target3 = GameObject.Find ("Empty4");
			checkers = true;
			break;
		case 6:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty6");
			checkers = true;
			break;
		case 8:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointD");
			target3 = GameObject.Find ("Empty8");
			checkers = true;
			break;
		case 10:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty10");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty8
	void spawn8(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty1");
			checkers = true;
			break;
		case 3:
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty3");
			checkers = true;
			break;
		case 5:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty5");
			checkers = true;
			break;
		case 7:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty7");
			checkers = true;
			break;
		case 9:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint5");
			target3 = GameObject.Find ("Empty9");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty9
	void spawn9(){
		switch (targetNum){
		case 2:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointB");
			target3 = GameObject.Find ("Empty2");
			checkers = true;
			break;
		case 4:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty4");
			checkers = true;
			break;
		case 6:
			target1 = GameObject.Find ("Midpoint4");
			target2 = GameObject.Find ("MidpointC");
			target3 = GameObject.Find ("Empty6");
			checkers = true;
			break;
		case 8:
			target1 = GameObject.Find ("Midpoint5");
			target2 = GameObject.Find ("MidpointD");
			target3 = GameObject.Find ("Empty8");
			checkers = true;
			break;
		case 10:
			target1 = GameObject.Find ("Midpoint5");
			target2 = GameObject.Find ("MidpointE");
			target3 = GameObject.Find ("Empty10");
			checkers = true;
			break;
		}
	}

	//Determines path for the the customer if they spawn at Empty10
	void spawn10(){
		switch (targetNum){
		case 1:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty1");
			checkers = true;
			break;
		case 3:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty3");
			checkers = true;
			break;
		case 5:
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty5");
			checkers = true;
			break;
		case 7:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty7");
			checkers = true;
			break;
		case 9:
			target1 = GameObject.Find ("MidpointE");
			target2 = GameObject.Find ("Midpoint5");
			target3 = GameObject.Find ("Empty9");
			checkers = true;
			break;
		}
	}
}
