using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class superMeterManager : Score_Goal {
	
	public Image superMeter;


	// Use this for initialization
	void Start () {
		superMeter = GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {

		superMeter.fillAmount = points / goal;

	}
}
