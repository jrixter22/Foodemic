using UnityEngine;
using System.Collections;

public class FoodStand : MonoBehaviour {
	//Sets up variables to determine if the stand is destroyed, where the stand is going, and how fast its going
	public bool die;
	public GameObject target;
	public float speed = 0.2f;
	public float startZ;

	// Use this for initialization
	void Start () {
		startZ = gameObject.transform.position.z;
		if (gameObject.transform.position.x < -2) {
			if (gameObject.transform.position.z < -1) {
				target = GameObject.Find ("Target1");
			} else if (gameObject.transform.position.z > -1 && gameObject.transform.position.z < 4) {
				target = GameObject.Find ("Target2");
			} else if (gameObject.transform.position.z > 4 && gameObject.transform.position.z < 8) {
				target = GameObject.Find ("Target3");
			} else if (gameObject.transform.position.z > 8 && gameObject.transform.position.z < 12) {
				target = GameObject.Find ("Target4");
			} else {
				target = GameObject.Find ("Target5");
			}
		} else if (gameObject.transform.position.x >= -2 && gameObject.transform.position.x < 2) {
			if (gameObject.transform.position.z < -1) {
				target = GameObject.Find ("Target6");
			} else if (gameObject.transform.position.z > -1 && gameObject.transform.position.z < 4) {
				target = GameObject.Find ("Target7");
			} else if (gameObject.transform.position.z > 4 && gameObject.transform.position.z < 8) {
				target = GameObject.Find ("Target8");
			} else if (gameObject.transform.position.z > 8 && gameObject.transform.position.z < 12) {
				target = GameObject.Find ("Target9");
			} else {
				target = GameObject.Find ("Target10");
			}
		} else if (gameObject.transform.position.x >= 2) {
			if (gameObject.transform.position.z < -1) {
				target = GameObject.Find ("Target11");
			} else if (gameObject.transform.position.z > -1 && gameObject.transform.position.z < 4) {
				target = GameObject.Find ("Target12");
			} else if (gameObject.transform.position.z > 4 && gameObject.transform.position.z < 8) {
				target = GameObject.Find ("Target13");
			} else if (gameObject.transform.position.z > 8 && gameObject.transform.position.z < 12) {
				target = GameObject.Find ("Target14");
			} else {
				target = GameObject.Find ("Target15");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		//The stand moves up from the ground
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;

		if (distance < 0.1f) {
			speed = 0;
		}

		if (die) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Bullet") {
			die = true;
		} 
	}
}
