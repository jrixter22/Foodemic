using UnityEngine;
using System.Collections;

public class DeicdeAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int randInt = Random.Range (1, 30);
		if (this.gameObject.tag == "GoldCustomer" && Application.loadedLevelName != "Cindi Beach Level") {
			gameObject.AddComponent<Business> ();
		} else if (this.gameObject.tag == "GoldCustomer" && Application.loadedLevelName == "Cindi Beach Level") {
			gameObject.AddComponent<Careful> ();
		} else if (randInt >= 1 && randInt <= 15) {
			gameObject.AddComponent<Careful> ();
		} else if (randInt >= 16 && randInt <= 24) {
			gameObject.AddComponent<Tourist> ();
		} else {
			gameObject.AddComponent<Circles> ();
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
