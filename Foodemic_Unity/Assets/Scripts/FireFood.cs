using UnityEngine;
using System.Collections;

public class FireFood : MonoBehaviour {
	
	//Set up variables to get specified in unity
	public GameObject truck;
	public Rigidbody[] prefabBullet;
	public float shootForce;
	public float shootWaitTime = 0.25f;
	public Transform shootPosition;
	public int food = 0;
	public int ammo/* = 8*/;
	public int totalAmmo;
	public int maxAmmo = 24;
	public int lucyAmmo = 8;
	public int cindiAmmo = 8;
	public AudioClip HotSizzling;
	public AudioClip FireFoodSound;
	public bool shooting;
	/*public int sec2Wait = 2;
	public int totalSec = 0;*/

	void Start(){
		//Assigns the starting ammo based on which gun is being used
		if (truck.gameObject.tag == "Max") {
			ammo = maxAmmo;
			totalAmmo = maxAmmo;
			shooting = true;
		} else if (truck.gameObject.tag == "Lucy") {
			ammo = lucyAmmo;
			totalAmmo = lucyAmmo;
		} else if (truck.gameObject.tag == "Cindi") {
			ammo = cindiAmmo;
			totalAmmo = cindiAmmo;
		}
	}
	
	void Update (){
		//Determines whether to do fully automatic or semi-automatic fire based on whether you're playing Max or not
		if (truck.gameObject.tag == "Max") {
			//Creates a projectile whenever the player presses/holds the space button
			if(Input.GetKey(KeyCode.Space))
			{
				//Fires ammo when there is still some in the barrel
				if(ammo > 0)
				{
					//Creates the projectile
					StartCoroutine(shootWait());
				}
			}
			else if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.R)) && ammo <= 39) //Reloads the turret
			{
				StartCoroutine(reload());
				GetComponent<AudioSource>().PlayOneShot(HotSizzling);
				/*food += 1;
				if(food > 2){
					food = 0;
				}*/
			}
		} else {
			//Creates a projectile whenever the player presses the space button
			if(Input.GetKeyDown(KeyCode.Space))
			{
				//Fires ammo when there is still some in the barrel
				if(ammo > 0)
				{
					//Creates the projectile based on which gun it is
					if(truck.gameObject.tag == "Lucy"){
						GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
						Instantiate(prefabBullet[food], shootPosition.position, shootPosition.rotation);
						ammo -= 1;
					}else if(truck.gameObject.tag == "Cindi"){
						GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
						Rigidbody instanceBullet = Instantiate(prefabBullet[food], transform.position, shootPosition.rotation) as Rigidbody;
						instanceBullet.GetComponent<Rigidbody>().AddForce(shootPosition.right * shootForce);
						ammo -= 1;
					}
				}
			}
			else if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.R)) && ammo <= totalAmmo-1) //Reloads the turret
			{
				StartCoroutine(reload());
				GetComponent<AudioSource>().PlayOneShot(HotSizzling);
				/*food += 1;
				if(food > 2){
					food = 0;
				}*/
			}
		}
	}

	//Makes sure the gun shoots at a specific interval
	IEnumerator shootWait(){
		if(shooting){
			GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
			Rigidbody instanceBullet = Instantiate(prefabBullet[food], transform.position, shootPosition.rotation) as Rigidbody;
			instanceBullet.GetComponent<Rigidbody>().AddForce(shootPosition.right * shootForce);
			ammo -= 1;
			shooting = false;
			yield return new WaitForSeconds (shootWaitTime);
			shooting = true;
		}
	}

	//Handles the reloading based on how the player is playing as
	IEnumerator reload(){
		if (truck.gameObject.tag == "Max") {
			if (ammo > 0) {
				ammo = 0;
				yield return new WaitForSeconds (3);
				ammo = maxAmmo;
			} else {
				yield return new WaitForSeconds (5);
				ammo = maxAmmo;
			}
		} else if (truck.gameObject.tag == "Lucy") {
			if (ammo > 0) {
				ammo = 0;
				yield return new WaitForSeconds (1);
				ammo = lucyAmmo;
			} else {
				yield return new WaitForSeconds (2);
				ammo = lucyAmmo;
			}
		} else if (truck.gameObject.tag == "Cindi") {
			if (ammo > 0) {
				ammo = 0;
				yield return new WaitForSeconds (1);
				ammo = 8;
			} else {
				yield return new WaitForSeconds(2);
				ammo = 8;
			}
		}
	}
}