using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour {

    public float rotateSpeed = 1;

	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;

        transform.Rotate(vertical, horizontal, 0);
    }
}
