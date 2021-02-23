using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCol : MonoBehaviour
{
    public GameObject pickables;
    public GameObject players;

    private void OnCollisionEnter(Collision collision)
    {
        Physics.IgnoreCollision(pickables.GetComponent<Collider>(), players.GetComponent<Collider>(), false);
    }
}
