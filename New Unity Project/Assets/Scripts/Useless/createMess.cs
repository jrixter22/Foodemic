using UnityEngine;
using System.Collections;

public class createMess : MonoBehaviour 
{
	//public gameObject Mess;
	//public Rigidbody Bullets;
	static float score = 0f;

	void Update()
	{
		/*float distance = (Bullets.transform.position - transform.position).magnitude;
		if (distance < 0.1f) 
		{
			//Destroy(Bullets);
		}*/
		//Debug.Log("ping");
//		CharacterController controller = GetComponent < CharacterController > ();
//		if (controller.collisionFlags == CollisionFlags.None)
//			print ("Free floating");
//		if ((controller.collisionFlags & CollisionFlags.Sides) != 0)
//			print ("Touching Sides");
//		if (controller.collisionFlags == CollisionFlags.Sides)
//			print ("Only Touching Sides, Nothing Else");
		//Debug.Log (score);
	}

	void OnCollisionEnter(Collision col)
	{
		//print ("detect");
		/*score += 1f;
		Debug.Log (score);
		Destroy (gameObject);*/
		if (col.gameObject.tag == "Customer") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		}
		/*if (col.gameObject.name == "Cursor") {
			//score += 1;
			Destroy (gameObject);
			//Instantiate("Mess");
		} */
		/*if (col.gameObject.name == "Careful1") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful2") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful3") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful4") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful5") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful6") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful7") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful8") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful9") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Careful10") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Business1") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Business2") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Tourist1") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		} else if (col.gameObject.name == "Tourist2") {
			score += 1f;
			Debug.Log (score);
			Destroy (gameObject);
		}*/


	}
}
