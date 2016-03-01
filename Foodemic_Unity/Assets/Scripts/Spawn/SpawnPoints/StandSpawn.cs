using UnityEngine;
using System.Collections;

public class StandSpawn : MonoBehaviour {
	//Sets up an ID for each individual spawn, information based on the array, where the food stand spawns from, and the foodstand object
	public int spawnID;
	public int spawnPoint;
	public Transform node;
	public GameObject stand;
	
	// Use this for initialization
	void Start () {
		//Array holds spawn times
		int[] ID = {2,3,4,4,5};

		//For loop randomizes the contents of the array
		for (int i = 0; i < ID.Length; i++) {
			int temp = ID[i];
			int randomIndex = Random.Range(i, ID.Length);
			ID[i] = ID[randomIndex];
			ID[randomIndex] = temp;
		}

		//Each spawn point will get a value based on the contents of the array at the spawn's ID number
		spawnPoint = ID [spawnID-1];
	}
	
	// Update is called once per frame
	void Update () {
		//Each spawn point spawns a food stand depending on when the order they get from array
		if (spawnID == 1) {
			if(Time.fixedTime % (10 * spawnPoint) == 0 && Time.fixedTime != 0){
				Instantiate(stand,node.transform.position,node.transform.rotation);
			}
		}
		else if (spawnID == 2) {
			if(Time.fixedTime % (10 * spawnPoint) == 0 && Time.fixedTime != 0){
				Instantiate(stand,node.transform.position,node.transform.rotation);
			}
		}
		else if (spawnID == 3) {
			if(Time.fixedTime % (10 * spawnPoint) == 0 && Time.fixedTime != 0){
				Instantiate(stand,node.transform.position,node.transform.rotation);
			}
		}
		else if (spawnID == 4) {
			if(Time.fixedTime % (10 * spawnPoint) == 0 && Time.fixedTime != 0){
				Instantiate(stand,node.transform.position,node.transform.rotation);
			}
		}
		else if (spawnID == 5) {
			if(Time.fixedTime % (10 * spawnPoint) == 0 && Time.fixedTime != 0){
				Instantiate(stand,node.transform.position,node.transform.rotation);
			}
		}
	}
}
