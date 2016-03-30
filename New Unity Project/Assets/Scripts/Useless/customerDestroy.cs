using UnityEngine;
using System.Collections;

public class customerDestroy : MonoBehaviour {
	//public float delay = 6f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 14f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*void OnCollisionEnter(Collision col)
	{
		/*delay--;
		Destroy (gameObject, delay);
		if (col.gameObject.tag == "Customer" || col.gameObject.tag == "Billboard") {
			Destroy (gameObject, 1f);
		}
	}*/
}
