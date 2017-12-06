using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	void Update () {
        // TODO: Work in progress
        // Pivot camera down, and make it sit higher as it zooms out (giving the player a look 'over' their planet)
        // Set a max distance and min distance for zoom.

        // Possibley decide do this by finding a good min position and good max position, store them as private positions (rotation + position)
        // then do something like lerp between those points based on scroll wheel

        Vector3 direction = transform.position - transform.parent.position;
        direction.Normalize();

        transform.position = transform.position + (direction * Input.GetAxis("Mouse ScrollWheel")) * 2;

        //transform.position = Vector3.MoveTowards(transform.position, transform.parent.position, .5f);
    }
}
