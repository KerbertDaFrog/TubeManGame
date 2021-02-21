using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMove : MonoBehaviour
{
    public float speed;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("moving");
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }
}
