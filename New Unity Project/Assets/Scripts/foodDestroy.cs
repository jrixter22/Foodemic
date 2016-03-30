using UnityEngine;
using System.Collections;

public class foodDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Destroy food on collision
	void OnCollisionEnter(Collision col) {
		/*if (col.gameObject.tag == "Bullet") {
			Destroy (gameObject);
		} else*/ if (col.gameObject.tag == "Billboard") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "MaxCustomer") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Stand") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "CindiCustomer") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "LucyCustomer") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "GoldCustomer") {
			Destroy (gameObject);
		}
	}
}
