#pragma strict
//Set up variables to get specified in Unity
var prefabBullet:Rigidbody;
var shootForce:float;
var shootPosition:Transform;
var ammo:int = 5;

function Update()
{
	//Creates a projectile whenever the player presses the left mouse button
	if(Input.GetKeyDown(KeyCode.Space)/*GetButtonDown("Fire1")*/)
	{
		//Fires ammo when there is still some in the barrel
		if(ammo > 0)
		{
			//Creates the projectile
			var instanceBullet = Instantiate(prefabBullet, transform.position, shootPosition.rotation);
			instanceBullet.GetComponent.<Rigidbody>().AddForce(shootPosition.right * shootForce);
			ammo -= 1;
		}
	}
	else if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.R)/*.GetButtonDown("Fire2")*/) //Reloads the turret
	{
		ammo = 5;
	}
}