using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public GameObject part;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("asd");

        if (other.gameObject.tag == "enemy")
        { 
        GameObject tempObj = Instantiate(part, other.contacts[0].point, transform.rotation);
        Destroy(tempObj, 3);
     }
    }
}
