using UnityEngine;
using System.Collections;

public class BillboardSpawn : MonoBehaviour {
	//Sets up what is spawned, where the object is the spawned, where the spawn point is moving, and how fast its traveling
	public GameObject billboard;
	public GameObject target;
	public int[] ID;
	public int spawnPoint;
	public int targetNum = 1;
	public Transform node;
	public float minSpeed = 0.05f;
	public float maxSpeed = 0.09f;
	public float speed = 1f;
	
	// Use this for initialization
	void Start () {
		/*speed = Random.Range (minSpeed, maxSpeed);
		Decide ();*/
		//Array holds spawn point locations
		//int[] ID = {1,2,3};
		
		//For loop randomizes the contents of the array
		for (int i = 0; i < ID.Length; i++) {
			int temp = ID[i];
			int randomIndex = Random.Range(i, ID.Length);
			ID[i] = ID[randomIndex];
			ID[randomIndex] = temp;
		}
		
		//assigns starting location of the billboard
		if (ID [spawnPoint] == 1) {
			target = GameObject.Find ("Post3");
			//spawnPoint += 1;
		} else if (ID [spawnPoint] == 2) {
			target = GameObject.Find ("Post4");
			//spawnPoint += 1;
		} else {
			target = GameObject.Find ("Post5");
			//spawnPoint += 1;
		}
	}
	
	void Decide(){
		//Sets path to the specific Empty
		if (targetNum == 1) {
			target = GameObject.Find ("Post3");
			targetNum = 2;
		}
		else if (targetNum == 2) {
			target = GameObject.Find ("Post5");
			targetNum = 1;
		}
		
		//return target;
	}
	
	void Change(){
		//assigns next location of the billboard
		if (ID [spawnPoint] == 1) {
			target = GameObject.Find ("Post3");
			spawnPoint += 1;
		} else if (ID [spawnPoint] == 2) {
			target = GameObject.Find ("Post4");
			spawnPoint += 1;
		} else {
			target = GameObject.Find ("Post5");
			spawnPoint += 1;
		}
		speed = 1f;
		
		//resets the spawnpoint
		if (spawnPoint > 2) {
			spawnPoint = 0;
			//For loop randomizes the contents of the array
			for (int i = 0; i < ID.Length; i++) {
				int temp = ID[i];
				int randomIndex = Random.Range(i, ID.Length);
				ID[i] = ID[randomIndex];
				ID[randomIndex] = temp;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		//spawns billboard every 20 seconds
		if ( Time.fixedTime % 5 == 0 && Time.fixedTime != 0) {
			Instantiate(billboard,node.transform.position,node.transform.rotation);
			Change();
		}
		
		//The spawn point moves toward target
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		
		//spawn point changes target
		if (distance < 1f) {
			speed = 0f;
			//Decide ();
		}
	}
}
