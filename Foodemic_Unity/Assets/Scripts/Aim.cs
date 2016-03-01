using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class Aim : MonoBehaviour {

	Vector3 target;
	float damp = 6.0f;


/*	public float XSensitivity = 2f;
	public float YSensitivity = 2f;
	public bool clampVerticalRotation = true;
	public float MinimumX = -90F;
	public float MaximumX = 90F;
	public bool smooth;
	public float smoothTime = 5f;
		
	
	private Quaternion m_CharacterTargetRot;
	private Quaternion m_CameraTargetRot;
	
	
	public void Init(Transform character, Transform camera)
	{
		m_CharacterTargetRot = character.localRotation;
		m_CameraTargetRot = camera.localRotation;
	}
	
	
	public void LookRotation(Transform character, Transform camera)
	{
		//float yRot = CrossPlatformInputManager.GetAxis("Mouse X") * XSensitivity;
		//float xRot = CrossPlatformInputManager.GetAxis("Mouse Y") * YSensitivity;

		float yRot = Input.GetAxis("Mouse X") * XSensitivity;
		float xRot = Input.GetAxis("Mouse Y") * YSensitivity;

		m_CharacterTargetRot *= Quaternion.Euler (0f, yRot, 0f);
		//m_CameraTargetRot *= Quaternion.Euler (-xRot, 0f, 0f);
		
		if(clampVerticalRotation)
			m_CameraTargetRot = ClampRotationAroundXAxis (m_CameraTargetRot);

		if(smooth)
		{
			character.localRotation = Quaternion.Slerp (character.localRotation, m_CharacterTargetRot,
			                                            smoothTime * Time.deltaTime);
			/*camera.localRotation = Quaternion.Slerp (camera.localRotation, m_CameraTargetRot,
			                                         smoothTime * Time.deltaTime);
		}
		else
		{
			character.localRotation = m_CharacterTargetRot;
			gameObject.localRotation = m_CameraTargetRot;
		}
	}
	
	
	Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		q.x /= q.w;
		q.y /= q.w;
		q.z /= q.w;
		q.w = 1.0f;
		
		float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan (q.x);
		
		angleX = Mathf.Clamp (angleX, MinimumX, MaximumX);
		
		q.x = Mathf.Tan (0.5f * Mathf.Deg2Rad * angleX);
		
		return q;
	}*/

	void Update(){
		//RotateView ();
		target.x = Input.GetAxis ("Mouse X");
		Quaternion rotate = Quaternion.LookRotation (target);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotate, Time.time * damp);
	}

	/*private void RotateView()
	{
		LookRotation (gameObject.transform);
	}
	public GameObject target;
	public float rotateSpeed = 5;
	Vector3 offset;
	
	void Start() {
		offset = target.transform.position - transform.position;
	}
	
	void LateUpdate() {
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		target.transform.Rotate(0, horizontal, 0);
		
		float desiredAngle = target.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = target.transform.position - (rotation * offset);
		
		transform.LookAt(target.transform);
	}*/
}