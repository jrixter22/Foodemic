using UnityEngine;
using System.Collections;

public class tree : MonoBehaviour {
	//Sets up the arrays for spawn points, what they'll spawn, detecting how much the tree is hit, 
	//and how many times it can get it
	public Transform[] node;
	public GameObject[] drop;
	public int hit;
	public int hitpoints;

	// Use this for initialization
	void Start () {
		//Sorts the GameObject and spawn arrays and initializes a maximum number of hitpoints 
		sortArray ();
		hitpoints = Random.Range (1, 5);
	}
	
	// Update is called once per frame
	void Update () {
		//Spawns object once hit enough by the player
		if (hit >= hitpoints) {
			Instantiate(drop[0], node[0].transform.position, node[0].transform.rotation);
			sortArray();
			hitpoints = Random.Range (1, 5);
			hit = 0;
		}
	}

	void sortArray(){
		//For loop randomizes the contents of the node array
		for (int i = 0; i < node.Length; i++) {
			Transform temp = node[i];
			int randomIndex = Random.Range(i, node.Length);
			node[i] = node[randomIndex];
			node[randomIndex] = temp;
		}
		
		//For loop randomizes the contents of the drop array
		for (int i = 0; i < drop.Length; i++) {
			GameObject temp = drop[i];
			int randomIndex = Random.Range(i, drop.Length);
			drop[i] = drop[randomIndex];
			drop[randomIndex] = temp;
		}
	}

	//Detects when the tree was hit by food
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			hit += 1;
		}
	}
}
