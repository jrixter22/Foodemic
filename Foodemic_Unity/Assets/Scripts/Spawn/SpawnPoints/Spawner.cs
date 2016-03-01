using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	//Sets up the ID number of the individual spawner, arrays for the different customers, and an for the customer spawn location
	public int SpawnID;
	public GameObject[] Business;
	public GameObject[] Tourist;
	public GameObject[] Careful;
	public Transform[] node;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Generate random number to randomly select an AI and instantiate AI based on spawnID
		int randint = Random.Range (1, 30);
		if (Time.fixedTime % 5 == 0) {
			if(SpawnID == 1){
				if(randint >= 1 && randint <= 17){
					Instantiate(Careful[0],node[0].transform.position,node[0].transform.rotation);
				}
				else if(randint >= 18 && randint <= 19){
					Instantiate(Business[0],node[0].transform.position,node[0].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[0],node[0].transform.position,node[0].transform.rotation);
				}
			}
			else if(SpawnID == 2){
				if(randint >= 1 && randint <= 16){
					Instantiate(Careful[1],node[1].transform.position,node[1].transform.rotation);
				}
				else if(randint >= 17 && randint <= 19){
					Instantiate(Business[1],node[1].transform.position,node[1].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[1],node[1].transform.position,node[1].transform.rotation);
				}
			}
			else if(SpawnID == 3){
				if(randint >= 1 && randint <= 15){
					Instantiate(Careful[2],node[2].transform.position,node[2].transform.rotation);
				}
				else if(randint >= 16 && randint <= 19){
					Instantiate(Business[0],node[2].transform.position,node[2].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[0],node[2].transform.position,node[2].transform.rotation);
				}
			}
			else if(SpawnID == 4){
				if(randint >= 1 && randint <= 14){
					Instantiate(Careful[3],node[3].transform.position,node[3].transform.rotation);
				}
				else if(randint >= 15 && randint <= 19){
					Instantiate(Business[1],node[3].transform.position,node[3].transform.rotation);
				}
				else if(randint <= 20 && randint >= 21){
					Instantiate(Tourist[1],node[3].transform.position,node[3].transform.rotation);
				}
			}
			else if(SpawnID == 5){
				if(randint >= 1 && randint <= 13){
					Instantiate(Careful[4],node[4].transform.position,node[4].transform.rotation);
				}
				else if(randint >= 14 && randint <= 19){
					Instantiate(Business[0],node[4].transform.position,node[4].transform.rotation);
				}
				else if(randint >= 20 && randint >= 21){
					Instantiate(Tourist[0],node[4].transform.position,node[4].transform.rotation);
				}
			}
			else if(SpawnID == 6){
				if(randint >= 1 && randint <= 12){
					Instantiate(Careful[5],node[5].transform.position,node[5].transform.rotation);
				}
				else if(randint >= 13 && randint <= 19){
					Instantiate(Business[1],node[5].transform.position,node[5].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[1],node[5].transform.position,node[5].transform.rotation);
				}
			}
			else if(SpawnID == 7){
				if(randint >= 1 && randint <= 11){
					Instantiate(Careful[6],node[6].transform.position,node[6].transform.rotation);
				}
				else if(randint >= 12 && randint <= 19){
					Instantiate(Business[0],node[6].transform.position,node[6].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[0],node[6].transform.position,node[6].transform.rotation);
				}
			}
			else if(SpawnID == 8){
				if(randint >= 1 && randint <= 10){
					Instantiate(Careful[7],node[7].transform.position,node[7].transform.rotation);
				}
				else if(randint >= 11 && randint <= 19){
					Instantiate(Business[1],node[7].transform.position,node[7].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[1],node[7].transform.position,node[7].transform.rotation);
				}
			}
			else if(SpawnID == 9){
				if(randint >= 1 && randint <= 9){
					Instantiate(Careful[8],node[8].transform.position,node[8].transform.rotation);
				}
				else if(randint >= 10 && randint <= 19){
					Instantiate(Business[0],node[8].transform.position,node[8].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[0],node[8].transform.position,node[8].transform.rotation);
				}
			}
			else if(SpawnID == 10){
				if(randint >= 1 && randint <= 8){
					Instantiate(Careful[9],node[9].transform.position,node[9].transform.rotation);
				}
				else if(randint >= 9 && randint <= 19){
					Instantiate(Business[1],node[9].transform.position,node[9].transform.rotation);
				}
				else if(randint >= 20 && randint <= 21){
					Instantiate(Tourist[1],node[9].transform.position,node[9].transform.rotation);
				}
			}
		}
	}
}
