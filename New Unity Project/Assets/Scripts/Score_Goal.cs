using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_Goal : MonoBehaviour {
	//public static int truck;
	public GameObject truckdriver;
	public static float points = 0f;
	public float goal = 1f;
	public int truck;
	private int size;

	// Use this for initialization
	void Start () {
		//winGame ();
		if (truckdriver == null) {
			truckdriver = GameObject.FindGameObjectWithTag("Max");
			truck = 1;
			if(truckdriver == null){
				truckdriver = GameObject.FindGameObjectWithTag("Cindi");
				truck = 2;
				if(truckdriver == null){
					truckdriver = GameObject.FindGameObjectWithTag("Lucy");
					truck = 3;
				}
			}
		}
	}

// Update is called once per frame
	void Update () {
		if (points < 0) {
			points = 0;
		}

	}
	
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			points += .01f;
			Debug.Log (points);
			if (this.gameObject.tag == "MaxCustomer" && truck == 1) {
				gameObject.AddComponent<Explosion>();
			}else if(this.gameObject.tag == "MaxCustomer" && truck != 1){
				points -= .02f;
				Debug.Log (points);
				gameObject.AddComponent<Explosion>();
			}else if(this.gameObject.tag == "CindiCustomer" && truck == 2){
				gameObject.AddComponent<Explosion>();
			}else if(this.gameObject.tag == "CindiCustomer" && truck != 2){
				points -= .02f;
				Debug.Log (points);
				gameObject.AddComponent<Explosion>();
			}else if(this.gameObject.tag == "LucyCustomer" && truck == 3){
				gameObject.AddComponent<Explosion>();
			}else if(this.gameObject.tag == "LucyCustomer" && truck != 3){
				points -= .02f;
				Debug.Log (points);
				gameObject.AddComponent<Explosion>();
			}
		} else if (col.gameObject.tag == "Billboard") {
			points += .15f;
			Debug.Log (points);
			Destroy (gameObject);
		} else if (col.gameObject.tag == "TurretBullet") {
			points -= .003f;
			Debug.Log (points);
			gameObject.AddComponent<Explosion>();
		} /*else if (col.gameObject.tag == "MaxBullet") {
			points += .01f;
			Debug.Log (points);
			if (this.gameObject.tag != "MaxCustomer" || this.gameObject.tag != "GoldCustomer") {
				points -= .015f;
				Debug.Log (points);
			}
		}
		/*else if (col.gameObject.tag == "Customer") {
			Destroy (gameObject, 2f);

		} else if (col.gameObject.tag == "GoldCustomer") {
			Destroy (gameObject, 2f);
		}*/
	}
		// set up a get and set for the above code 


	public float GetPoints(){

		return points;
	
	}

	public float SetPoints(float newPoints){

		points = newPoints;

		return points;

	}

	void winGame () {
		if (points >= goal){
			Application.LoadLevel (5);
		}
	}


}