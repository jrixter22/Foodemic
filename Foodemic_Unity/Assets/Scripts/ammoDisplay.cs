using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ammoDisplay : FireFood {
	
	public FireFood magazine;
	public Image ammoFull;
	public Image ammo7;
	public Image ammo6;
	public Image ammo5;
	public Image ammo4;
	public Image ammo3;
	public Image ammo2;
	public Image ammo1;
	public Image reloadImage;
	
void Update (){
		switch (magazine.ammo){
			
		case 8:
			Debug.Log ("Ammo is 8");
			ammoFull.enabled = true;
			ammo7.enabled = true;
			ammo6.enabled = true;
			ammo5.enabled = true;
			ammo4.enabled = true;
			ammo3.enabled = true;
			ammo2.enabled = true;
			ammo1.enabled = true;
			reloadImage.enabled = false;
			break;

		case 7:
			Debug.Log ("Ammo is 7");
			ammoFull.enabled = false;
			break;

		case 6:
			Debug.Log ("Ammo is 6");
			ammo7.enabled = false;
			break;

		case 5:
			Debug.Log ("Ammo is 5");
			ammo6.enabled = false;
			break;

		case 4:
			Debug.Log ("Ammo is 4");
			ammo5.enabled = false;
			break;
		case 3:
			Debug.Log ("Ammo is 3");
			ammo4.enabled = false;
			break;
		case 2:
			Debug.Log ("Ammo is 2");
			ammo3.enabled = false;
			break;
		case 1:
			Debug.Log ("Ammo is 1");
			ammo2.enabled = false;
			break;

		case 0:
			Debug.Log ("Ammo is 0");
			ammo1.enabled = false;
			reloadImage.enabled = true;
			break;
		}
		
		
	}
	
}
