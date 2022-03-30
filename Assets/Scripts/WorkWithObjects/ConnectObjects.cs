using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectObjects : MonoBehaviour
{
    // Needs to be changed

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");

        if (collision.gameObject.tag == "Untagged")
        {
            Debug.Log("Nothing change");
        }
        else if (collision.gameObject.tag == "Object")
        {
            Debug.Log("Joint objects!");

            GetComponent<FixedJoint>().connectedBody = collision.gameObject.GetComponent<Rigidbody>();
           collision.gameObject.GetComponent<FixedJoint>().connectedBody = GetComponent<Rigidbody>();
        }
        
    }
}
