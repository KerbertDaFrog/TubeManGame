using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    public GameObject objectHeld;

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
            objectHeld.transform.parent = transform;
        }      
    }

    private void ReleaseObject()
    {
        objectHeld.transform.parent = null;
        objectHeld = null;
    }

    private void ChildRB(GameObject _object, bool isKinematic)
    {
        foreach (var rb in _object.GetComponentsInChildren<Rigidbody>()) rb.isKinematic = isKinematic;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ReleaseObject();
        }

        if(objectHeld != null)
        {

        }
    }
}
