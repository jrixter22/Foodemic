using UnityEngine;
using System.Collections;

public class foodExplosion : MonoBehaviour {
	public GameObject explodingFood;
	public Transform node;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Destroy food on collision
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Customer") {
			Instantiate (explodingFood,node.transform.position,node.transform.rotation);
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Stand") {
			Instantiate (explodingFood,node.transform.position,node.transform.rotation);
			Destroy (gameObject);
		} else if (col.gameObject.tag == "GoldCustomer") {
			Instantiate (explodingFood,node.transform.position,node.transform.rotation);
			Destroy (gameObject);
		}
		//Destroy (col.gameObject);
	}
}
