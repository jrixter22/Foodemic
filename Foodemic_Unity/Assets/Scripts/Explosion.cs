using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = transform.localScale * 1.05f;
	}
}
