using UnityEngine;
using System.Collections;

public class Mascot : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public bool die;
	public int targetNum;
	public int attract;
	public GameObject target;
	public float speed = 0.05f;
	
	// Use this for initialization
	void Start () {
		Decide ();
	}

	GameObject Decide(){
		//Sets Mascot's destination
		targetNum = Random.Range (1, 10);
		
		//Sets path to the specific Empty
		if (targetNum == 1) {
			target = GameObject.Find ("Midpoint1");
		}
		else if (targetNum == 2) {
			target = GameObject.Find ("MidpointA");
		}
		else if (targetNum == 3) {
			target = GameObject.Find ("Midpoint2");
		}
		else if (targetNum == 4) {
			target = GameObject.Find ("MidpointB");
		}
		else if (targetNum == 5) {
			target = GameObject.Find ("Midpoint3");
		}
		else if (targetNum == 6) {
			target = GameObject.Find ("MidpointC");
		}
		else if (targetNum == 7) {
			target = GameObject.Find ("Midpoint4");
		}
		else if (targetNum == 8) {
			target = GameObject.Find ("MidpointD");
		}
		else if (targetNum == 9) {
			target = GameObject.Find ("Midpoint5");
		}
		else if (targetNum == 10) {
			target = GameObject.Find ("MidpointE");
		}

		return target;
	}

	// Update is called once per frame
	void Update () {
		//The customer moves towards the target and they're destroyed when they reach the target
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;

		if (distance < 1f) {
			Decide ();
		}

		if (attract >= 10) {
			gameObject.tag = "Mascot";
			StartCoroutine(mascotTime());
		}
		
		if (distance < 1f) {
			Decide ();
		}
	}

	IEnumerator mascotTime(){
		yield return new WaitForSeconds (10);
		gameObject.tag = "Untagged";
		attract = 0;
	}
	
	IEnumerator shrinkTime(){
		yield return new WaitForSeconds (1);
		transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
	}

	//if hit by food
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
			StartCoroutine(shrinkTime());
			if(attract <= 10){
				attract += 1;
			}
		}
	}
}
