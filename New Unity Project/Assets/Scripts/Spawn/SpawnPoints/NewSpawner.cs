using UnityEngine;
using System.Collections;

public class NewSpawner : MonoBehaviour {
	public Transform[] node;
	public GameObject[] customer;
	public GameObject maxCustomer;
	public GameObject lucyCustomer;
	public GameObject cindiCustomer;
	public GameObject tourist;
	public GameObject businessman;
	public float spawnTimer;
	public float totalTime;
	public float addCustomerTime = 15f;

	// Use this for initialization
	void Start () {
		//For loop randomizes the contents of the array
		/*for (int i = 0; i < node.Length; i++) {
			Transform temp = node[i];
			int randomIndex = Random.Range(i, node.Length);
			node[i] = node[randomIndex];
			node[randomIndex] = temp;
		}*/
		sortArray ();

		//Starts the timers at 0
		spawnTimer = 0f;
		totalTime = 0f;

		//Spawn at the beginning
		Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
		Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
		Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
		Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
		Instantiate (customer[4], node [4].transform.position, node [4].transform.rotation);
		Instantiate (businessman, node [5].transform.position, node [5].transform.rotation);
	}

	void sortArray(){
		//For loop randomizes the contents of the node array
		for (int i = 0; i < node.Length; i++) {
			Transform temp = node[i];
			int randomIndex = Random.Range(i, node.Length);
			node[i] = node[randomIndex];
			node[randomIndex] = temp;
		}

		//For loop randomizes the contents of the customer array
		for (int i = 0; i < customer.Length; i++) {
			GameObject temp = customer[i];
			int randomIndex = Random.Range(i, customer.Length);
			customer[i] = customer[randomIndex];
			customer[randomIndex] = temp;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Sets the time variables
		spawnTimer += Time.deltaTime;
		totalTime += Time.deltaTime;

		//Spawns a customer around every 3 seconds and increases the number every 15 seconds
		/*if(spawnTimer >= 2.99){
			Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
			Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
			Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
			Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
			Instantiate (businessman, node [4].transform.position, node [4].transform.rotation);
			if(totalTime >= addCustomerTime){
				Instantiate (customer[5], node [5].transform.position, node [5].transform.rotation);
				if(totalTime >= addCustomerTime*2){
					Instantiate (customer[6], node [6].transform.position, node [6].transform.rotation);
					if(totalTime >= addCustomerTime*3){
						Instantiate (customer[7], node [7].transform.position, node [7].transform.rotation);
						if(totalTime >= addCustomerTime*4){
							Instantiate (businessman, node [8].transform.position, node [8].transform.rotation);
							if(totalTime >= addCustomerTime*5){
								Instantiate (customer[9], node [9].transform.position, node [9].transform.rotation);
								spawnTimer = 0f;
							}
						}
					}
				}
			}
			//Reset spawnTimer and resort arrays
			spawnTimer = 0f;
			sortArray();
		}*/
		if (totalTime < 15f) {
			if(spawnTimer >= 2.99){
				Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
				Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
				Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
				Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
				Instantiate (businessman, node [4].transform.position, node [4].transform.rotation);
				//Reset spawnTimer and resort arrays
				spawnTimer = 0f;
				sortArray();
			}
		} else if (totalTime >= 15f && totalTime < 30f) {
			if(spawnTimer >= 2.99){
				Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
				Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
				Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
				Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
				Instantiate (customer[4], node [4].transform.position, node [4].transform.rotation);
				Instantiate (businessman, node [5].transform.position, node [5].transform.rotation);
				//Reset spawnTimer and resort arrays
				spawnTimer = 0f;
				sortArray();
			}
		} else if (totalTime >= 30f && totalTime < 45f) {
			if(spawnTimer >= 2.99){
				Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
				Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
				Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
				Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
				Instantiate (customer[4], node [4].transform.position, node [4].transform.rotation);
				Instantiate (customer[5], node [5].transform.position, node [5].transform.rotation);
				Instantiate (businessman, node [6].transform.position, node [6].transform.rotation);
				//Reset spawnTimer and resort arrays
				spawnTimer = 0f;
				sortArray();
			}
		} else if (totalTime >= 45f && totalTime < 60f) {
			if(spawnTimer >= 2.99){
				Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
				Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
				Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
				Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
				Instantiate (customer[4], node [4].transform.position, node [4].transform.rotation);
				Instantiate (customer[5], node [5].transform.position, node [5].transform.rotation);
				Instantiate (customer[6], node [6].transform.position, node [6].transform.rotation);
				Instantiate (businessman, node [7].transform.position, node [7].transform.rotation);
				//Reset spawnTimer and resort arrays
				spawnTimer = 0f;
				sortArray();
			}
		} else if (totalTime >= 60f && totalTime < 75f) {
			if(spawnTimer >= 2.99){
				Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
				Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
				Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
				Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
				Instantiate (customer[4], node [4].transform.position, node [4].transform.rotation);
				Instantiate (customer[5], node [5].transform.position, node [5].transform.rotation);
				Instantiate (customer[6], node [6].transform.position, node [6].transform.rotation);
				Instantiate (businessman, node [7].transform.position, node [7].transform.rotation);
				Instantiate (businessman, node [8].transform.position, node [8].transform.rotation);
				//Reset spawnTimer and resort arrays
				spawnTimer = 0f;
				sortArray();
			}
		} else {
			if(spawnTimer >= 2.99){
				Instantiate (customer[0], node [0].transform.position, node [0].transform.rotation);
				Instantiate (customer[1], node [1].transform.position, node [1].transform.rotation);
				Instantiate (customer[2], node [2].transform.position, node [2].transform.rotation);
				Instantiate (customer[3], node [3].transform.position, node [3].transform.rotation);
				Instantiate (customer[4], node [4].transform.position, node [4].transform.rotation);
				Instantiate (customer[5], node [5].transform.position, node [5].transform.rotation);
				Instantiate (customer[6], node [6].transform.position, node [6].transform.rotation);
				Instantiate (customer[7], node [7].transform.position, node [7].transform.rotation);
				Instantiate (businessman, node [8].transform.position, node [8].transform.rotation);
				Instantiate (businessman, node [9].transform.position, node [9].transform.rotation);
				//Reset spawnTimer and resort arrays
				spawnTimer = 0f;
				sortArray();
			}
		}
	}
}
