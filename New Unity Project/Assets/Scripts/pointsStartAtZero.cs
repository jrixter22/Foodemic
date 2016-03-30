using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointsStartAtZero : Score_Goal {

	// Use this for initialization
	void Awake () {
		points = 0f;
	}

	void Update () {
		Debug.Log (points);
	}
}