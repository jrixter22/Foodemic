using UnityEngine;
using System.Collections;

public class BillboardSpawn : MonoBehaviour {
	//Sets up what is spawned, where the object is the spawned, where the spawn point is moving, and how fast its traveling
	public GameObject billboard;
	public GameObject target;
	public int targetNum = 1;
	public Transform node;
	public float minSpeed = 0.05f;
	public float maxSpeed = 0.09f;
	public float speed;
	
	// Use this for initialization
	void Start () {
		speed = Random.Range (minSpeed, maxSpeed);
		Decide ();
	}

	void Decide(){
		//Sets path to the specific Empty
		if (targetNum == 1) {
			target = GameObject.Find ("Post3");
			targetNum = 2;
		}
		else if (targetNum == 2) {
			target = GameObject.Find ("Post4");
			targetNum = 1;
		}
		
		//return target;
	}
	
	// Update is called once per frame
	void Update () {
		//spawns billboard every 20 seconds
		if ( Time.fixedTime % 15 == 0 && Time.fixedTime != 0) {
			Instantiate(billboard,node.transform.position,node.transform.rotation);
		}

		//The spawn point moves toward target
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;

		//spawn point changes target
		if (distance < 1f) {
			Decide ();
		}
	}
}
