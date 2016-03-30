using UnityEngine;
using System.Collections;

public class MascotSpawn : MonoBehaviour {
	//public int randint = Random.Range(3,5);
	public GameObject mascot;
	public GameObject eco;
	public Transform node;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if ( Time.fixedTime == 1) {
			Instantiate(mascot,node.transform.position,node.transform.rotation);
		}*/
		if (Time.fixedTime % 25 == 0 && Time.fixedTime != 0) {
			Instantiate(eco,node.transform.position,node.transform.rotation);
		}
	}
}
