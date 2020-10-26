using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float force;

    public Rigidbody rb;

    private Vector3 start, meta, roznica;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        start = transform.position;
        meta = new Vector3(10, 0, 0);
        roznica = meta - start;

    }


    
    void FixedUpdate()
    {
        while (transform.position.x != 10.0)
        {

            rb.MovePosition(transform.position + roznica * Time.deltaTime);
        }
    }
}
