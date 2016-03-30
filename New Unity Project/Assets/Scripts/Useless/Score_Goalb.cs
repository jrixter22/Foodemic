using UnityEngine;
using System.Collections;

public class Score_Goalb : MonoBehaviour {
	public static float numCol = 0f;
	public static int points = 0;
	public static int goal = 1000;
	public bool hungry = true;
		
	// Use this for initialization
	void Start () {
		//winGame ();	
	}

	void winGame () {
		if (points >= goal){
			Application.LoadLevel (4);
		}
	}
		
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			if (hungry) {
				points += 10;
				Debug.Log (points);
				//this.isKinematic = false;
				Destroy (gameObject);
				hungry = false;
			}
		} else if (col.gameObject.tag == "Billboard") {
			points += 100;
			Debug.Log (points);
			Destroy (gameObject);
		} /*else if (col.gameObject.tag == "Stand") {
			/*numCol += 0.5f;
			Debug.Log(numCol);
			Destroy (gameObject);
			//Physics.IgnoreCollision(this.GetComponent<Collider>(), GetComponent<Collider>());
		} else if (col.gameObject.tag == "Stand") {
			//hungry = false;
			Destroy (gameObject);
		}*/
		// set up a get and set for the above code 
	}
}
