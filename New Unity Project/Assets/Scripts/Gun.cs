using UnityEngine;

using System.Collections;


public class Gun : MonoBehaviour {
	
	public GameObject goTarget;
	
	float maxDegreesPerSecond = 5.0f;
	
	private Quaternion qTo;
	
	
	// Use this for initialization
	
	void Start () {
		
		qTo = goTarget.transform.localRotation;
		
	}
	
	
	// Update is called once per frame
	
	void Update () {
		
		Vector3 v3T = goTarget.transform.position - transform.position;
		
		Vector3 v3Aim;
		
		v3Aim.x = 0.0f;
		
		v3Aim.y = v3T.y;
		
		//v3T.y = 0.0f;
		v3Aim.z = v3T.magnitude;
		
		qTo = Quaternion.LookRotation (v3Aim, Vector3.up);
		
		qTo *= Quaternion.Euler (0, 248, 0);
		
		transform.localRotation = Quaternion.RotateTowards (transform.localRotation, qTo, maxDegreesPerSecond * Time.deltaTime);
		
	}
	
}

