using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetCollision : MonoBehaviour
{
    public GameObject part;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            GameObject tempObj = Instantiate(part, other.contacts[0].point, transform.rotation);
            Destroy(tempObj, 3);
        }
    }
}
