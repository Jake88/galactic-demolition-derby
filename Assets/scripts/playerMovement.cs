using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float thrust = 1;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * thrust);
            Debug.Log(rb.velocity);
        }
    }
}
