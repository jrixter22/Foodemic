using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiTimer : Score_Goal {

	public float gameTimer = 120;
	private Text uiTimerText;

	// Use this for initialization
	void Start () {
		uiTimerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		gameTimer -= Time.deltaTime;
		uiTimerText.text = gameTimer.ToString ("f0");
		print (gameTimer);

		if (gameTimer <= goal) {
		
			Application.LoadLevel(6);

		}
		if (points >= goal) {

			Application.LoadLevel(5);

		}

	}
}
