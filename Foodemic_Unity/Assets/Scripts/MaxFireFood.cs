using UnityEngine;
using System.Collections;

public class MaxFireFood : MonoBehaviour {
	
	//Set up variables to get specified in unity
	public bool shooting;
	public Rigidbody[] prefabBullet;
	public float shootForce;
	public float shootWaitTime = 0.1f;
	public Transform shootPosition;
	public int food = 0;
	public int ammo = 40;
	public AudioClip HotSizzling;
	public AudioClip FireFoodSound;
	/*public int sec2Wait = 2;
	public int totalSec = 0;*/

	// Use this for initialization
	void Start () {
		shooting = true;
	}
	
	void Update (){
		//Creates a projectile whenever the player presses the left mouse button
		if(Input.GetKey(KeyCode.Space))
		{
			//Fires ammo when there is still some in the barrel
			if(ammo > 0)
			{
				//Creates the projectile
				StartCoroutine(shootWait());
				if(shooting){
					/*GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
					Rigidbody instanceBullet = Instantiate(prefabBullet[food], transform.position, shootPosition.rotation) as Rigidbody;
					instanceBullet.GetComponent<Rigidbody>().AddForce(shootPosition.right * shootForce);
					ammo -= 1;*/
					shooting = false;
					StartCoroutine(shootWait());
					shooting = true;
				}
				/*GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
				Rigidbody instanceBullet = Instantiate(prefabBullet[food], transform.position, shootPosition.rotation) as Rigidbody;
				instanceBullet.GetComponent<Rigidbody>().AddForce(shootPosition.right * shootForce);
				ammo -= 1;
				/*food += 1;
				if(food > 2){
					food = 0;
				}*/
			}
		}
		else if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.R)) && ammo <= 39) //Reloads the turret
		{
			StartCoroutine(reload());
			GetComponent<AudioSource>().PlayOneShot(HotSizzling);
			food += 1;
			if(food > 2){
				food = 0;
			}
			//StartCoroutine(reload);
		}
	}

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
		//yield return new WaitForSeconds (shootWaitTime);
	}
	
	IEnumerator reload(){
		if (ammo > 0) {
			ammo = 0;
			yield return new WaitForSeconds (3);
			ammo = 40;
		} else {
			yield return new WaitForSeconds(5);
			ammo = 40;
		}
	}
}
