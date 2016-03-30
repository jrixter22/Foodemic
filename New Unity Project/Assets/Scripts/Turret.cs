using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {
	public GameObject customer;
	public Vector3 target;
	public Transform turret;
	public GameObject bullet;
	public Transform bulletSpawn;
	public float shootForce = 3000;
	public float timer = 0.0f;
	float speed = 1000;
	float firerate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (customer == null) {
			customer = GameObject.FindGameObjectWithTag ("Customer");
			/*if (customer == null) {
				customer = GameObject.FindGameObjectWithTag ("GoldCustomer");
			}*/
			target = customer.transform.position;
		}
		//turret.transform.LookAt(target);

		Quaternion rotate = Quaternion.LookRotation (customer.transform.position - turret.position);
		turret.rotation = Quaternion.Slerp (turret.rotation, rotate, Time.deltaTime*speed);
		//StartCoroutine (shoot ());
		timer += Time.deltaTime;
		if(timer > firerate){
			/*Rigidbody instanceBullet = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation) as Rigidbody;
			instanceBullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.right * shootForce);*/
			Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
			timer = 0.0f;
		}

		//Determines how far away the target is
		float distance = (customer.transform.position - transform.position).magnitude;
		if (distance > 20) {
			firerate = 0.5f;
		} else {
			firerate = 1.5f;
		}
	}

	/*IEnumerator shoot(){
		yield return new WaitForSeconds (1);
		Rigidbody instanceBullet = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation) as Rigidbody;
		instanceBullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.right * shootForce);
	}*/
}
