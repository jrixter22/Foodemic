using UnityEngine;
using System.Collections;

public class Eco : MonoBehaviour {
	/*Sets up variables to keep track of number of customers, 
	if they reached their target, what their target is, and how fast they are*/
	public static int numCustomers;
	public int protesters;
	public bool die;
	public bool multiJump;
	public int targetNum = 1;
	public int hitpoints;
	public int spawn;
	public GameObject target;
	public GameObject eco;
	public Transform node;
	//public float speed = 0.075f;
	public float speed /*= Random.Range(0.05f, 0.15f)*/;
	public float jumpforce;
	public float jumpzone /*= Random.Range(10f, 30f)*/;
	public float jumpzone2;
	public float jumpdist;
	//public float jumpdist2;
	public float ypos;
	public float jump;
	public float timer;
	
	// Use this for initialization
	void Start () {
		//Decides where to go
		Decide ();
		jumpforce = 50f;
		protesters = 1;
		//jump = jumpforce * speed;
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
		
		//Randomly sets the speed and jump location
		speed = Random.Range(0.05f, 0.15f);
		jumpzone = Random.Range (10f, 30f);
		
		//Sets up a 2nd jump zone if the 1st is to close to any post
		if (jumpzone <= 13f) {
			jumpzone2 = Random.Range (25f, 30f);
			multiJump = true;
		} else if (jumpzone >= 27f) {
			jumpzone2 = Random.Range (10f, 15f);
			multiJump = true;
		} else {
			multiJump = false;
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
		
		//Sets the values for how high and far the protester jumps
		jump = jumpforce * speed;
		jumpdist = jump / 3/*jumpzone * speed*/;
		//jumpdist2 = jump / 3/*jumpzone2 * speed*/;
		
		//Makes the protester jump once they are a certain distance from their target
		if (distance <= jumpzone) {
			transform.Translate(0, Time.deltaTime * jump, 0);
			if (distance <= jumpzone-jumpdist) {
				transform.Translate(0, -Time.deltaTime * jump * 2, 0);
				if (distance <= jumpzone-(2*jumpdist)) {
					transform.Translate(0, Time.deltaTime * jump, 0);
				}
			}
		}
		
		//Makes the protester jump again if they're jumping multiple times
		if (multiJump) {
			if (distance <= jumpzone2) {
				transform.Translate(0, Time.deltaTime * jump, 0);
				if (distance <= jumpzone2-jumpdist) {
					transform.Translate(0, -Time.deltaTime * jump * 2, 0);
					if (distance <= jumpzone2-(2*jumpdist)) {
						transform.Translate(0, Time.deltaTime * jump, 0);
					}
				}
			}
		}
		
		//after being hit 3 or more times, it will spawn an additional protestor
		if (hitpoints >= 3 && numCustomers < 5/*protesters*/) {
			timer += Time.deltaTime;
			if(timer <= 0.02f){
				spawn += 1;
				Instantiate(eco,node.transform.position,node.transform.rotation);
				numCustomers += 1;
				timer = 0f;
			}
			/*protesters += 1;
			if(protesters > 5){
				protesters = 5;
			}*/
			hitpoints = 0;
		}
		
		//Keeps track off how high in the air the environmentalist is
		ypos = gameObject.transform.position.y;
		
		//Performs decide function when it gets cloase to its target
		if (distance < 1f) {
			Decide ();
		}
	}
	
	//keeps track of how many times the environmentalist gets hit
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Bullet") {
			hitpoints += 1;
		}
	}
}
