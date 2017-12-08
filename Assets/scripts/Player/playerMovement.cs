using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
	public Camera cam;
    public float thrust = 1;

	private Vector3 moveDir;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		Move ();
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
			rb.AddForce(moveDir * thrust);
    }

	void Move()
	{
		float h = CrossPlatformInputManager.GetAxis("Horizontal");
		float v = CrossPlatformInputManager.GetAxis("Vertical");

		moveDir =  (v*cam.transform.forward + h*cam.transform.right).normalized;
	}
}
