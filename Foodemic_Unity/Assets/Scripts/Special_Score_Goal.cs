﻿using UnityEngine;
using System.Collections;

public class Special_Score_Goal : MonoBehaviour {
	public static float points = 0f;
	public float goal = 1f;
	
	
	
	
	// Use this for initialization
	void Start () {
		//winGame ();
		
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			points += .05f;
			Debug.Log (points);
		} else if (col.gameObject.tag == "Billboard") {
			points += .20f;
			Debug.Log (points);
			Destroy (gameObject);
		} /*else if (col.gameObject.tag == "Customer") {
			Destroy (gameObject, 2f);
		}*/
		// set up a get and set for the above code 
	}
	
	public float GetPoints(){
		
		return points;
		
	}
	
	public float SetPoints(float newPoints){
		
		points = newPoints;
		
		return points;
		
	}
	
	void winGame () {
		if (points >= goal){
			Application.LoadLevel (4);
		}
	}
}
