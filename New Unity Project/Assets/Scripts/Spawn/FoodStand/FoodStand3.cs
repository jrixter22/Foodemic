using UnityEngine;
using System.Collections;

public class FoodStand3 : MonoBehaviour {
	//Sets up variables to determine if the stand is destroyed, where the stand is going, and how fast its going
	public bool die;
	public GameObject target;
	public float speed = 0.2f;
	
	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Target3");
	}
	
	// Update is called once per frame
	void Update () {
		//The stand moves up from the ground
		Vector3 direction = (target.transform.position - transform.position).normalized;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;

		if (die) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Bullet") {
			die = true;
		} 
	}
}
