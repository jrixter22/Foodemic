using UnityEngine;
using System.Collections;

public class DestroyBillboard : MonoBehaviour {
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "GoldCustomer" || col.gameObject.tag == "Billboard") {
			Destroy (gameObject);
		} else {
			Debug.Log("hit");
		}
	}
}
