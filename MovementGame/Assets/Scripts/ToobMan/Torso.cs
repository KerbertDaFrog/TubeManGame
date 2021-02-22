using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torso : MonoBehaviour
{
    public float thrust;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("flingtorsoforwards");
            rb.AddRelativeForce(Vector3.forward * thrust);
        }

        if(Input.GetKey(KeyCode.S))
        {
            Debug.Log("flingtorsobackwards");
            rb.AddRelativeForce(-Vector3.forward * thrust);
        }
    }
}
