using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject pauseGameButton;
	public GameObject pauseGameWindow;

	// Use this for initialization
	void Awake () {
		OnResumeGame ();

		pauseGameWindow.SetActive (false);
	}

	public void OnGamePause(){

		pauseGameWindow.SetActive (true);
		pauseGameButton.SetActive (false);
		Time.timeScale = 0;

	}

	public void OnResumeGame (){

		if (Input.GetKey (KeyCode.Escape)) {
			
			OnResumeGame ();
		}


		pauseGameWindow.SetActive (false);
		pauseGameButton.SetActive (true);
		Time.timeScale = 1;
	

	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {

			OnGamePause ();
			}
	
		if (Input.GetKey (KeyCode.P)) {
			
			OnResumeGame ();
		}

		
	}
}
