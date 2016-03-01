using UnityEngine;
using System.Collections;

public class FoodStand1 : MonoBehaviour {
	//Sets up variables to determine if the stand is destroyed, where the stand is going, 
	//where the stand spawned, and how fast its going
	public bool die;
	public int spawnPoint = 0;
	public GameObject target;
	public GameObject spawn;
	public float speed = 0.2f;

	// Use this for initialization
	void Start () {
		/*//Figure out where the stand spawned
		FindSpawn ();

		//Based on stands spawn, figure out where its target is
		if (spawnPoint == 1) {
			target = GameObject.Find ("Target1");
		} else if (spawnPoint == 2) {
			target = GameObject.Find ("Target2");
		} else if (spawnPoint == 3) {
			target = GameObject.Find ("Target3");
		} else if (spawnPoint == 4) {
			target = GameObject.Find ("Target4");
		} else if (spawnPoint == 5) {
			target = GameObject.Find ("Target5");
		} */
		target = GameObject.Find ("Target1");
	}

	/*int FindSpawn(){
		spawn = GameObject.Find ("Stand1");
		float distance = (spawn.transform.position - transform.position).magnitude;
		if (distance < 1f && spawnPoint == 0) {
			spawnPoint = 1;
		}
		spawn = GameObject.Find ("Stand2");
		float distance2 = (spawn.transform.position - transform.position).magnitude;
		if (distance2 < 1f && spawnPoint == 0) {
			spawnPoint = 2;
		}
		spawn = GameObject.Find ("Stand3");
		float distance3 = (spawn.transform.position - transform.position).magnitude;
		if (distance3 < 1f && spawnPoint == 0) {
			spawnPoint = 3;
		}
		spawn = GameObject.Find ("Stand4");
		float distance4 = (spawn.transform.position - transform.position).magnitude;
		if (distance4 < 1f && spawnPoint == 0) {
			spawnPoint = 4;
		}
		spawn = GameObject.Find ("Stand5");
		float distance5 = (spawn.transform.position - transform.position).magnitude;
		if (distance5 < 1f && spawnPoint == 0) {
			spawnPoint = 5;
		}
	}*/

	// Update is called once per frame
	void Update () {
		//The stand moves up from the ground
		Vector3 direction = (target.transform.position - transform.position).normalized;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;

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
