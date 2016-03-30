using UnityEngine;
using System.Collections;

public class TurretAmmo : MonoBehaviour {
	public float speed = 100f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime, Space.Self);
	}

	//Destroy food on collision
	void OnCollisionEnter(Collision col) {
		/*if (col.gameObject.tag == "Bullet") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Billboard") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Customer") {
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Stand") {
			Destroy (gameObject);
		} else */if (col.gameObject.tag == "GoldCustomer") {
			/*if(col.rigidbody){
				col.rigidbody.AddExplosionForce(100.0f, transform.position, 1000.0f, 20.0f);
			}*/
			col.transform.parent = this.transform;
			//Destroy (gameObject);
		}
	}
}
