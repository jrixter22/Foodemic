using UnityEngine;
using System.Collections;

public class FoodFighter : MonoBehaviour {
	/*Sets up the arrays for shoot position, the food being shot, detecting how much the foodfighter is hit, 
	and how many times they can get it*/
	public bool shooting;
	public Transform[] node;
	public Rigidbody[] bullet;
	public float shootForce = 2000f;
	public float shootWaitTime = 0.2f;
	public int ammo;
	public int shootPos;
	public int hit;
	public int hitpoints = 10;
	
	// Use this for initialization
	void Start () {
		//Sorts the GameObject and spawn arrays 
		sortArray ();
		ammo = hitpoints * 2;
		shooting = true;
	}

	//Makes sure the gun shoots at a specific interval
	IEnumerator shootWait(){
		/*while (ammo > 0) {
			if(shooting){
				Instantiate(bullet[0], node[shootPos].position, node[shootPos].rotation);
				shootPos += 1;
				if(shootPos >= node.Length){
					shootPos = 0;
				}
				ammo -= 1;
				shooting = false;
				yield return new WaitForSeconds (shootWaitTime);
				shooting = true;
			}
			if(ammo <= 0){
				break;
			}
		}*/
		if(shooting){
			//Instantiate(bullet[0], node[shootPos].position, node[shootPos].rotation);
			Rigidbody instanceBullet = Instantiate(bullet[0], transform.position, node[0].rotation) as Rigidbody;
			instanceBullet.GetComponent<Rigidbody>().AddForce(node[0].right * shootForce);
			shootPos += 1;
			if(shootPos >= node.Length){
				shootPos = 0;
			}
			ammo -= 1;
			shooting = false;
			yield return new WaitForSeconds (shootWaitTime);
			shooting = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Spawns object once hit enough by the player
		if (hit >= hitpoints) {
			StartCoroutine(shootWait());
			ammo = hitpoints * 2;
			sortArray();
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
		for (int i = 0; i < bullet.Length; i++) {
			Rigidbody temp = bullet[i];
			int randomIndex = Random.Range(i, bullet.Length);
			bullet[i] = bullet[randomIndex];
			bullet[randomIndex] = temp;
		}
	}
	
	//Detects when the foodfighter was hit by food
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			hit += 1;
		}
	}
}
