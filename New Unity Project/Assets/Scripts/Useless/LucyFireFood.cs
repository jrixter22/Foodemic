using UnityEngine;
using System.Collections;

public class LucyFireFood : MonoBehaviour {
	
	//Set up variables to get specified in unity
	public Rigidbody[] prefabBullet;
	public float shootForce;
	public Transform shootPosition;
	public int food = 0;
	public int ammo = 8;
	public AudioClip HotSizzling;
	public AudioClip FireFoodSound;
	public bool reloading;
	/*public int sec2Wait = 2;
	public int totalSec = 0;*/
	
	void Update (){
		//Creates a projectile whenever the player presses the left mouse button
		if(Input.GetKeyDown(KeyCode.Space))
		{
			//Fires ammo when there is still some in the barrel
			if(ammo > 0)
			{
				//Creates the projectile
				GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
				/*Rigidbody instanceBullet = Instantiate(prefabBullet[food], transform.position, shootPosition.rotation) as Rigidbody;
				instanceBullet.GetComponent<Rigidbody>().AddForce(shootPosition.right * shootForce);*/
				Instantiate(prefabBullet[food], shootPosition.position, shootPosition.rotation);
				ammo -= 1;
				/*food += 1;
				if(food > 2){
					food = 0;
				}*/
			}/*else if(ammo == 0 && reloading != true){
				StartCoroutine(reload());
				GetComponent<AudioSource>().PlayOneShot(HotSizzling);
				/*food += 1;
				if(food > 2){
					food = 0;
				}
			}*/
		}
		else if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.R)) && ammo <= 7/*reloading != true*/) //Reloads the turret
		{
			StartCoroutine(reload());
			GetComponent<AudioSource>().PlayOneShot(HotSizzling);
			/*food += 1;
			if(food > 2){
				food = 0;
			}*/
			//StartCoroutine(reload);
		}
	}
	
	IEnumerator reload(){
		if (ammo > 0) {
			ammo = 0;
			yield return new WaitForSeconds (1);
			ammo = 8;
		} else {
			yield return new WaitForSeconds(2);
			ammo = 8;
		}
		/*reloading = true;
		yield return new WaitForSeconds (1);
		ammo += 1;
		reloading = false;*/
	}
}
