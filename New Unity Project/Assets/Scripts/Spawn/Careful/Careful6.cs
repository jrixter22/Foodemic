using UnityEngine;
using System.Collections;

public class Careful6 : MonoBehaviour {
	/*Sets up variables to determine where the customer is heading, at what checkpoint it is at,
	 if the customer should be destroyed, if the customer is hungry, and its speed*/
	public bool check1 = true;
	public bool check2 = false;
	public bool check3 = false;
	public bool hungry = true;
	public bool die;
	public int targetNum;
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	public float speed = 0.075f;
	
	// Use this for initialization
	void Start () {
		//Sets person's final destination
		targetNum = RandomOdd ();
		
		//Sets path of the person
		if (targetNum == 1) {
			target1 = GameObject.Find ("MidpointB");
			target2 = GameObject.Find ("Midpoint1");
			target3 = GameObject.Find ("Empty1");
		}
		else if (targetNum == 3) {
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint2");
			target3 = GameObject.Find ("Empty3");
		}
		else if (targetNum == 5) {
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint3");
			target3 = GameObject.Find ("Empty5");
		}
		else if (targetNum == 7) {
			target1 = GameObject.Find ("MidpointC");
			target2 = GameObject.Find ("Midpoint4");
			target3 = GameObject.Find ("Empty7");
		}
		else if (targetNum == 9) {
			target1 = GameObject.Find ("MidpointD");
			target2 = GameObject.Find ("Midpoint5");
			target3 = GameObject.Find ("Empty9");
		}
	}
	
	int RandomOdd()
	{
		//Generates a random even number
		int randint = Random.Range (1, 10);
		while(randint % 2 != 1) {
			randint = Random.Range (1, 10);
		} 
		return randint;
	}
	
	void CorrectCourse()
	{
		//returns the customer on their path when the stand is destroyed
		if (targetNum == 1) {
			target2 = GameObject.Find ("Midpoint1");
			speed = 0.075f;
		}
		else if (targetNum == 3) {
			target2 = GameObject.Find ("Midpoint2");
			speed = 0.075f;
		}
		else if (targetNum == 5) {
			target2 = GameObject.Find ("Midpoint3");
			speed = 0.075f;
		}
		else if (targetNum == 7) {
			target2 = GameObject.Find ("Midpoint4");
			speed = 0.075f;
		}
		else if (targetNum == 9) {
			target2 = GameObject.Find ("Midpoint5");
			speed = 0.075f;
		}
	}
	
	void FindStand()
	{
		//Use the foodstand array to find the food stands
		GameObject temp = GameObject.FindGameObjectWithTag ("Stand");
		if (temp != null) {
			target2 = temp;
			speed = 0.125f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//The customer moves towards the target and they're destroyed when they reach the target
		//Resets the direction, distance, and move variables when the customer reaches each checkpoint
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
}
