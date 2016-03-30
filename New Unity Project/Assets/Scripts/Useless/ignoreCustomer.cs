using UnityEngine;
using System.Collections;

public class ignoreCustomer : MonoBehaviour {
	public Transform careful1;
	public Transform careful2;
	public Transform careful3;
	public Transform careful4;
	public Transform careful5;
	public Transform careful6;
	public Transform careful7;
	public Transform careful8;
	public Transform careful9;
	public Transform careful10;
	public Transform business1;
	public Transform business2;
	public Transform tourist1;
	public Transform tourist2;
	public Transform mascot;
	public Transform eco;
	
	// Use this for initialization
	void Start () {
		/*Physics.IgnoreCollision(careful1.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful3.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful4.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful5.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful6.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful7.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful8.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful9.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful10.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(business1.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(business2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(tourist1.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(tourist2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(mascot.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(eco.GetComponent<Collider>(), GetComponent<Collider>());*/
	}

	/*void OnCollisionEnter(Collision col){
		Physics.IgnoreCollision(careful1.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful3.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful4.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful5.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful6.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful7.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful8.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful9.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(careful10.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(business1.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(business2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(tourist1.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(tourist2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(mascot.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(eco.GetComponent<Collider>(), GetComponent<Collider>());
	}*/

	/*void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Customer") {
			Physics.IgnoreCollision(careful1.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful2.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful3.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful4.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful5.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful6.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful7.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful8.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful9.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(careful10.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(business1.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(business2.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(tourist1.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(tourist2.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(mascot.GetComponent<Collider>(), GetComponent<Collider>());
			Physics.IgnoreCollision(eco.GetComponent<Collider>(), GetComponent<Collider>());
		}
	}*/
	
	// Update is called once per frame
	void Update () {
		
	}
}
