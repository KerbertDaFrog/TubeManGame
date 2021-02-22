using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    public float thrust;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("flingleftarm");
            rb.AddRelativeForce(Vector3.up * thrust);
        }
    }
}
