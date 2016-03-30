using UnityEngine;
using System.Collections;

public class StandSpawn2 : MonoBehaviour {
	//Initializes variables for the stand being spawned, the node it's being spawned from, where the spawner's target,
	//an ID array, a spawnpoint variable to keep track of where to spawn, and how fast the spawner moves
	public GameObject stand;
	public GameObject target;
	public Transform node;
	public int[] ID;
	public int spawnpoint;
	public float standtimer;
	public float speed = 2f;

	// Use this for initialization
	void Start () {
		//For loop randomizes the contents of the array
		for (int i = 0; i < ID.Length; i++) {
			int temp = ID[i];
			int randomIndex = Random.Range(i, ID.Length);
			ID[i] = ID[randomIndex];
			ID[randomIndex] = temp;
		}
		
		//assigns spawn location for the stand
		if (ID [spawnpoint] == 1) {
			target = GameObject.Find ("Stand");
		} else if (ID [spawnpoint] == 2) {
			target = GameObject.Find ("Stand2");
		} else if (ID [spawnpoint] == 3) {
			target = GameObject.Find ("Stand3");
		} else if (ID [spawnpoint] == 4) {
			target = GameObject.Find ("Stand4");
		} else if (ID [spawnpoint] == 5) {
			target = GameObject.Find ("Stand5");
		} else if (ID [spawnpoint] == 6) {
			target = GameObject.Find ("Stand6");
		} else if (ID [spawnpoint] == 7) {
			target = GameObject.Find ("Stand7");
		} else if (ID [spawnpoint] == 8) {
			target = GameObject.Find ("Stand8");
		} else if (ID [spawnpoint] == 9) {
			target = GameObject.Find ("Stand9");
		} else if (ID [spawnpoint] == 10) {
			target = GameObject.Find ("Stand10");
		} else if (ID [spawnpoint] == 11) {
			target = GameObject.Find ("Stand11");
		} else if (ID [spawnpoint] == 12) {
			target = GameObject.Find ("Stand12");
		} else if (ID [spawnpoint] == 13) {
			target = GameObject.Find ("Stand13");
		} else if (ID [spawnpoint] == 14) {
			target = GameObject.Find ("Stand14");
		} else {
			target = GameObject.Find ("Stand15");
		}
		spawnpoint += 1;

		standtimer = 0;
	}

	void Change(){
		//assigns next location of the stand
		if (ID [spawnpoint] == 1) {
			target = GameObject.Find ("Stand");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 2) {
			target = GameObject.Find ("Stand2");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 3) {
			target = GameObject.Find ("Stand3");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 4) {
			target = GameObject.Find ("Stand4");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 5) {
			target = GameObject.Find ("Stand5");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 6) {
			target = GameObject.Find ("Stand6");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 7) {
			target = GameObject.Find ("Stand7");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 8) {
			target = GameObject.Find ("Stand8");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 9) {
			target = GameObject.Find ("Stand9");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 10) {
			target = GameObject.Find ("Stand10");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 11) {
			target = GameObject.Find ("Stand11");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 12) {
			target = GameObject.Find ("Stand12");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 13) {
			target = GameObject.Find ("Stand13");
			spawnpoint += 1;
		} else if (ID [spawnpoint] == 14) {
			target = GameObject.Find ("Stand14");
			spawnpoint += 1;
		} else {
			target = GameObject.Find ("Stand15");
			spawnpoint += 1;
		}
		speed = 2f;
		
		//resets the spawnpoint
		if (spawnpoint > 15) {
			spawnpoint = 0;
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
		//spawns stand every 20 seconds
		if (standtimer >= 9.9f /*Time.fixedTime % 10 == 0 && Time.fixedTime != 0*/) {
			Instantiate(stand,node.transform.position,node.transform.rotation);
			Change();
			standtimer = 0;
		}

		standtimer += Time.deltaTime;
		
		//The spawn point moves toward target
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		
		//spawn point changes target
		if (distance < 1f) {
			speed = 0f;
		}
	}
}
