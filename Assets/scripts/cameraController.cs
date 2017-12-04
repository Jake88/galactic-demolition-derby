using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = transform.position - transform.parent.position;
        direction.Normalize();

        transform.position = transform.position + (direction * Input.GetAxis("Mouse ScrollWheel")) * 2;

        //transform.position = Vector3.MoveTowards(transform.position, transform.parent.position, .5f);
    }
}
