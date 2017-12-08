using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothFollow : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	public Vector3 lookAtOffset;
	public float smoothSpeed = 1;
	public float rotateSpeed = 1;

	private Vector3 vel = Vector3.zero;
	private Vector3 mouseRot;

	void FixedUpdate () 
	{
		float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		mouseRot = new Vector3 (vertical, horizontal, 0);
			
		Vector3 desiredPos = target.position + offset;
		Vector3 smoothedPos = Vector3.SmoothDamp (transform.position, desiredPos,ref vel,smoothSpeed * Time.deltaTime);
		transform.position = smoothedPos;
		transform.LookAt (target.position + lookAtOffset + mouseRot);
	}
}
