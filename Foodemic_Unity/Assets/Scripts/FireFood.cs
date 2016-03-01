using UnityEngine;
using System.Collections;

public class FireFood : MonoBehaviour {
	
	//Set up variables to get specified in unity
	public Rigidbody prefabBullet;
	public float shootForce;
	public Transform shootPosition;
	public int ammo = 8;
	public AudioClip HotSizzling;
	public AudioClip FireFoodSound ;
	
	void Update (){
		//Creates a projectile whenever the player presses the left mouse button
		if(Input.GetKeyDown(KeyCode.Space))
		{
			//Fires ammo when there is still some in the barrel
			if(ammo > 0)
			{
				//Creates the projectile
				GetComponent<AudioSource>().PlayOneShot(FireFoodSound);
				Rigidbody instanceBullet = Instantiate(prefabBullet, transform.position, shootPosition.rotation) as Rigidbody;
				instanceBullet.GetComponent<Rigidbody>().AddForce(shootPosition.right * shootForce);
				ammo -= 1;
			}
		}
		else if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.R)) && ammo == 0) //Reloads the turret
		{
			ammo = 8;
			GetComponent<AudioSource>().PlayOneShot(HotSizzling);
		}
	}
}