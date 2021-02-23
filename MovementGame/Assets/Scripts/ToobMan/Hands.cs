using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    public GameObject objectHeld;

    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pickup")
        {
            PickedUpObject(collision.gameObject);
        }
    }

    private void PickedUpObject(GameObject _object)
    {
        if(objectHeld == null)
        {
            objectHeld = _object;
            Rigidbody[] bodies = objectHeld.GetComponentsInChildren<Rigidbody>();
            for (int i = 0; i < bodies.Length; i++)
            {
                bodies[i].isKinematic = true;
            }
            objectHeld.transform.parent = transform;
        } 
    }

    private void ReleaseObject()
    {
        Rigidbody[] bodies = objectHeld.GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < bodies.Length; i++)
        {
            bodies[i].isKinematic = false;
        }
        Physics.IgnoreCollision(objectHeld.GetComponent<Collider>(), GetComponent<Collider>());
        objectHeld.transform.parent = null;
        objectHeld = null;    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(objectHeld != null)
            {
                ReleaseObject();
            }           
        }
    }
}
