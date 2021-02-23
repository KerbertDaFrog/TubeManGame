using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMan : MonoBehaviour
{
    public float health;
    public bool inWindZone = false;
    public GameObject windZone;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(inWindZone)
        {
            rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "WindArea")
        {
            windZone = coll.gameObject;
            inWindZone = true;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "WindArea")
        {
            inWindZone = false;
        }
    }
}
